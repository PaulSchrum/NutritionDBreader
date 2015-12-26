using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalUnits.Mass
{
   public class Gram : AttributedDouble
   {
      public Gram(Double initialValue) : base(initialValue)
      {
         this.unit = "g";
      }

      public static implicit operator Gram(double newVal)
      {
         return new Gram(newVal);
      }
   }
}
