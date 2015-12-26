using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalUnits.Mass
{
   public class InternationalUnit : AttributedDouble
   {
      public InternationalUnit(Double initialValue)
         : base(initialValue)
      {
         this.unit = "IU";
      }

      public static implicit operator InternationalUnit(double newVal)
      {
         return new InternationalUnit(newVal);
      }
   }
}
