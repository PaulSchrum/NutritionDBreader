using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrientDb.Records;


namespace NutrientDb
{
   public class FoodGroups : CaratSeparatedFile
   {
      public Dictionary<String, FoodGroupRecord> allFoodGroups { get; private set; }

      public FoodGroups(String path)
         : base(path + @"\FD_GROUP.txt")
      { }

      public override void LoadFile()
      {
         if (String.IsNullOrEmpty(Filename))
            throw new Exception("parameter Filename can not be empty.");

         allFoodGroups = ReadFrom(Filename)
            .Where(strArray => onLoadFilter(strArray))
            .Select(strArray => CreateNewRecord(strArray))
            .ToDictionary(row => row.primaryKey)
            ;

      }

      protected new FoodGroupRecord CreateNewRecord(String[] strArray)
      {
         return new FoodGroupRecord(strArray);
      }

      protected override bool onLoadFilter(string[] arg)
      {
         return true;
      }
   }
}
