using System.Globalization;
using System;
using System.Collections.Generic;

namespace Mazzatech
{
    class Program
    {
        static readonly List<string> input = new List<string>() { "12/11/2020",
                                                                   "4",
                                                                   "2000000 Private 12/29/2025",
                                                                   "400000 Public 07/01/2020",
                                                                   "5000000 Public 01/02/2024",
                                                                   "3000000 Public 10/26/2023"};

        static void Main(string[] args)
        {
            DateTime referenceDate = Convert.ToDateTime(input[0], new CultureInfo("en-US"));
            short tradesCount = Convert.ToInt16(input[1]);

            List<ITrade> trades = new List<ITrade>();
            for (int i = 0; i < tradesCount; i++)
            {
                trades.Add(new Trade(input[i + 2]));
            }

            Categorizer categorizer = new Categorizer(referenceDate, trades);

            Console.WriteLine(string.Join('\n', categorizer.GetCategories()));
        }
    }
}
