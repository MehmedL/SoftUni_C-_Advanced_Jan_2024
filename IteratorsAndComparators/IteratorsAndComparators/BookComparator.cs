using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare( Book? x,  Book? y)
        {
            int alphabetica =  x.Title.CompareTo(y.Title);

            if (alphabetica == 0)
            {
                return y.Year.CompareTo(x.Year);
            }
            return alphabetica;
        }
    }
}
