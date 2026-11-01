using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Valid_Palindrome
{
    internal class Program
    {

//Input: s = "Was it a car or a cat I saw?"

//Output: true
        static void Main(string[] args)
        {

            string value = "Was it a car or a cat I saw? Mayur";

            bool response = checkValidPalindrome(value);

            if(response)
            {
                Console.WriteLine("Given String is Palindrom");
            }
            else
            {
                Console.WriteLine("Given String is not Palindrom");
            }
        }



        public static bool checkValidPalindrome(string value)
        {

            bool isPalindrome = true;

            string new_value = value.Replace(" ", "").ToLower();
            int len = new_value.Length-1;


            //string result = Regex.Replace(value, "@[^a-zA-Z0-9]", "");


            //for (int i = 0; i <= new_value.Length/2; i++)
            //{
            //    if (new_value[i] != new_value[len])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //    len--;
            //}

            int left = 0;
            int right = len;

            while(left < right)
            {

                if (!char.IsLetterOrDigit(new_value[left]))
                {
                    left++;
                    continue;
                }

                if (!char.IsLetterOrDigit(new_value[right]))
                {
                    right--;
                    continue;
                }


                if (char.ToLowerInvariant(new_value[left]) != char.ToLowerInvariant(new_value[right]))
                {
                    isPalindrome = false;
                }

                left++;
                right--;
            }




            return isPalindrome;
        }

    }
}
