using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrientDb.Records;

namespace NutrientDb
{
   public class NutrientDefinitions : CaratSeparatedFile
   {
      public Dictionary<String, NutrientDefinitionRecord> allNutrientDefinitions { get; protected set; }

      public NutrientDefinitions(String path)
         : base(path + @"\NUTR_DEF.txt")
      { }

      public override void LoadFile()
      {
         if (String.IsNullOrEmpty(Filename))
            throw new Exception("parameter Filename can not be empty.");

         allNutrientDefinitions = ReadFrom(Filename)
            .Where(strArray => onLoadFilter(strArray))
            .Select(strArray => CreateNewRecord(strArray))
            .ToDictionary(row => row.primaryKey)
            ;

      }

      protected new NutrientDefinitionRecord CreateNewRecord(String[] strArray)
      {
         return new NutrientDefinitionRecord(strArray);
      }

      protected override bool onLoadFilter(string[] arg)
      {
         return true;
      }
   }
}
