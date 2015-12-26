using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalUnits.Energy
{
   public class Joule : AttributedDouble
   {
      public Joule(Double initialValue)
         : base(initialValue)
      {
         this.unit = "J";
      }
   }
}
