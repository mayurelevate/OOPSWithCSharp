using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal.DIP
{
    internal class MongoDatabase : IDatabase
    {
        public void SaveData(string data)
        {
            Console.WriteLine($"(MongoDB) Saving data to MongoDB : {data}");
        }
    }
}
