using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrientDb.Records;

namespace NutrientDb
{
    public class CaratSeparatedFile
    {
       public  List<NutrientBaseRecord> allRecords { get; set; }
       public String Filename { get; set; }

       public CaratSeparatedFile()
       {
       }

       public CaratSeparatedFile(String filename_) : this()
       {
          Filename = filename_;
       }

       public virtual void LoadFile() 
       {
          if (String.IsNullOrEmpty(Filename)) 
             throw new Exception("parameter Filename can not be empty.");

          allRecords = ReadFrom(Filename)
             .Where(strArray => onLoadFilter(strArray))
             .Select(strArray => CreateNewRecord(strArray))
             .ToList()
             ;
       }

       protected virtual NutrientBaseRecord CreateNewRecord(String[] strArray)
       {
          throw new NotImplementedException();
       }

       protected virtual bool onLoadFilter(string[] arg)
       {
          return true;
       }

      internal static IEnumerable<String[]> ReadFrom(string file) 
      {
         String[] parsedLine;
         using(var reader = File.OpenText(file)) 
         {
            String line;
            while((line = reader.ReadLine()) != null) 
            {
               parsedLine = line.Split('^');
               yield return parsedLine;
            }
         }
      }

    }

}
