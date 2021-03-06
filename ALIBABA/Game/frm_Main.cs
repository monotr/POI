﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Game
{
    /// <summary>
    /// Copy Right Học Lập Trình
    /// Page: fb.com/hoclaptrinh.it
    /// websites: www.studycoding.net
    /// </summary>
    public partial class frm_Main : Form
    {
        bool myMsg = false;
        bool firstMsg = false;
        string readData = null;

        List<string> lista = new List <string>();

        private  Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public frm_Main()
        {
            InitializeComponent();
        }
        byte[] receivedBuf = new byte[1024];
        Thread thr;
        private void Form1_Load(object sender, EventArgs e)
        {
            Emojis.createicons();  
        }

        private void ReceiveData(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            int received = socket.EndReceive(ar);
            byte[] dataBuf = new byte[received];

            if (firstMsg)
            {
                //if (!myMsg)
                //{
                    Array.Copy(receivedBuf, dataBuf, received);
                    //rb_chat.Text += "\n" + (Encoding.ASCII.GetString(dataBuf));
                    //lb_stt.Text = (Encoding.ASCII.GetString(dataBuf));

                    //desencrypt
                    string receivedEnc = (Encoding.ASCII.GetString(dataBuf));
                    int inicio = receivedEnc.IndexOf(":") + 1;
                    int fin = receivedEnc.IndexOf("*") - inicio;
                    receivedEnc = receivedEnc.Substring(inicio, fin);
                    receivedEnc = CryptoEngine.Decrypt(receivedEnc, true);

                    rb_chat.AppendText("\nServer:" + receivedEnc);
                    readData = "" + receivedEnc;
                    msg();
                    _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);

                    
                    
                //}
                //else
                //    myMsg = false;
            }
            else
            {
                firstMsg = true;
                lista.Add(Encoding.ASCII.GetString(dataBuf));
                //rb_chat.AppendText((Encoding.ASCII.GetString(dataBuf)));
                
            }
        }


        private void msg()
        {
           
           
            
                //conversation.AppendText(conversation.Text + Environment.NewLine + " >> " + readData);
                Emojis.pegaricono(readData, rb_chat);
            
        } 

        private  void SendLoop()
        {
            while (true)
            {
                //Console.WriteLine("Enter a request: ");
                //string req = Console.ReadLine();
                //byte[] buffer = Encoding.ASCII.GetBytes(req);
                //_clientSocket.Send(buffer);

                byte[] receivedBuf = new byte[1024];
                int rev = _clientSocket.Receive(receivedBuf);
                if (rev != 0)
                {
                    byte[] data = new byte[rev];
                    Array.Copy(receivedBuf, data, rev);
                    lb_stt.Text = ("Received:" + Encoding.ASCII.GetString(data));
                    rb_chat.AppendText("\nServer:" + Encoding.ASCII.GetString(data));
                }
                else _clientSocket.Close();
                
            }
        }

        private  void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException)
                {
                    //Console.Clear();
                    lb_stt.Text = ("Connection attempts: " + attempts.ToString());
                }
            }
            lb_stt.Text = ("Connected!");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_clientSocket.Connected)
            {
                myMsg = true;

                //encrypt
                string text_to_send = CryptoEngine.Encrypt(txt_text.Text, true);
                text_to_send += "*";
                //
                byte[] buffer = Encoding.ASCII.GetBytes(txName.Text + ":" + text_to_send + "$");
                _clientSocket.Send(buffer);
                rb_chat.AppendText("\nClient:" + txt_text.Text);
                txt_text.Text = "";
            }
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoopConnect();
            // SendLoop();
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
            byte[] buffer = Encoding.ASCII.GetBytes("@@" + txName.Text);
            _clientSocket.Send(buffer);
           
        }
    }
}
