using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegates
{
    delegate void SampleDelegate();    
    class Program
    {
        static void Main(string[] args)
        {
            //SampleDelegate obj = new SampleDelegate(DelegateService.SampleMethod);
            //obj();

            SampleDelegate del1, del2, del3, del4;

            del1 = new SampleDelegate(DelegateService.SampleMethodOne);
            del2 = new SampleDelegate(DelegateService.SampleMethodTwo);
            del3 = new SampleDelegate(DelegateService.SampleMethodThree);

            del4 = del1 + del2 + del3  - del2;
            del4();
            Console.ReadLine();
        }
    }
}
