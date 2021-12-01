using System;

namespace Mazzatech
{
    class Expired : ICategory
    {
        DateTime ReferenceDate { get; }
        public Expired(DateTime referenceDate)
        {
            this.ReferenceDate = referenceDate;
        }

        string ICategory.GetCategory(ITrade trade)
        {
            if (trade.NextPaymentDate < ReferenceDate.AddDays(-30))
                return "EXPIRED";

            return string.Empty;
        }
    }
}
