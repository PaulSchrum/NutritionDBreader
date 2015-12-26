using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalUnits.Energy
{
   public class Kilocalorie : AttributedDouble
   {
      public Kilocalorie(Double initialValue)
         : base(initialValue)
      {
         this.unit = "kcal";
      }

      public static implicit operator Kilocalorie(double newVal)
      {
         return new Kilocalorie(newVal);
      }

   }
}
