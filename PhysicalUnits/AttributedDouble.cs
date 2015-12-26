using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalUnits
{
    public class AttributedDouble : IComparable<AttributedDouble>
    {
       public Double val { get; set; }
       public String unit { get; protected set; }

       public AttributedDouble(Double initialValue)
       {
          val = initialValue;
          unit = "Not Set";
       }

       public int CompareTo(AttributedDouble other)
       {
          if (this.val == other.val)
             return 0;
          if (this.val > other.val)
             return 1;
          return -1;
       }

       public override string ToString()
       {
          return String.Format("{0} {1}", this.val, this.unit);
       }

       public static bool operator >(AttributedDouble left, Double right)
       {
          return left.val > right;
       }

       public static bool operator <(AttributedDouble left, Double right)
       {
          return left.val < right;
       }

    }
}
