using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Exchanger
{
    //non static
    public class ExchangeMonitor
    {
        public int counterTotalExchanged;
        public int AddExchanged()
        {
            return ++counterTotalExchanged;
        }
    }
}
