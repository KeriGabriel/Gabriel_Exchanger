using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabriel_Exchanger
{

    public static class Exchanger

    {
        //Variables
        public static string exchangeTo;
        public static string exchangeFrom;
        public static double exchangeAmount;
        public static double final;

        private static double USDto(double exchangeAmount, string exchangeTo)
        {  
            if (exchangeTo == "GPB")
            {
                final = exchangeAmount * 1.37887;
            }
            else if (exchangeTo == "CAN")
            {
                final = exchangeAmount * 0.79728;
            }
            else if (exchangeTo == "EUR")
            {
                final = exchangeAmount * 1.19648;
            }
            return final;
        }
        private static double GBPto(double exchangeAmount, string exchangeTo)
        {
            if (exchangeTo == "USD")
            {
                final = exchangeAmount * 0.72523;
            }
            else if (exchangeTo == "CAN")
            {
                final = exchangeAmount * 0.57848;
            }
            else if (exchangeTo == "EUR")
            {
                final = exchangeAmount * 0.86826;
            }
            return final;
        }
        private static double CANto(double exchangeAmount, string exchangeTo)
        {
            if (exchangeTo == "USD")
            {
                final = exchangeAmount * 1.25427;
            }
            else if (exchangeTo == "GBP")
            {
                final = exchangeAmount * 1.72947;
            }
            else if (exchangeTo == "EUR")
            {
                final = exchangeAmount * 1.50040;
            }
            return final;
        }
        private static double EURto(double exchangeAmount, string exchangeTo)
        {
            if (exchangeTo == "USD")
            {
                final = exchangeAmount * 0.83572;
            }
            else if (exchangeTo == "GBP")
            {
                final = exchangeAmount * 1.15195;
            }
            else if (exchangeTo == "CAN")
            {
                final = exchangeAmount * 0.66645;
            }
            return final;
        }
        public static double Final(double exchangeAmount, string exchangeTo, string exchangeFrom)
        {
            if (exchangeFrom == "USD")
            {
                USDto( exchangeAmount, exchangeTo);
            }
            else if (exchangeFrom == "GBP")
            {
                GBPto(exchangeAmount, exchangeTo);
            }
            else if (exchangeFrom == "CAN")
            {
                CANto(exchangeAmount, exchangeTo);
            }
            return final;
        }
    }
}

