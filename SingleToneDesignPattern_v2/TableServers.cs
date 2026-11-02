using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDesignPattern_v2
{
    internal class TableServers
    {

        private static readonly TableServers _instance = new TableServers();
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        //public TableServers()
        //{
        //    servers.Add("Tim");
        //    servers.Add("Sue");
        //    servers.Add("Marry");
        //    servers.Add("Mayur");
        //}

        private TableServers()
        {
            servers.Add("Tim");
            servers.Add("Sue");
            servers.Add("Marry");
            servers.Add("Mayur");
        }


        public static TableServers GetTableServers()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer += 1;

            if(nextServer >= servers.Count)
            {
                nextServer = 0;
            }

            return output;
        }
    }
}
