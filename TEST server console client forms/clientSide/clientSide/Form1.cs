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

namespace clientSide
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msg("Client Started");
            clientSocket.Connect("192.168.1.87", 2014);
            label1.Text = "Client Socket Program - Server Connected ...";
        }

        public void msg(string mesg)
        {
            textBox1.Text = textBox1.Text + Environment.NewLine + " >> " + mesg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Message from Client$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] inStream = new byte[100025];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            msg("Data from Server : " + returndata);
        } 
    }
}
