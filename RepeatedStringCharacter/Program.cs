using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RepeatedStringCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] alphabets = { "a", "b", "c", "a", "b" ,"z","x","p","q","z","x", "a", "b" , "a", "b" };

            int lenght_of_array = alphabets.Length;

           

            for (int i = 0; i < lenght_of_array-1; i++)
            {
                //string first_value  =alphabets[i];

                bool isrepeated = false;

                for (int j = i+1; j < lenght_of_array -1; j++)
                {
                    if (alphabets[i] == alphabets[j] && alphabets[i+1] == alphabets[j+1])
                    {
                        isrepeated = true;
                        break;

                    }
                }


                if(isrepeated)
                {

                    bool is_printed = false;
                    for(int p=0; p < i; p++)
                    {
                        if (alphabets[i] == alphabets[p] && alphabets[i + 1] == alphabets[p + 1])
                        {
                            is_printed = true;
                            break;

                        }
                    }

                    if(!is_printed)
                    {
                        Console.WriteLine($"{alphabets[i]}  {alphabets[i + 1]}");
                    }
                }
            }
        }
    }
}
