using System;
using System.Collections.Generic;

namespace Mazzatech
{
    class Categorizer
    {
        private List<ITrade> trades { get; }
        private List<ICategory> categories { get; }

        public Categorizer(List<ICategory> categories, List<ITrade> trades)
        {
            this.categories = categories;
            this.trades = trades;
        }

        public string[] GetCategories()
        {
            List<string> output = new List<string>();
            foreach (ITrade trade in trades)
            {
                string category;
                int categoryIterator = 0;
                
                do
                {
                    category = categories[categoryIterator].GetCategory(trade);
                    categoryIterator++;
                } while (category == string.Empty && categoryIterator < categories.Count);
                
                output.Add(category);
            }
            return output.ToArray();
        }
    }
}