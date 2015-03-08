﻿using System;
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
        string status = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Emojis.createicons();
          
            comboEstado.Items.Add("Disponible");
            comboEstado.Items.Add("Ausente");
            comboEstado.Items.Add("Ocupado");
            
            
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


                    returndata = returndata.Substring(inicio, fin);
                    returndata = CryptoEngine.Decrypt(returndata, true);


                    readData = "" + returndata;
                    msg();
                }

                else if(returndata.Contains("estado"))
                {
                   
                }

                
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
            clientSocket.Connect("192.168.1.242", 2014);
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

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(comboEstado.Text + "&");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            
        }

        private void comboEstado_ValueMemberChanged(object sender, EventArgs e)
        {
            
        } 
    }
}
