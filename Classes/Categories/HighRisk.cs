namespace Mazzatech
{
    class HighRisk : ICategory
    {
        string ICategory.GetCategory(ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "Private")
                return "HIGHRISK";

            return string.Empty;
        }
    }
}
