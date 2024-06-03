using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Z1
{
    public class AnimalNameLengthComparer : IComparer<Animal>
    {
        public int Compare([AllowNull] Animal x, [AllowNull] Animal y)
        {
            if(x == null || y == null)
            {
                throw new ArgumentNullException();
            }
            return x.Name.Length.CompareTo(y.Name.Length);
        }
    }
}
