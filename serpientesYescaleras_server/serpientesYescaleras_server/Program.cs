﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace serpientesYescaleras_server
{
    class Program
    {
        static UdpClient udpClientSyE, udpClientCP;
        private static List<string> jugadores, clientList;
        private static List<string> listCP, nicknames;

        static Thread thdReceive, thdReceiveCP;

        static void Main(string[] args)
        {
            clientList = new List<string>();
            jugadores = new List<string>();
            listCP = new List<string>();
            nicknames = new List<string>();

            thdReceive = new Thread(new ThreadStart(receiveThreadSYE));
            thdReceive.Start();

            thdReceiveCP = new Thread(new ThreadStart(receiveThreadCP));
            thdReceiveCP.Start();
        }

        private static void sendThread(string action, IPAddress playerIP)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(action);
            try
            {
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(playerIP, 5420);
                udpClient.Send(outStream, outStream.Length);
            }
            catch { }
        }

        public static void receiveThreadSYE()
        {
            udpClientSyE = new UdpClient(5420);

            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClientSyE.Receive(ref RemoteIpEndPoint);
                string returndata = System.Text.Encoding.ASCII.GetString(receiveBytes);

                if (returndata.Contains('$'))
                {
                    IPAddress ipAux = RemoteIpEndPoint.Address;
                    if (clientList.Contains(ipAux.ToString()) && clientList.Count < 3)
                    {
                        clientList.Add(ipAux.ToString());
                        string name = returndata.Substring(1, returndata.Length - 1);
                        jugadores.Add(name);

                        Console.WriteLine("Player - " + name + " joined with IP : " + ipAux);

                        sendThread("|", ipAux);
                        for (int i=0; i<jugadores.Count; i++)
                        {
                            sendThread("&Player " + (i+1).ToString() + ": " + jugadores[i], ipAux);
                        }

                        if (clientList.Count == 3)
                        {
                            sendThread("/", IPAddress.Parse(clientList[0]));
                        }
                    }
                }
                else if (returndata.Contains('%'))
                {
                    string dice = returndata.Substring(1,1);
                    for (int i = 0; i < jugadores.Count; i++)
                    {
                        sendThread("$" + dice, IPAddress.Parse(clientList[i]));
                    }
                }
                else if (returndata.Contains('!'))
                {
                    int turn = Convert.ToInt32(returndata.Substring(1, 1)) - 1;
                    for (int i = 0; i < jugadores.Count; i++)
                    {
                        if (turn != i)
                            sendThread("(", IPAddress.Parse(clientList[i]));
                        else
                            sendThread(")", IPAddress.Parse(clientList[i]));
                    }
                }
            }
        }


        public static void receiveThreadCP()
        {
            udpClientCP = new UdpClient(5421);

            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClientCP.Receive(ref RemoteIpEndPoint);
                string returndata = System.Text.Encoding.ASCII.GetString(receiveBytes);

                if (returndata.Substring(0, 1) == "$") // iniciar conversacion privada
                {
                    string[] parte = returndata.Split(',');
                    IPAddress ipAux = RemoteIpEndPoint.Address;
                    if (listCP.Contains(ipAux.ToString()) && listCP.Count < 2)
                    {
                        listCP.Add(parte[3]);
                     
                        nicknames.Add(parte[1]);
                        nicknames.Add(parte[2]);
                        listCP.Add(parte[4]);

                        //Console.WriteLine("Player - " + name1 + " joined with IP : " + ipAux);                               
                        sendThread("/" + nicknames[0] + "," + nicknames[1] + "," + listCP[0] + "," + listCP[1], IPAddress.Parse(listCP[0]));
                        sendThread("/" + nicknames[0] + "," + nicknames[1] + "," + listCP[0] + "," + listCP[1], IPAddress.Parse(listCP[1]));
                    }
                }
                else if (returndata.Substring(0, 1) == "%") // mensajes normales 
                {
                    string mensaje = returndata.Substring(0, 1);  // falta forma de obtenerlo
                    for (int i = 0; i < listCP.Count; i++)
                    {
                        if (RemoteIpEndPoint.Address.ToString() != listCP[i])
                            sendThread("$" + mensaje, IPAddress.Parse(listCP[i]));
                    }
                }
                else if (returndata.Substring(0, 1) == "!") // zumbidos
                {
                    for (int i = 0; i < listCP.Count; i++)
                    {
                        if (RemoteIpEndPoint.Address.ToString() != listCP[i])
                            sendThread("z", IPAddress.Parse(listCP[i]));
                    }
                }
                else if (returndata.Substring(0, 1) == "q") // cierra ventana
                {
                    for (int i = 0; i < listCP.Count; i++)
                    {
                        if (RemoteIpEndPoint.Address.ToString() != listCP[i])
                            sendThread("q", IPAddress.Parse(listCP[i]));
                    }
                }
            }
        }

    }
}