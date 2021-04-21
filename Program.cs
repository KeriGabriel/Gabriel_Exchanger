using System;

namespace Gabriel_Exchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // allow the user to do another exchange if wanted
            {
                //get and set 
                Console.WriteLine("what is the amount of currency amount you want to convert? ");
                String exchangeAmount1 = Console.ReadLine();

                Console.WriteLine("what is the currency type you want to convert from? ");
                String exchangeFrom = Console.ReadLine().ToUpper();

                Console.WriteLine("what is the currency type you want to convert to? ");
                String exchangeTo = Console.ReadLine().ToUpper();

                double exchangeAmount = Convert.ToDouble(exchangeAmount1);
                double final;
                final = Exchanger.Final(exchangeAmount, exchangeTo,exchangeFrom);
                Console.WriteLine(final.ToString("C"));

                while (true) // ask to make another exchange. or exit
                {
                    Console.WriteLine("Do you want to make another exchange? [Y/N]");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break; // Exit the inner while-loop and continue in the outer while loop.
                    if (answer == "N")
                        //exit program and give exchange totals from monitor class
                        Console.WriteLine("Total USD Exchanged: "  /* +addUsdExchanged*/);
                        Console.WriteLine("Number of exchanges done: " /* addExchange*/);
                    return; // Exit Main-method.
                }
            }
           

        }
    }
}
