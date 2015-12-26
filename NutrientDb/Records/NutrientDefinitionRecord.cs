using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrientDb.Records
{
   public class NutrientDefinitionRecord : NutrientBaseRecord
   {
      public String Nutr_No { get; set; }  // Unique 3-digit identifier code for a nutrient.
      public String Units { get; set; }    // Units of measure (mg, g, μg, and so on).
      public String Tagname { get; set; }  // International Network of Food Data Systems
                                           // (INFOODS) Tagnames.† A unique abbreviation for a
                                           // nutrient/food component developed by INFOODS to
                                           // aid in the interchange of data.
      public String NutrDesc { get; set; } // Name of nutrient/food component.
      public String Num_Dec { get; set; }  // Number of decimal places to which a nutrient value is rounded.
      public String SR_Order { get; set; } // Used to sort nutrient records in the same order as
                                           // various reports produced from SR.

      public NutrientDefinitionRecord(String[] strs)
         : base(strs)
      {
         Nutr_No = base.primaryKey;
         Units = stripTildas(strs[1]);
         Tagname = stripTildas(strs[2]);
         NutrDesc = stripTildas(strs[3]);
         Num_Dec = stripTildas(strs[4]);
         SR_Order = stripTildas(strs[5]);
      }
   }
}
