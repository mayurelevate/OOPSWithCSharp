using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal.DIP
{
    internal class SqlDatabase : IDatabase
    {
        public void SaveData(string data)
        {
            Console.WriteLine($" (SQL DB) Saving data to SQL : {data}");
        }
    }
}
