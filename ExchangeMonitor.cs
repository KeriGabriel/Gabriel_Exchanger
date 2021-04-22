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
        public string exchangeTo;
        public int counterTotalExchanged = 0;
        public double usdFinal;
       
        public int AddExchanged(int counterTotalExchanged)
        {
            counterTotalExchanged++;
            return counterTotalExchanged;
        }
       
        public double CountUSD(string exchangeTo,double final, double usdFinal)
        {
            if (exchangeTo=="USD")
            {
                usdFinal = final + usdFinal;
                return usdFinal;
            }
            else { return usdFinal; }
          
        }
       
	
       

    }

}
