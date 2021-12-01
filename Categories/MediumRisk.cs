namespace Mazzatech
{
    class MediumRisk : ICategory
    {
        string ICategory.GetCategory(ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "Public")
                return "MEDIUMRISK";

            return string.Empty;
        }
    }
}
