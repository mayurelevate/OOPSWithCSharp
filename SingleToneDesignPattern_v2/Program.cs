using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace SingleToneDesignPattern_v2
{
    internal class Program
    {

        static TableServers host1List =TableServers.GetTableServers();
        static TableServers host2List =TableServers.GetTableServers();
        static void Main(string[] args)
        {
           TableServers servers =TableServers.GetTableServers();

            for(int i=0; i< 5;i++)
            {
                //Console.WriteLine("The next Server is : " + servers.GetNextServer());
                Host1GetNextServer();
                Host2GetNextServer();
            }

            Console.ReadLine();
        }


        private static void Host1GetNextServer()
        {
            Console.WriteLine("The next Server (Host-1 List) is : " + host1List.GetNextServer());
        }

        private static void Host2GetNextServer()
        {
            Console.WriteLine("The next Server (Host-2 List) is : " + host2List.GetNextServer());
        }
    }
}
