using System;


namespace Gabriel_Exchanger
{
    class Program
    {
        static void Main(string[] args)

        {
            int counterTotalExchanged = 0;
            double usdFinal=0;
            while (true) // allow the user to do another exchange if wanted
            {                
                Console.WriteLine("what is the amount of currency amount you want to convert? ");
                String exchangeAmount1 = Console.ReadLine();

                Console.WriteLine("what is the currency type you want to convert from? ");
                String exchangeFrom = Console.ReadLine().ToUpper();

                Console.WriteLine("what is the currency type you want to convert to? ");
                String exchangeTo = Console.ReadLine().ToUpper();

                double exchangeAmount = Convert.ToDouble(exchangeAmount1);

                //get exchange amount from exchanger class
                double final;               
                final = Exchanger.Final(exchangeAmount,exchangeTo,exchangeFrom);
              
                //add "C" to put into currency format
                Console.WriteLine(final.ToString("C"));

                //keep track of usd totals
                ExchangeMonitor monitor = new ExchangeMonitor();
                usdFinal = monitor.CountUSD(exchangeTo, final, usdFinal);
                
                while (true) // ask to make another exchange. or exit
                    {                    
                     ExchangeMonitor monitor2 = new ExchangeMonitor();
                    counterTotalExchanged = monitor2.AddExchanged(counterTotalExchanged);
                   
                    Console.WriteLine("Do you want to make another exchange? [Y/N]");
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                       
                    break; // Exit the inner while-loop and continue in the outer while loop.
                    if (answer == "N")
                        //exit program and give exchange totals from monitor class
                        Console.WriteLine("Total USD Exchanged: "  +usdFinal.ToString("C"));
                        Console.WriteLine("Number of exchanges done: " +counterTotalExchanged );
                    return; // Exit Main
                    }
            }
           

        }
    }
}
