using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrientDb.Records;

namespace NutrientDb
{
   public class Foods : CaratSeparatedFile
   {
      public Dictionary<String, FoodDescriptionRecord> allFoods { get; protected set; }

      public Foods(String path) : base(path + @"\FOOD_DES.txt")
      { }

      public override void LoadFile()
      {
         if (String.IsNullOrEmpty(Filename))
            throw new Exception("parameter Filename can not be empty.");

         allFoods = ReadFrom(Filename)
            .Where(strArray => onLoadFilter(strArray))
            .Select(strArray => CreateNewRecord(strArray))
            .ToDictionary(food => food.primaryKey)
            ;

      }

      public IEnumerable<FoodDescriptionRecord> GetAllFoodsSortedBy(Func<FoodDescriptionRecord, bool> filter)
      {
         return this.allFoods.Values.OrderBy(rcrd => filter(rcrd));
      }

      protected new FoodDescriptionRecord CreateNewRecord(String[] strArray)
      {
         return new FoodDescriptionRecord(strArray);
      }

      protected override bool onLoadFilter(string[] arg)
      {
         return true;
      }

      internal void AssociateNutrientRows(
         NutrientsPerFood AllNutrientValues, 
         FoodGroups allFoodGroups
         )
      {
         foreach(var food in this.allFoods)
         {
            food.Value.AssociateNutrientValues(AllNutrientValues.allValues[food.Key]);
            food.Value.AssignFoodGroup(allFoodGroups.allFoodGroups);
         }
      }

      internal void AssignFoodGroups(FoodGroups allFoodGroups)
      {
      }

      internal IOrderedEnumerable<FoodDescriptionRecord> GetAllFoodsSortedByEnergy()
      {
         return this.allFoods.Values.OrderBy(food => food.Energy_Kcal);
      }

      internal IOrderedEnumerable<FoodDescriptionRecord> GetAllFoodsReverseSortedByEnergy()
      {
         return this.allFoods.Values.OrderByDescending(food => food.Energy_Kcal);
      }
   }
}
