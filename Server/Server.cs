using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        Socket soket;
        public static List<NetworkStream> listaTokova = new List<NetworkStream>();
        public bool PokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 10000);
                soket.Bind(ep);

                ThreadStart ts = Osluskuj;
                new Thread(ts).Start();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ZaustaviServer()
        {
            if (listaTokova.Count != 0)
                return false;

            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Osluskuj()
        {
            try
            {
                soket.Listen(8);
                while (true)
                {
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    listaTokova.Add(tok);
                    new NitKlijenta(tok);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
