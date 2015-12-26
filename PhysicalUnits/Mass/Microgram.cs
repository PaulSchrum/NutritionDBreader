using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalUnits.Mass
{
   public class Microgram : AttributedDouble
   {
      public Microgram(Double initialValue)
         : base(initialValue)
      {
         this.unit = "μg";
      }

      public static implicit operator Microgram(double newVal)
      {
         return new Microgram(newVal);
      }
   }
}
