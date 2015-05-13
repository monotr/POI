using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace UDP_Server
{
    using Sending_voice_Over_IP;
    public partial class Form1 : Form
    {
        public ArrayList clientList;
        Thread thdUDPServer;
        UdpClient udpClient;
        Voice v = new Voice();

        public Form1()
        {
            InitializeComponent();
            clientList = new ArrayList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();

            v.Receive(2000);
        }

        public void serverThread()
        {
            udpClient = new UdpClient(8080);
            udpClient.Client.ReceiveBufferSize = 1024 * 1024;
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

                //EndPoint epSender = (EndPoint)RemoteIpEndPoint;
                IPAddress ipAux = RemoteIpEndPoint.Address;
                if (!clientList.Contains(ipAux)) { 
                    clientList.Add(ipAux);
                    v.clientListV.Add(ipAux);
                }

                foreach (IPAddress addr in clientList)
                {
                    if (!addr.Equals(RemoteIpEndPoint.Address))
                    {
                        UdpClient udpOTHERClient = new UdpClient();
                        udpOTHERClient.Connect(addr, 8080);
                        udpOTHERClient.Send(receiveBytes, receiveBytes.Length);
                        //conectionsList.Invoke(new Action(() => conectionsList.Items.Clear()));
                        conectionsList.Invoke(new Action(() => conectionsList.Items.Add(addr.ToString() + " SENT TO " + RemoteIpEndPoint.Address.ToString())));
                    }
                    else
                        conectionsList.Invoke(new Action(() => conectionsList.Items.Add("caqui")));
                }


            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thdUDPServer.Abort();
            udpClient.Close();
        }
    }
}
