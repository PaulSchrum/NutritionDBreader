using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrientDb.Records
{
   public abstract class NutrientBaseRecord
   {
      internal String primaryKey { get; set; }

      public NutrientBaseRecord(String[] strs)
      {
         primaryKey = stripTildas(strs[0]);
      }

      protected String stripTildas(String str)
      {
         var array = str.Split('~');
         return array[1];
      }
   }
}
