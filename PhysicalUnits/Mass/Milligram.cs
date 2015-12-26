using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalUnits.Mass
{
   public class Milligram : AttributedDouble
   {
      public Milligram(Double initialValue) : base(initialValue)
      {
         this.unit = "mg";
      }

      public static implicit operator Milligram(double newVal)
      {
         return new Milligram(newVal);
      }
   }
}
