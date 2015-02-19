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

namespace webcam_test
{
    public partial class Form1 : Form
    {
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public Form1()
        {
            InitializeComponent();
            BuscarDispositivos();
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

        public  void Video_NuevoFrame( object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            EspacioCamara.Image = Imagen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    Estado.Text = "Ejecutando Dispositivo…";
                    btnIniciar.Text = "Detener";
                    cbxDispositivos.Enabled = false;
                    groupBox1.Text = DispositivoDeVideo[cbxDispositivos.SelectedIndex].Name.ToString();
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
                }
            }
        }
    }
}