using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal.DIP
{
    internal interface IDatabase
    {
        void SaveData(string data);
    }
}
