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
using System.Media.SoundPlayer;

namespace Sending_voice_Over_IP
{
    class Voice
    {
        public ArrayList clientListV;
        private string ip;
        private string path = Application.StartupPath + "\\buffer.wav";

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

        public IPAddress serverIPAddress;
        IPEndPoint RemoteIpEndPoint;


        private void Send_Bytes()
        {
            foreach (IPAddress addr in clientListV)
            {
                if (!addr.Equals(RemoteIpEndPoint.Address))
                {
                    UdpClient udpClient = new UdpClient();

                    udpClient.Connect(addr, 2000);
                    udpClient.Send(Data_ary, Data_ary.Length);
                    udpClient.Close(); // no estaba
                }
            }
        }

        public void Receive(int port)
        {
            this.VPort = port;
            rec_thread = new Thread(new ThreadStart(VoiceReceive));
            rec_thread.Start();
        }

        private void VoiceReceive()
        {
            UdpClient udpClient = new UdpClient(2000);
            RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {
                    Data_ary = udpClient.Receive(ref RemoteIpEndPoint);

                    if (Data_ary != null)
                        Send_Bytes();
                }
                catch { }
            }
        }
    }
}
