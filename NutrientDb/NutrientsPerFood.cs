using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrientDb.Records;

namespace NutrientDb
{
   internal class NutrientsPerFood : CaratSeparatedFile
   {
      public Dictionary<String, List<NutrientDataRecord>> allValues { get; protected set; }

      public NutrientsPerFood(String path) : base(path + @"\NUT_DATA.txt")
      { }

      public override void LoadFile()
      {
         if (String.IsNullOrEmpty(Filename))
            throw new Exception("parameter Filename can not be empty.");

         allValues = new Dictionary<string, List<NutrientDataRecord>>();
         foreach (var row in ReadFrom(Filename))
         {
            var record = CreateNewRecord(row);
            var NDB_No = record.NDB_No;
            if(!(allValues.ContainsKey(record.NDB_No)))
            {
               allValues.Add(record.NDB_No, new List<NutrientDataRecord>());
            }
            allValues[NDB_No].Add(record);
         }

      }

      protected new NutrientDataRecord CreateNewRecord(String[] strArray)
      {
         return new NutrientDataRecord(strArray);
      }

      protected override bool onLoadFilter(string[] arg)
      {
         return arg[1].Equals("~208~");
         //return true;
      }

   }
}
