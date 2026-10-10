namespace ThreadDemoNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DisplayMessageOne);

            //Thread t1 = new Thread(() => DisplayMessageOne(10));

            Thread t2 = new Thread(DisplayMessageTwo);
            Thread t3 = new Thread(DisplayMessageThree);

            t1.Start();
            t1.IsBackground = true;
            
            t2.Start();
            t3.Start();
            t3.Priority = ThreadPriority.Highest;
            
            t1.Join();
            t2.Join();
            t3.Join();

            Console.Read();
        }


        private static readonly object LockDisplayMethod = new object();

        static void DisplayMessageOne()
        {
            lock (LockDisplayMethod)
            {
               // Console.Write($"Methd One Value : {i}");
                Console.Write("[Welcomen to the ");
                Console.WriteLine("world of dontnet! DisplayMethodOne]");
            }
        }

        static void DisplayMessageTwo()
        {
            lock (LockDisplayMethod)
            {
                Console.Write("[Welcomen to the ");
                Console.WriteLine("world of dontnet! DisplayMethodTwo]");
            }
        }


        static void DisplayMessageThree()
        {
            lock (LockDisplayMethod)
            {
                Console.Write("[Welcomen to the ");
                //Thread.Sleep(1000);
                Console.WriteLine("world of dontnet! DisplayMethodThree]");
            }
        }

        static void CalculateValues(int i)
        {
            for(int x=0; x < 1;x++)
            {
                Console.Write($"Loop Count : {x}");
            }
        }
    }
}