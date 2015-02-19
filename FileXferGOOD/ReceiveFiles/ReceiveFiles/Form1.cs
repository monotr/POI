using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace ReceiveFiles
{
    public partial class Form1 : Form
    {
        private const int BufferSize = 1024;
        public string Status = string.Empty;
        public Thread T = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Server is Running...";
            ThreadStart Ts = new ThreadStart(StartReceiving);
            T = new Thread(Ts);
            T.Start();

           
        }
        public void StartReceiving()
        {
            ReceiveTCP(2014, "C:\\Users\\Monotr_\\Google Drive\\caquita.jpeg");
        }


        public void ReceiveTCP(int portN, string FileName)
        {
            TcpListener Listener = null;
            try
            {
                Listener = new TcpListener(IPAddress.Any, portN);
                Listener.Start();
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message.ToString();
                Console.WriteLine(ex.Message);
            }

            byte[] RecData = new byte[1024];
            int RecBytes;

            for (; ; )
            {
                TcpClient client = null;
                NetworkStream netstream = null;
                try
                {

                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        netstream = client.GetStream();

                        if (FileName != string.Empty)
                        {
                            int totalrecbytes = 0;
                            FileStream Fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                            while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
                            {
                                Fs.Write(RecData, 0, RecBytes);
                                totalrecbytes += RecBytes;
                            }
                            Fs.Close();
                            label2.Text = "fin de escritura";
                        }
                        netstream.Close();
                        client.Close();

                    }
                }
                catch (Exception ex)
                {
                    label2.Text = ex.Message.ToString();
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            T.Abort();
            this.Close();
        }

        
    }
}