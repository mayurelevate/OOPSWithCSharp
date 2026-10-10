using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnDataUsingThread
{

    public delegate void ResultCallbackDelegate(int Results);

    internal class NumberHelper
    {
        private int _Number;
        private ResultCallbackDelegate _resultCallbaclDelegates;

        public NumberHelper(int Number, ResultCallbackDelegate resultCallbackDelegate)
        {
            _Number = Number;
            _resultCallbaclDelegates = resultCallbackDelegate;
        }


        public void CalculateSum()
        {
            int Result = 0;

            for(int i=1;i <=_Number;i++)
            {
                Result = Result + 1;
            }


            if(_resultCallbaclDelegates !=null)
            {
                _resultCallbaclDelegates(Result);
            }
        }
    }
}
