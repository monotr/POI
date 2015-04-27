using System;
using System.Collections.Generic;
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
        Thread thdUDPServer;//, thdUDPAudioServer;
        UdpClient udpClient;//, udpAudioClient;
        
        Voice v = new Voice();
        
        int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();

            v.Receive(2000);
        }

        public void serverThread() {
            udpClient = new UdpClient(8080);
            udpClient.Client.ReceiveBufferSize = 1024*1024;
            while(true) {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

                Image Imagen = byteArrayToImage(receiveBytes);
                videoReceived.Image = Imagen;
                //num++;
                //string returnData = Encoding.ASCII.GetString(receiveBytes);
                //conectionsList.Items.Add(num + " / " + RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString());
            }
        }

        public Image byteArrayToImage(Byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thdUDPServer.Abort();
            udpClient.Close();
        }
    }
}
