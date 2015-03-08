using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace serverSide
{
    class Program
    {
        public static Hashtable clientsList = new Hashtable(); 
        static void Main(string[] args)
        {
            IPAddress myIP = IPAddress.Parse("127.0.0.1");

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    myIP = address;
                }
            }

            TcpListener serverSocket = new TcpListener(myIP, 2014);
            TcpClient clientSocket = default(TcpClient);
            int counter = 0;

            serverSocket.Start();
            Console.WriteLine(" >> " + "Server Started with IP= " + myIP.ToString() + " PORT= 2014");

            counter = 0;
            while (true)
            {
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient();

                byte[] bytesFrom = new byte[100025];
                byte[] bytesFromstatus = new byte[100025];
                string dataFromClient = null;
                

                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);          
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                
                
                   
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    clientsList.Add(dataFromClient, clientSocket);


                    broadcast(dataFromClient + " Joined ", dataFromClient, false);
                    Console.WriteLine(dataFromClient + " Joined chat room \n");
                    handleClinet client = new handleClinet();
                    client.startClient(clientSocket, dataFromClient, clientsList);
               
                
                

                //statusfromclient = statusfromclient.Substring(0, statusfromclient.IndexOf("$"));
                
                

               
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine(" >> " + "exit");
            Console.ReadLine();
        }

        public static void broadcast(string msg, string uName, bool flag)
        {
            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;

                if (flag == true)
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(uName + " says : " + msg);
                }
                else
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(msg);
                }

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
        }  //end broadcast function
    }

    //Class to handle each client request separatly
    public class handleClinet
    {
        TcpClient clientSocket;
        string clNo;
        Hashtable clientsList;
        public void startClient(TcpClient inClientSocket, string clineNo, Hashtable cList)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            this.clientsList = cList;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }
        private void doChat()
        {
            int requestCount = 0;
            byte[] bytesFrom = new byte[100025];
            string dataFromClient = null;
            Byte[] sendBytes = null;
            string serverResponse = null;
            string rCount = null;
            requestCount = 0;

            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);

                    int a = dataFromClient.IndexOf("$");
                    int b = dataFromClient.IndexOf("&");
                    if (a > 0)
                    {
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        Console.WriteLine("From client - " + clNo + " : " + dataFromClient);
                    }

                    else if (b > 0)
                    {
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("&"));
                        Console.WriteLine(clNo + " cambió su estado a  : " + dataFromClient);

                    }
                    rCount = Convert.ToString(requestCount);

                    Program.broadcast(dataFromClient, clNo, true);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(" >> " + ex.ToString());
                }
            }
        }
    } 
}
