using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ServerClient
{
    public partial class Form1 : Form
    {
        
            private TcpClient client;
            public StreamReader STR;
            public StreamWriter STW; 
            public string  receive;
            public String text_to_send;
            string clearText;
        public Form1()
        {

    
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress address in localIP)
            { if (address.AddressFamily == AddressFamily.InterNetwork)
                 {
                     txtIP.Text = address.ToString();

                 }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtPort.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync(); // Start receiving data
            backgroundWorker2.WorkerSupportsCancellation = true;  // Ability to cancel this thread
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) // send Data
        {
            if(client.Connected)
            {
                STW.WriteLine(text_to_send);
                this.textBox2.Invoke(new MethodInvoker(delegate() { textBox2.AppendText("Me: " + clearText + "\n"); }));
            }
            else
            {

                MessageBox.Show("Send failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)  // Receive Data
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    string decryptedText = CryptoEngine.Decrypt(receive, true);
                    this.textBox2.Invoke(new MethodInvoker(delegate() { textBox2.AppendText("You: " + decryptedText + "\n"); }));
                    receive = "";
                    }
                catch(Exception x)
                {
                    MessageBox.Show(x.Message.ToString());

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(txtIp2.Text), int.Parse(txtPort2.Text));
            try{

                client.Connect(IP_End);
                if(client.Connected)
                {
                    textBox2.AppendText("Connected to Server " + "\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync(); // Start receiving data
                    backgroundWorker2.WorkerSupportsCancellation = true;  // Ability to cancel this thread

                }
            
            }

            catch(Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                //error.Clear();
                clearText = textBox1.Text.Trim();
                text_to_send = CryptoEngine.Encrypt(clearText, true);
                //text_to_send = textBox1.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            textBox1.Text = "";
        }
    }
}
