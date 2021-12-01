using System;
using System.Globalization;

namespace Mazzatech
{
    class Trade : ITrade
    {
        public double Value { get; }
        public string ClientSector { get; }
        public DateTime NextPaymentDate { get; }
        //public bool IsPoliticallyExposed { get; }

        public Trade(string input)
        {
            string[] inputSplitted = input.Split(' ');
            for (int i = 0; i < inputSplitted.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        this.Value = Convert.ToDouble(inputSplitted[i]);
                        break;
                    case 1:
                        this.ClientSector = inputSplitted[i];
                        break;
                    case 2:
                        this.NextPaymentDate = Convert.ToDateTime(inputSplitted[i], new CultureInfo("en-US"));
                        break;
                    //case 3:
                    //    this.IsPoliticallyExposed = Convert.ToBoolean(inputSplitted[i]);
                    //    break;
                }
            }
        }
    }
}