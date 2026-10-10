using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starPattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryNumberTrianglePattern();
        }


        public static void BinaryNumberTrianglePattern()
        {
            int n = 6;
            int start = 1;

            for (int i = 1; i < n; i++)
            {
                if(i%2==0)
                {
                    start = 1;
                }
                else
                {
                    start = 0;
                }

                for (int j=0; j<=i;j++)
                {
                    Console.Write(start);
                    start = 1 - start;
                }
                Console.WriteLine();
            }
        }

        public static void StarPatter1(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public  static void StarPattern2_version1()
        {
            int i = 1;
            int n = 5;

            while (i <= n)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                i++;
            }
        }

        public static void StarPattern2_version2()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }

        public static void starPattern3_version3()
        {
            int x = 6;

            for (int i = x; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }


        public static void numberPatter1()
        {
            int N = 5;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
        }

        public static void numberPatter2()
        {
            int N = 5;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}");
                }

                Console.WriteLine();
            }
        }

        public static void numberPattern3()
        {
            int N = 5;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }
        }


        public static void numberpattern4()
        {
            int x = 6;

            for (int i = x; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }

                Console.WriteLine();
            }
        }


        public static void startPatternPyramid1()
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }


                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }


        public static void startPatternPyramid2()
        {
            int N = 5;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * N - (2 * i + 1); j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        public static void DiamondShapeStarPattern()
        {
            startPatternPyramid1();
            startPatternPyramid2();
        }


        public static void HalfDiamondStarPattern()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 5; i > 1; i--)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        
    }
}
