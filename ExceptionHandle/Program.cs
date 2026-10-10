using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandle
{ 
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader objStreamReader = null;
            try
            {
                objStreamReader = new StreamReader(@"E:\Practise Project\testdaterelated\ExceptionHandle\Sample_text1\Data.txt");
                Console.WriteLine(objStreamReader.ReadToEnd());
                Console.ReadLine();                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} exists",ex.FileName);
                Console.WriteLine(ex.FileName);
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.InnerException);
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                //Console.ReadLine();
            }
            catch(Exception ex)
            {
                string filepath = @"E:\Practise Project\testdaterelated\ExceptionHandle\Sample_text\Log1.txt";
                StreamWriter sw = new StreamWriter(filepath);

                if(File.Exists(filepath))
                {
                    sw.Write(ex.GetType().Name);
                    sw.Write(ex.Message);
                    sw.Write(ex.StackTrace.ToString());
                    sw.Close();
                    Console.WriteLine(ex.Message);
                    //Console.ReadLine();
                }
                else
                {
                    throw new FileNotFoundException(filepath + "is not present",ex);
                }
            }
            finally
            {
                if(objStreamReader !=null)
                {
                    objStreamReader.Close();
                }
                Console.WriteLine("Final Block");
                Console.Read();
            }
        }
    }
}
