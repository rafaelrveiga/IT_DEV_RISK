using System;
using System.Collections.Generic;

namespace Mazzatech
{
    class Categorizer : ICategorizer
    {
        public DateTime referenceDate { get; }
        public List<ITrade> trades { get; }
        public Categorizer(DateTime referenceDate, List<ITrade> trades)
        {
            this.referenceDate = referenceDate;
            this.trades = trades;
        }

        public string[] GetCategories()
        {
            List<string> output = new List<string>();
            foreach (ITrade trade in trades)
            {
                output.Add(this.Category(trade));
            }
            return output.ToArray();
        }

        private string Category(ITrade trade)
        {
            if (trade.NextPaymentDate < referenceDate.AddDays(-30))
                return "EXPIRED";
            if (trade.Value > 1000000)
                switch (trade.ClientSector)
                {
                    case "Private":
                        return "HIGHRISK";
                    case "Public":
                        return "MEDIUMRISK";
                }
            // if (trade.IsPoliticallyExposed)
            //     return "PEP";

            return string.Empty;
        }
    }
}