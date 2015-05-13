﻿using System;
using System.Collections.Generic;
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

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        private int port;
        public Thread rec_thread;
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

        public void Send(int port)
        {
            serverIPAddress = IPAddress.Parse("192.168.1.124");
            /*IPAddress[] localIP = Dns.GetHostAddresses("USER");
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    serverIPAddress = address;
                }
            }*/

            this.VPort = port;

            c_v = new System.Windows.Forms.Timer();
            c_v.Interval = 500;
            c_v.Enabled = false;
            c_v.Tick += c_v_Tick;
            Recordwav();
        }

        private void Recordwav()
        {
            sourceStream = new WaveIn();
            int devicenum = 0;

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                if (NAudio.Wave.WaveIn.GetCapabilities(i).ProductName.Contains("icrophone"))
                    devicenum = i;
            }
            sourceStream.DeviceNumber = devicenum;
            sourceStream.WaveFormat = new WaveFormat(22000, WaveIn.GetCapabilities(devicenum).Channels);
            sourceStream.DataAvailable += new EventHandler<WaveInEventArgs>(sourceStream_DataAvailable);
            try
            {
                waveWriter = new WaveFileWriter(path, sourceStream.WaveFormat);
            }
            catch { }
            sourceStream.StartRecording();
            
            c_v.Start();

        }


        void c_v_Tick(object sender, EventArgs e)
        {
            this.Dispose();
            Send_Bytes();

        }

        private void Send_Bytes()
        {
            Data_ary = File.ReadAllBytes(path);
            try
            {
                UdpClient udpClient = new UdpClient();
                udpClient.Client.SendBufferSize = 1024 * 1024 * 10;
                udpClient.Connect(IPAddress.Parse("192.168.1.124"), 2000);
                udpClient.Send(Data_ary, Data_ary.Length);
                udpClient.Close(); // no estaba
            }
            catch { }
            Recordwav();
        }

        
        private void sourceStream_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);

            waveWriter.Flush();

        }

        //not used here but its useful to get the length of wav file
        public static TimeSpan GetSoundLength(string fileName)
        {

            WaveFileReader wf = new WaveFileReader(fileName);
            return wf.TotalTime;

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
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(serverIPAddress, 0);
            while (true)
            {
                try
                {
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    udpClient.Close();
                    if (receiveBytes != null)
                        WriteBytes(receiveBytes);
                }
                catch { }
            }
        }

        private void WriteBytes(Byte[] sound)
        {
            using (MemoryStream ms = new MemoryStream(sound))
            {
                // Construct the sound player
                SoundPlayer player = new SoundPlayer(ms);
                player.Play();
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
