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
        public static Hashtable statusList = new Hashtable();
        public static Hashtable ipList = new Hashtable();
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

            TcpListener serverSocket = new TcpListener(myIP, 9050);
            TcpClient clientSocket = default(TcpClient);
            int counter = 0;

            serverSocket.Start();
            Console.WriteLine(" >> " + "Server Started with IP= " + myIP.ToString() + " PORT= 9050");

            counter = 0;
            while (true)
            {
                //counter += 1;
                //Console.WriteLine(counter.ToString());
                clientSocket = serverSocket.AcceptTcpClient();

                byte[] bytesFrom = new byte[100025];
                byte[] bytesFromstatus = new byte[100025];
                string dataFromClient = null;
                string ipUser = null;
                string stateClient = null;

                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);          
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);

                string tempor = dataFromClient.Substring(1, dataFromClient.Length-1);
                string[] partess = tempor.Split('|');

                Console.WriteLine(partess[0] + " Joined chat room \n");
                handleClinet client = new handleClinet();
                client.startClient(clientSocket, partess[0], clientsList);


                string tipo = dataFromClient.Substring(0, 1);
                if (tipo == "$")
                {
                    string temp = dataFromClient.Substring(1, dataFromClient.Length - 1);
                    string[] partes = temp.Split('|');
                    stateClient = partes[1];
                    ipUser = partes[2];
                    dataFromClient = partes[0];
                    clientsList.Add(dataFromClient, clientSocket);
                    statusList.Add(dataFromClient, stateClient);
                    ipList.Add(dataFromClient, ipUser);
                }
                broadcast(dataFromClient + " ^Joined+" + stateClient + "-" + ipUser + "|NADA", dataFromClient, false, 0);

                updateGrids(dataFromClient);
                //statusfromclient = statusfromclient.Substring(0, statusfromclient.IndexOf("$"));
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine(" >> " + "exit");
            Console.ReadLine();
        }

        public static void updateGrids(string dataFromClient)
        {
            string todosCLientes = "";

            foreach (DictionaryEntry item in clientsList)
                todosCLientes += item.Key.ToString() + "," + statusList[item.Key.ToString()] + "," + ipList[item.Key.ToString()] + ",";

            string[] parts = todosCLientes.Split(',');

            broadcast(todosCLientes, dataFromClient, false, 2);
        }

        public static void changeStado(string user, string stado)
        {
            statusList[user] = stado;
        }

        public static void broadcast(string msg, string uName, bool flag, int tipoMsg)
        {
            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;

                if (flag == true)
                {
                    if (tipoMsg == 0)
                        broadcastBytes = Encoding.ASCII.GetBytes(uName + " says: " + msg);
                    else if (tipoMsg == 1)
                        broadcastBytes = Encoding.ASCII.GetBytes(uName + "- ha cambiado su estado a: " + msg + "%");
                }
                else
                {
                    if (tipoMsg != 2)
                        broadcastBytes = Encoding.ASCII.GetBytes(msg);
                    else
                        broadcastBytes = Encoding.ASCII.GetBytes("#" + msg + "]");
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
                    if (a > 0 && b < 0)
                    {
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        Console.WriteLine("From client - " + clNo + " : " + dataFromClient);
                        Program.broadcast(dataFromClient, clNo, true, 0);
                    }

                    else if (b > 0 && dataFromClient.Contains("estado"))
                    {
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("&"));

                        Program.changeStado(clNo, dataFromClient);
                        Program.updateGrids(clNo);

                        Console.WriteLine(clNo + "- cambió su estado a  : " + dataFromClient + "%");
                        Program.broadcast(dataFromClient, clNo, true, 1);
                    }
                    else if (dataFromClient.Contains("zoombido"))
                    {
                        Console.WriteLine(clNo + " envió zoombido~");
                        Program.broadcast("~", clNo, false, 1);
                    }
                    else if (dataFromClient.Contains("¿"))
                    {
                        Console.WriteLine(clNo + " quiere iniciar chat privado");
                        Program.broadcast(dataFromClient, clNo, false, 1);
                    }
                    
                    rCount = Convert.ToString(requestCount);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(" >> " + ex.ToString());
                }
            }
        }
    } 
}
