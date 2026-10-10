using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal.DIP
{
    internal class DataProcessor
    {
        private readonly IDatabase _database;

        public DataProcessor(IDatabase database)
        {
            _database = database;
        }

        public void Process(string data)
        {
            Console.WriteLine("Processing Data");
            _database.SaveData(data);
        }
    }
}
