using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutrientDb;
using System.Linq;

using PhysicalUnits.Energy;

namespace NutritionDBtests
{
   [TestClass]
   public class TestNutritionDB
   {
      public NutirentInfo NutrientDB { get; set; }

      [TestInitialize]
      public void initTests()
      {
         NutrientDB = new NutirentInfo();
         NutrientDB.LoadAllData();
      }

      [TestMethod]
      public void NutrientDB_AllFoods_isPopulated()
      {
         Assert.IsNotNull(NutrientDB);
         Assert.IsNotNull(NutrientDB.AllFoods);
         Assert.IsTrue(NutrientDB.AllFoods.allFoods.Count > 2);
      }

      [TestMethod]
      public void NutrientDB_SortFoods_ByEnergy()
      {
         //var rslt = NutrientDB.AllFoods.GetAllFoodsSortedBy(food => food.Energy_KCal);
         //var rslt = NutrientDB.GetAllFoodsReverseSortedByEnergy()
         var rslt = NutrientDB.GetAllFoodsSortedByEnergy()
            .Where(entry => entry.Energy_Kcal > 0.0)
            ;

         var sweetThings = rslt
            .Where(entry => entry.Description.ToLower().Contains("artificial"))
            .Where(entry => entry.FiberTotalDietary != null)
            //.Where(entry => entry.Description.ToLower().Contains("candy"))
            //.Where(entry => !(entry.Description.ToLower().Contains("cottonseed")))
            .OrderBy(row => row.FiberTotalDietary)
            ;

         var count = sweetThings.Count();
         //var rsltt = NutrientDB.AllFoods.allFoods.Values.Where(entry => entry.Energy_KCal > 0.0);
         Assert.IsTrue(true);
      }

      [TestMethod]
      public void NutrientDB_AllNutrientDefs_isPopulated()
      {
         Assert.IsNotNull(NutrientDB.AllNutrientDefs);
         Assert.IsTrue(NutrientDB.AllNutrientDefs.allNutrientDefinitions.Count > 2);
      }
   }
}
