using System;
using System.Collections.Generic;

namespace Mazzatech
{
    interface ICategorizer
    {
        DateTime referenceDate { get; }
        List<ITrade> trades { get; }
        string[] GetCategories();
    }
}