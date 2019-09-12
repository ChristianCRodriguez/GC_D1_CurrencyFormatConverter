using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_1___Currency_Format_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<double> dollarAmounts = new List<double>();
            string userInput;
            double userOutput;
            const double jpExchangeRate = 107.54, seExchangeRate = 9.68, thExchangeRate = 30.61;

            Console.WriteLine("Hello! Please enter the first dollar amount");
            userInput = Console.ReadLine();
            while (!double.TryParse(userInput, out userOutput))
            {
                Console.WriteLine("I'm sorry, but I did not understand that input, please try again.");
                userInput = Console.ReadLine();
            }

            dollarAmounts.Add(userOutput);

            Console.WriteLine("Now enter the second dollar amount");
            userInput = Console.ReadLine();
            while (!double.TryParse(userInput, out userOutput))
            {
                Console.WriteLine("I'm sorry, but I did not understand that input, please try again.");
                userInput = Console.ReadLine();
            }

            dollarAmounts.Add(userOutput);

            Console.WriteLine("Now enter the final dollar amount");
            userInput = Console.ReadLine();
            while (!double.TryParse(userInput, out userOutput))
            {
                Console.WriteLine("I'm sorry, but I did not understand that input, please try again.");
                userInput = Console.ReadLine();
            }

            dollarAmounts.Add(userOutput);

            Console.WriteLine("Total: {0}", dollarAmounts.Sum());
            Console.WriteLine("Average Amount: {0}", dollarAmounts.Average());
            Console.WriteLine("Largest Amount: {0}", dollarAmounts.Max());
            Console.WriteLine("Smallest Amount: {0}", dollarAmounts.Min());

            var total = dollarAmounts.Sum();

            Console.WriteLine("US Dollars: {0}", total.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Swedish Krona: {0}", (total * seExchangeRate).ToString("C2", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.WriteLine("Japanese Yen: {0}", (total * jpExchangeRate).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai Baht: {0}", (total * thExchangeRate).ToString("C2", CultureInfo.CreateSpecificCulture("th-TH")));

            Console.ReadLine();
        }
    }
}
