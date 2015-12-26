using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalUnits.Energy
{
   public class Kilojoule : AttributedDouble
   {
      public Kilojoule(Double initialValue)
         : base(initialValue)
      {
         this.unit = "kJ";
      }
   }
}
