using System;

namespace CodeChef
{
    class clsProgram
    {
        //int loopcount = Int32.Parse(Console.ReadLine());
        //for (int i = 0; i < loopcount; i++)
        //{
        //    int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(), Int32.Parse);
        //    Console.WriteLine(input[0] + input[1]);
        //}


        //Console.ReadLine()



        //int num = Int32.Parse(Console.ReadLine());
        //Console.WriteLine(num);
        //Console.ReadLine();



        //string[] input = Console.ReadLine().Split();
        //int n = Convert.ToInt32(input[0]);
        //int k = Convert.ToInt32(input[1]);

        //int result = 0;
        //int inputNumber = 0;
        //for (int index = 1; index <= n; index++)
        //{
        //    inputNumber = Convert.ToInt32(Console.ReadLine());
        //    if (inputNumber % k == 0) 
        //        result++;
        //}


        //Console.WriteLine(result);
        //Console.ReadLine();


        public void arraysort()
        {

             //TODO
            string[] loopCount = Console.ReadLine().Trim().Split();

            int loopcount = Convert.ToInt32(loopCount[0]);

            int[] array = new int[loopcount];

            for (int i = 0; i < loopcount; i++)
            {

                array[i] = int.Parse(Console.ReadLine().Trim());
            }

            

            Array.Sort(array);

            foreach (var v in array)
            {
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }

        public void number4 ()
        {
            string loopcount = Console.ReadLine().Trim();

            int length = Convert.ToInt32(loopcount);
            int LastNum = 0;

            for (int i = 0; i < length; i++)
            {
                long n = Convert.ToInt64(Console.ReadLine());

                int count = 0;

                while (n != 0)
                {
                    if (n % 10 == 4)
                        count++;

                    n = n / 10;
                }

                Console.WriteLine(count);
            }
        }

        public void NumberReverse()
        {
            string[] count = Console.ReadLine().Trim().Split();

            int loopcount = Convert.ToInt32(count[0]);

            for (int i = 0; i < loopcount; i++)
            {

                int rev = 0;
                int rem = 0;
                int number = Convert.ToInt32(Console.ReadLine().Trim());


                while (number != 0)
                {
                    rem = number % 10;

                    rev = rev * 10 + rem;

                    number = number / 10;
                }

                Console.WriteLine(rev);

            }
        }






    }
}
