using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Sending_voice_Over_IP
{
    class Voice
    {
        private string ip;
        private string path = Application.StartupPath + "\\buffer.wav";
        public ArrayList clientListV;

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        private int port;
        private Thread rec_thread;
        public int VPort
        {
            get { return port; }
            private set { port = value; }
        }

        private WaveIn sourceStream = null;
        private Byte[] Data_ary;
        private NetworkStream ns;
        private WaveFileWriter waveWriter = null;
        private System.Windows.Forms.Timer c_v = null;
        private Socket connector, sc, sock = null;


        void c_v_Tick(object sender, EventArgs e)
        {
            this.Dispose();
            Send_Bytes();

        }
        private void Send_Bytes()
        {
            Data_ary = File.ReadAllBytes(path);

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            foreach (IPAddress addr in clientListV)
            {
                if (!addr.Equals(RemoteIpEndPoint.Address))
                {
                    connector = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint ie = new IPEndPoint(addr, this.VPort);
                    ie.Address = IPAddress.Loopback;
                    connector.Connect(ie);
                    connector.Send(Data_ary, 0, Data_ary.Length, 0);
                    connector.Close();
                }
            }
        }

        private void sourceStream_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);

            waveWriter.Flush();

        }


        public void Receive(int port)
        {
            c_v = new System.Windows.Forms.Timer();
            c_v.Interval = 1000;
            c_v.Enabled = false;
            c_v.Tick += c_v_Tick;

            this.VPort = port;

            rec_thread = new Thread(new ThreadStart(VoiceReceive));
            rec_thread.Start();
        }



        private void VoiceReceive()
        {
            sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, this.VPort);

            sc.Bind(ie);

            sc.Listen(0);
            sock = sc.Accept();
            ns = new NetworkStream(sock);


            //WriteBytes();
            sc.Close();

            while (true)
            {
                VoiceReceive();
            }
        }
        //not used here but its useful to get the length of wav file
        public static TimeSpan GetSoundLength(string fileName)
        {

            WaveFileReader wf = new WaveFileReader(fileName);
            return wf.TotalTime;

        }

        private void WriteBytes()
        {
            if (ns != null)
            {
                SoundPlayer sp = new SoundPlayer(ns);
                sp.Play();
            }
        }


        private void Dispose()
        {
            c_v.Stop();
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
            }
            if (waveWriter != null)
            {
                waveWriter.Dispose();

            }
            GC.SuppressFinalize(this);
        }


    }
}
