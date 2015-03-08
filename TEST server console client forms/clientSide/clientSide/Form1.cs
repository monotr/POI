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
using System.Threading;

namespace clientSide
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        bool first = false;
        string nombreCliente;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Emojis.createicons();
        }

        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[100025];
                buffSize = clientSocket.ReceiveBufferSize;
                serverStream.Read(inStream, 0, buffSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                if (first && !returndata.Contains("Joined"))
                {
                    int inicio = returndata.IndexOf(":") + 1;
                    int fin = returndata.IndexOf("*") - inicio;

                    nombreCliente = returndata.Substring(0, inicio-1);

                    returndata = returndata.Substring(inicio, fin);
                    returndata = CryptoEngine.Decrypt(returndata, true);
                }
                else if (!returndata.Contains("Joined"))
                {
                    readData = nombreCliente + ": " + returndata;
                }
                else
                {
                    readData = "" + returndata;
                }
                msg();
                int inicio2 = returndata.IndexOf("^") + 1;
                nombreCliente = returndata.Substring(0, inicio2 - 1);
                if (nombreCliente == nickname.Text+" ")
                    contactos_list.Items.Add("You");
                else
                    contactos_list.Items.Add(nombreCliente);
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
            {
                //conversation.AppendText(conversation.Text + Environment.NewLine + " >> " + readData);
                Emojis.pegaricono(readData, conversation);
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {

            string text_to_send = CryptoEngine.Encrypt(textToSend_txt.Text, true);

            text_to_send += "*";

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(text_to_send + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            textToSend_txt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readData = "Conected to Chat Server ... \n";
            clientSocket.Connect("192.168.1.87", 2014);
            //clientSocket.Connect("127.0.0.1", 2014);
            label1.Text = "Client Socket Program - Server Connected ...";

            msg();
            first = true;

            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(nickname.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }

        private void conversation_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nuevoEstado = comboBox1.Text.Substring(0,0);

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(nuevoEstado + "¢");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        } 
    }
}
