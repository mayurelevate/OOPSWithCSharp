using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePrivate
{
   public class User
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }

            set { _Id = value; }
        }

        private string Name { get; set; }

        protected  string FirstName { get; set; }

    }
}
