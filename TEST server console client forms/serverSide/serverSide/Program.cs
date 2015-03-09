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
        public static Hashtable statusList= new Hashtable(); 

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
                counter += 1;
                clientSocket = serverSocket.AcceptTcpClient();

                byte[] bytesFrom = new byte[100025];
                byte[] bytesFromstatus = new byte[100025];
                string dataFromClient = null;
                string stateClient = null;

                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);          
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);

                stateClient = dataFromClient.Substring(dataFromClient.IndexOf("$")+1, dataFromClient.IndexOf("{") - 1);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$") - 1);
                
                clientsList.Add(dataFromClient, clientSocket);
                statusList.Add(dataFromClient, stateClient);

                // manda los clientes antiguos al nuevo cliente 
                broadcast(dataFromClient + " ^Joined{" + stateClient + "}", dataFromClient, false, 0);
                foreach (DictionaryEntry Item in clientsList)
                {
                    //if(Item.Key.ToString() != dataFromClient){
                        broadcast(statusList[Item.Key].ToString(),Item.Key.ToString(), true , 2);
                   //}
                    
                }
                
                Console.WriteLine(dataFromClient + " Joined chat room \n");
                handleClinet client = new handleClinet();
                client.startClient(clientSocket, dataFromClient, clientsList, statusList);
                //statusfromclient = statusfromclient.Substring(0, statusfromclient.IndexOf("$"));
                
            }

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine(" >> " + "exit");
            Console.ReadLine();
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
                    if(tipoMsg == 0)
                        broadcastBytes = Encoding.ASCII.GetBytes(uName + "[ says: " + msg);
                    else if (tipoMsg == 1)
                        broadcastBytes = Encoding.ASCII.GetBytes(uName + "| ha cambiado su estado a: )" + msg + "%");
                    else if (tipoMsg == 2 )
                        broadcastBytes = Encoding.ASCII.GetBytes(uName + "#" + msg + ";");
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
        Hashtable statusList;
        public void startClient(TcpClient inClientSocket, string clineNo, Hashtable cList, Hashtable sList)
        {
            this.clientSocket = inClientSocket;
            this.clNo = clineNo;
            this.clientsList = cList;
            this.statusList = sList;
            
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
                        Console.WriteLine(clNo + " cambió su estado a  : " + dataFromClient);
                        Program.broadcast(dataFromClient, clNo, true, 1);
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
