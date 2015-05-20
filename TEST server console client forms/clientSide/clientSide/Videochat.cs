using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Net.Sockets;

namespace clientSide
{
    using clientSide;
    using System.Net;
    using System.IO;
    using System.Threading;
    public partial class Videochat : Form
    {
        Voice v = new Voice();
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        private NAudio.Wave.WaveIn sourceStream = null;
        private NAudio.Wave.DirectSoundOut waveOut = null;
        Thread thdUDPServer;
        string nickname1, nickname2, ip1, ip2;
        bool dos = false;


        public IPAddress[] localIP;
        public IPAddress myIP;
        
        public Videochat()
        {
        }

        public Videochat(string nick1, string nick2, string ipe1, string ipe2)
        {
            InitializeComponent();
            BuscarDispositivos();

            this.nickname1 = nick1;
            this.nickname2 = nick2;
            this.ip1 = ipe1;
            this.ip2 = ipe2;

            groupBox1.Text = nickname1;
            groupBox2.Text = nickname2;

            localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    myIP = address;
                }
            }

            if (ipe2.Equals(myIP.ToString()))
                dos = true;
            else
                dos = false;
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cbxDispositivos.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivos.Text = cbxDispositivos.Items[0].ToString();

        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }

            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);

            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }

        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Image Imagen = (Image)eventArgs.Frame.Clone();
            ImageConverter converter = new ImageConverter();
            Byte[] senddata = (byte[])converter.ConvertTo(Imagen, typeof(byte[]));

            UdpClient udpClient = new UdpClient();

            if(dos)
                udpClient.Connect(IPAddress.Parse(ip1), 8080);
            else
                udpClient.Connect(IPAddress.Parse(ip2), 8080);
            udpClient.Send(senddata, senddata.Length);
            //udpClient.Close();
            EspacioCamara.Image = Imagen;
        }


        private void button1_Click(object sender, EventArgs e)
        { }

        private void receiveData()
        {
            UdpClient udpClient = new UdpClient(8080);
            IPEndPoint RemoteIpEndPoint;

            if(dos)
                RemoteIpEndPoint = new IPEndPoint(IPAddress.Parse(ip1), 0);
            else
                RemoteIpEndPoint = new IPEndPoint(IPAddress.Parse(ip2), 0);

            while (true)
            {
                try
                {
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    //udpClient.Close();
                    if (receiveBytes != null)
                    {
                        Image Imagen = byteArrayToImage(receiveBytes);
                        otherVideo.Image = Imagen;
                    }
                }
                catch { }
            }
        }



        public Image byteArrayToImage(Byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void EspacioCamara_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {}

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {

                if (ExisteDispositivo)
                {
                    ////aqui inicia codigo de microfono 
                    v.Send(2000);
                    v.Receive(2000);
                    ////aqui termina codigo de audio

                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.DesiredFrameRate = 15;
                    FuenteDeVideo.DesiredFrameSize = new Size(160, 120);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    Estado.Text = "Ejecutando Dispositivo…";
                    btnIniciar.Text = "Detener";
                    cbxDispositivos.Enabled = false;
                    groupBox1.Text = DispositivoDeVideo[cbxDispositivos.SelectedIndex].Name.ToString();


                    thdUDPServer = new Thread(new ThreadStart(receiveData));
                    thdUDPServer.Start();

                }
                else
                    Estado.Text = "Error: No se encuenta el Dispositivo";
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    Estado.Text = "Dispositivo Detenido…";
                    btnIniciar.Text = "Iniciar";
                    cbxDispositivos.Enabled = true;
                    thdUDPServer.Abort();


                }
            }
        }

        private void Videochat_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { thdUDPServer.Abort(); }
            catch { }
            try { v.rec_thread.Abort(); }
            catch { }
            TerminarFuenteDeVideo();
            cbxDispositivos.Enabled = true;
        }
    }
}