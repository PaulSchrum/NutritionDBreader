using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrientDb.Records;

namespace NutrientDb
{
   public class NutirentInfo
   {
      public Foods AllFoods { get; set; }
      public NutrientDefinitions AllNutrientDefs { get; set; }
      public String DBdirectory { get; set; }

      public NutirentInfo()
      {
         DBdirectory = @"C:\SourceModules\CodeKatas\USDAnutrientDatabase\fromUSDA";
      }

      public void LoadAllData()
      {
         Stopwatch sw = new Stopwatch();
         sw.Start();
         var AllFoodGroups = new FoodGroups(DBdirectory);
         AllNutrientDefs = new NutrientDefinitions(DBdirectory);
         AllFoods = new Foods(DBdirectory);
         var AllNutrientValues = new NutrientsPerFood(DBdirectory);
         AllNutrientDefs.LoadFile();
         AllFoods.LoadFile();
         AllNutrientValues.LoadFile();
         AllFoodGroups.LoadFile();
         AllFoods.AssociateNutrientRows(AllNutrientValues, AllFoodGroups);

         // this is no faster, but it is an example of running tasks in parallel
         //List<Task> TaskList = new List<Task>();
         //TaskList.Add(Task.Run(() => AllNutrientDefs.LoadFile()));
         //TaskList.Add(Task.Run(() => AllFoods.LoadFile()));
         //TaskList.Add(Task.Run(() => AllNutrientValues.LoadFile()));
         //Task.WaitAll(TaskList.ToArray());
         sw.Stop();

         Double seconds = (Double) sw.ElapsedMilliseconds/ 1000.0;
      }


      public IOrderedEnumerable<FoodDescriptionRecord> GetAllFoodsSortedByEnergy()
      {
         return this.AllFoods.GetAllFoodsSortedByEnergy();
      }

      public IOrderedEnumerable<FoodDescriptionRecord> GetAllFoodsReverseSortedByEnergy()
      {
         return this.AllFoods.GetAllFoodsReverseSortedByEnergy();
      }
   }
}
