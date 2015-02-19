using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;

namespace Data_Xfer_server
{
    public partial class Form1 : Form
    {
        private ArrayList nSockets;
        private IPAddress ipThis;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPHostEntry IPHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ipa in IPHost.AddressList)
            {
                if (ipa.AddressFamily.ToString() == "InterNetwork") {
                    lblStatus.Text = "My IP address is " + ipa.ToString();
                    ipThis = ipa;
                }
            }
            
            nSockets = new ArrayList();
            Thread thdListener = new Thread(new ThreadStart(listenerThread));
            thdListener.Start();
        }

        public void listenerThread() {
            TcpListener tcpListener = new TcpListener(ipThis, 8080);
            tcpListener.Start();
            while(true) {
                Socket handlerSocket = tcpListener.AcceptSocket();
                if (handlerSocket.Connected) {
                    lbConnections.Items.Add( handlerSocket.RemoteEndPoint.ToString() + " connected." );
                    lock (this) {
                        nSockets.Add(handlerSocket);
                    } ThreadStart thdstHandler = new ThreadStart(handlerThread);
                    Thread thdHandler = new Thread(thdstHandler);
                    thdHandler.Start();
                }
            }
        }

        public void handlerThread() {
            Socket handlerSocket = (Socket)nSockets[nSockets.Count-1];
            NetworkStream networkStream = new NetworkStream(handlerSocket);
            int thisRead=0;
            int blockSize=1024;
            Byte[] dataByte = new Byte[blockSize];
            lock(this) {
                // Only one process can access
                // the same file at any given time


                Stream fileStream = File.OpenWrite("C:\\tcpimage.jpg");
                while(true) {
                    thisRead=networkStream.Read(dataByte,0,blockSize);
                    fileStream.Write(dataByte,0,thisRead);
                    if (thisRead==0) break;
                } fileStream.Close();
            }
            lbConnections.Items.Add("File Written");
            handlerSocket = null;
        }
    }
}
