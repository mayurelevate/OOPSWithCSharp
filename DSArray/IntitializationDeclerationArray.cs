using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSArray
{
    internal class IntitializationDeclerationArray
    {
        public void IntArray()
        {

            int[] _studentRollNo = new int[5] { 1, 2, 3, 4, 5 };
            int[] _studentRollNo2 = {1,2,3,4,5};
            int[] _studentRollNo3 = new int[5];

            if(_studentRollNo.Length > 0)
            {
                for(int i=0;i<= _studentRollNo.Length-1; i++)
                {
                    Console.WriteLine(_studentRollNo[i]);
                }
            }
        }


        public void StudentArray()
        {
            string[] studentInfo = {"Mayur","Pam","John","Max","Dan"};

            if(studentInfo.Length >0)
            {
                for(int i=0; i<= studentInfo.Length -1; i++)
                {
                    Console.WriteLine(studentInfo[i]);
                }
                    
            }
        }
    }

    
}
