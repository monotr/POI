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
    public partial class Form1 : Form
    {
        int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        public void serverThread() {
            UdpClient udpClient = new UdpClient(8080);
            udpClient.Client.ReceiveBufferSize = 639988;
            while(true) {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

                Image Imagen = byteArrayToImage(receiveBytes);
                videoReceived.Image = Imagen;
                num++;
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                conectionsList.Items.Add(RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString() + " / " + num);
                
            }
        }

        public Image byteArrayToImage(Byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
    }
}
