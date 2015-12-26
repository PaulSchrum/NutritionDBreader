using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrientDb.Records
{
   public class FoodGroupRecord : NutrientBaseRecord
   {
      public string FdGrp_Cd { get; private set; }    //
      public string FdGrp_Desc { get; private set; }  // Name of food group

      public FoodGroupRecord(String[] strs)
         : base(strs)
      {
         FdGrp_Cd = base.primaryKey;
         FdGrp_Desc = stripTildas(strs[1]);
      }
   }
}
