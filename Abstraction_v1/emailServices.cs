using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_v1
{
    internal class emailServices
    {
        public void sendEmail()
        {
            connect();
            authenticate();
            Console.WriteLine("Send Email");
            disconnect();
        }

        private void connect()
        {
            Console.WriteLine("Connection to Email Server");
        }

        private void authenticate()
        {
            Console.WriteLine("Authenticating the request");
        }

        private void disconnect()
        {
            Console.WriteLine("Disconnect the connection");
        }
    }
}
