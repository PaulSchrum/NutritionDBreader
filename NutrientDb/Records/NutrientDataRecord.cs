using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrientDb.Records
{
   public class NutrientDataRecord : NutrientBaseRecord
   {
      public String NDB_No { get; set; }  // 5-digit Nutrient Databank number that uniquely
                                          // identifies a food item. If this field is defined as
                                          // numeric, the leading zero will be lost.
      public String Nutr_No { get; set; }  // Unique 3-digit identifier code for a nutrient.
      public Double Nutr_Val { get; set; }  // Amount in 100 grams, edible portion

      public NutrientDataRecord(String[] strs)
         : base(strs)
      {
         NDB_No = base.primaryKey;
         Nutr_No = stripTildas(strs[1]);
         Nutr_Val = Double.Parse(strs[2]);
      }   
   }
}
