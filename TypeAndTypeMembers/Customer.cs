using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndTypeMembers
{
   public class Customer
    {
        #region Private Fields
        private int _id;
        private string _firstName;
        private string _lastName;
        #endregion


        public int ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

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

        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }


    }
}
