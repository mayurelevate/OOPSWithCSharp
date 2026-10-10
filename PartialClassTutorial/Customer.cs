using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassTutorial.Properties
{
  public class Customer
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string GetFullName ()
        {
            return _firstName + ", " + _lastName;
        }

    }
}
