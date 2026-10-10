using System;

namespace HackersPracticeAlgoDAS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 4, 5, 6 };
            int miss = getMissingNo(a, 5);
            Console.Write(miss);
        }

        // Function to ind missing number
        static int getMissingNo(int[] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;

            for (int i = 0; i < n; i++)
                total -= a[i];

            return total;
        }

        private static void VeryBigSum()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string[] arrayone = Console.ReadLine().Split(' ');
            double sum = 0;

            for (int i = 0; i < num; i++)
            {
                sum += Convert.ToInt32(arrayone[i]);
            }

            Console.WriteLine(sum);
        }



        private static void SumOfNumber()
        {
            int length = Convert.ToInt32(Console.ReadLine());

            if (length > 0)
            {
                int result = 0;
                string[] num = Console.ReadLine().Split(' ');


                for (int i = 0; i < length; i++)
                {
                    result = result + Convert.ToInt32(num[i]);
                }

                Console.WriteLine(result);

            }
        }

        private static void Triplate()
        {
            string[] arrayOne = Console.ReadLine().Split(' ');
            string[] arrayTwo = Console.ReadLine().Split(' ');

            int arrayOneLength = arrayOne.Length;
            int arrayTwoLength = arrayTwo.Length;

            if (arrayOneLength == arrayTwoLength)
            {
                int x = 0, y = 0;

                for (int i = 0; i < arrayOneLength; i++)
                {

                    if (Convert.ToInt32(arrayOne[i]) > Convert.ToInt32(arrayTwo[i]))
                    {
                        x++;
                    }
                    else if (Convert.ToInt32(arrayOne[i]) < Convert.ToInt32(arrayTwo[i]))
                    {
                        y++;
                    }
                }

                Console.WriteLine(x + " " + y);
            }
        }
    }
}
