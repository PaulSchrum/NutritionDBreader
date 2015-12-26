using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PhysicalUnits.Energy;
using PhysicalUnits.Mass;

namespace NutrientDb.Records
{
   public class FoodDescriptionRecord : NutrientBaseRecord
   {
      public String NDB_No { get; private set; }
      public String FoodGroupCode { get; private set; }
      public String Description { get; private set; }
      public String ShortDescription { get; private set; }
      public String CommonName { get; private set; }
      public String ManufacturerName { get; private set; }
      public String FoodGroup { get; private set; }
      public Gram Protien { get; private set; }
      public Gram FatTotal { get; private set; }
      public Gram CarbohydrateTotal { get; private set; }
      public Gram Ash { get; private set; }
      public Kilocalorie Energy_Kcal { get; private set; }
      public Gram Starch { get; private set; }
      public Sugars Sugars { get; private set; }
      public Gram Alchohol { get; private set; }
      public Gram Water { get; private set; }
      public Gram ProteinAdjusted { get; private set; }
      public Milligram Caffeine { get; private set; }
      public Milligram Theobromine { get; private set; }
      public Kilojoule Energy_KJ { get; private set;}
      public Gram SugarsTotal { get; private set; }
      public Gram Galactose { get; private set; }
      public Gram FiberTotalDietary { get; private set; }
      public Minerals Minerals { get; private set; }
      public Vitamins Vitamins { get; private set; }
      public AminoAcids AminoAcids { get; private set; }
      public Fats Fats { get; private set; }

      public Milligram Betaine { get; private set; }
      public Microgram Lycopene { get; private set; }
      public Microgram Lutein { get; private set; }

      public Gram FattyAcids_totalTrans { get; private set; }
      public Gram FattyAcids_totalSaturated { get; private set; }
      public Gram FattyAcids_totalMonounsaturated { get; private set; }
      public Gram FattyAcids_totalPolyunsaturated { get; private set; }
      public Gram FattyAcids_totalTransmonenoic { get; private set; }
      public Gram FattyAcids_totalTranspolyenoic { get; private set; }


/*
//      ~203~^~g~^~PROCNT~^~Protein~^~2~^~600~
//      ~204~^~g~^~FAT~^~Total lipid (fat)~^~2~^~800~
//      ~205~^~g~^~CHOCDF~^~Carbohydrate, by difference~^~2~^~1100~/
//      ~207~^~g~^~ASH~^~Ash~^~2~^~1000~
//      ~208~^~kcal~^~ENERC_KCAL~^~Energy~^~0~^~300~
//      ~209~^~g~^~STARCH~^~Starch~^~2~^~2200~
      ~210~^~g~^~SUCS~^~Sucrose~^~2~^~1600~
      ~211~^~g~^~GLUS~^~Glucose (dextrose)~^~2~^~1700~
      ~212~^~g~^~FRUS~^~Fructose~^~2~^~1800~
      ~213~^~g~^~LACS~^~Lactose~^~2~^~1900~
      ~214~^~g~^~MALS~^~Maltose~^~2~^~2000~
//      ~221~^~g~^~ALC~^~Alcohol, ethyl~^~1~^~18200~
//      ~255~^~g~^~WATER~^~Water~^~2~^~100~
      ~257~^~g~^~~^~Adjusted Protein~^~2~^~700~
//      ~262~^~mg~^~CAFFN~^~Caffeine~^~0~^~18300~
      ~263~^~mg~^~THEBRN~^~Theobromine~^~0~^~18400~
//      ~268~^~kJ~^~ENERC_KJ~^~Energy~^~0~^~400~
//      ~269~^~g~^~SUGAR~^~Sugars, total~^~2~^~1500~
      ~287~^~g~^~GALS~^~Galactose~^~2~^~2100~
//      ~291~^~g~^~FIBTG~^~Fiber, total dietary~^~1~^~1200~
      ~301~^~mg~^~CA~^~Calcium, Ca~^~0~^~5300~
      ~303~^~mg~^~FE~^~Iron, Fe~^~2~^~5400~
      ~304~^~mg~^~MG~^~Magnesium, Mg~^~0~^~5500~
      ~305~^~mg~^~P~^~Phosphorus, P~^~0~^~5600~
      ~306~^~mg~^~K~^~Potassium, K~^~0~^~5700~
      ~307~^~mg~^~NA~^~Sodium, Na~^~0~^~5800~
      ~309~^~mg~^~ZN~^~Zinc, Zn~^~2~^~5900~
      ~312~^~mg~^~CU~^~Copper, Cu~^~3~^~6000~
      ~313~^~µg~^~FLD~^~Fluoride, F~^~1~^~6240~
      ~315~^~mg~^~MN~^~Manganese, Mn~^~3~^~6100~
      ~317~^~µg~^~SE~^~Selenium, Se~^~1~^~6200~
      ~318~^~IU~^~VITA_IU~^~Vitamin A, IU~^~0~^~7500~
      ~319~^~µg~^~RETOL~^~Retinol~^~0~^~7430~
      ~320~^~µg~^~VITA_RAE~^~Vitamin A, RAE~^~0~^~7420~
      ~321~^~µg~^~CARTB~^~Carotene, beta~^~0~^~7440~
      ~322~^~µg~^~CARTA~^~Carotene, alpha~^~0~^~7450~
      ~323~^~mg~^~TOCPHA~^~Vitamin E (alpha-tocopherol)~^~2~^~7900~
      ~324~^~IU~^~VITD~^~Vitamin D~^~0~^~8750~
      ~325~^~µg~^~ERGCAL~^~Vitamin D2 (ergocalciferol)~^~1~^~8710~
      ~326~^~µg~^~CHOCAL~^~Vitamin D3 (cholecalciferol)~^~1~^~8720~
      ~328~^~µg~^~VITD~^~Vitamin D (D2 + D3)~^~1~^~8700~
      ~334~^~µg~^~CRYPX~^~Cryptoxanthin, beta~^~0~^~7460~
      ~337~^~µg~^~LYCPN~^~Lycopene~^~0~^~7530~
      ~338~^~µg~^~LUT+ZEA~^~Lutein + zeaxanthin~^~0~^~7560~
      ~341~^~mg~^~TOCPHB~^~Tocopherol, beta~^~2~^~8000~
      ~342~^~mg~^~TOCPHG~^~Tocopherol, gamma~^~2~^~8100~
      ~343~^~mg~^~TOCPHD~^~Tocopherol, delta~^~2~^~8200~
      ~344~^~mg~^~TOCTRA~^~Tocotrienol, alpha~^~2~^~8300~
      ~345~^~mg~^~TOCTRB~^~Tocotrienol, beta~^~2~^~8400~
      ~346~^~mg~^~TOCTRG~^~Tocotrienol, gamma~^~2~^~8500~
      ~347~^~mg~^~TOCTRD~^~Tocotrienol, delta~^~2~^~8600~
      ~401~^~mg~^~VITC~^~Vitamin C, total ascorbic acid~^~1~^~6300~
      ~404~^~mg~^~THIA~^~Thiamin~^~3~^~6400~
      ~405~^~mg~^~RIBF~^~Riboflavin~^~3~^~6500~
      ~406~^~mg~^~NIA~^~Niacin~^~3~^~6600~
      ~410~^~mg~^~PANTAC~^~Pantothenic acid~^~3~^~6700~
      ~415~^~mg~^~VITB6A~^~Vitamin B-6~^~3~^~6800~
      ~417~^~µg~^~FOL~^~Folate, total~^~0~^~6900~
      ~418~^~µg~^~VITB12~^~Vitamin B-12~^~2~^~7300~
      ~421~^~mg~^~CHOLN~^~Choline, total~^~1~^~7220~
      ~428~^~µg~^~MK4~^~Menaquinone-4~^~1~^~8950~
      ~429~^~µg~^~VITK1D~^~Dihydrophylloquinone~^~1~^~8900~
      ~430~^~µg~^~VITK1~^~Vitamin K (phylloquinone)~^~1~^~8800~
      ~431~^~µg~^~FOLAC~^~Folic acid~^~0~^~7000~
      ~432~^~µg~^~FOLFD~^~Folate, food~^~0~^~7100~
      ~435~^~µg~^~FOLDFE~^~Folate, DFE~^~0~^~7200~
      ~454~^~mg~^~BETN~^~Betaine~^~1~^~7270~
      ~501~^~g~^~TRP_G~^~Tryptophan~^~3~^~16300~
      ~502~^~g~^~THR_G~^~Threonine~^~3~^~16400~
      ~503~^~g~^~ILE_G~^~Isoleucine~^~3~^~16500~
      ~504~^~g~^~LEU_G~^~Leucine~^~3~^~16600~
      ~505~^~g~^~LYS_G~^~Lysine~^~3~^~16700~
      ~506~^~g~^~MET_G~^~Methionine~^~3~^~16800~
      ~507~^~g~^~CYS_G~^~Cystine~^~3~^~16900~
      ~508~^~g~^~PHE_G~^~Phenylalanine~^~3~^~17000~
      ~509~^~g~^~TYR_G~^~Tyrosine~^~3~^~17100~
      ~510~^~g~^~VAL_G~^~Valine~^~3~^~17200~
      ~511~^~g~^~ARG_G~^~Arginine~^~3~^~17300~
      ~512~^~g~^~HISTN_G~^~Histidine~^~3~^~17400~
      ~513~^~g~^~ALA_G~^~Alanine~^~3~^~17500~
      ~514~^~g~^~ASP_G~^~Aspartic acid~^~3~^~17600~
      ~515~^~g~^~GLU_G~^~Glutamic acid~^~3~^~17700~
      ~516~^~g~^~GLY_G~^~Glycine~^~3~^~17800~
      ~517~^~g~^~PRO_G~^~Proline~^~3~^~17900~
      ~518~^~g~^~SER_G~^~Serine~^~3~^~18000~
      ~521~^~g~^~HYP~^~Hydroxyproline~^~3~^~18100~
      ~573~^~mg~^~~^~Vitamin E, added~^~2~^~7920~
      ~578~^~µg~^~~^~Vitamin B-12, added~^~2~^~7340~
      ~601~^~mg~^~CHOLE~^~Cholesterol~^~0~^~15700~
      ~605~^~g~^~FATRN~^~Fatty acids, total trans~^~3~^~15400~
      ~606~^~g~^~FASAT~^~Fatty acids, total saturated~^~3~^~9700~
      ~607~^~g~^~F4D0~^~4:0~^~3~^~9800~
      ~608~^~g~^~F6D0~^~6:0~^~3~^~9900~
      ~609~^~g~^~F8D0~^~8:0~^~3~^~10000~
      ~610~^~g~^~F10D0~^~10:0~^~3~^~10100~
      ~611~^~g~^~F12D0~^~12:0~^~3~^~10300~
      ~612~^~g~^~F14D0~^~14:0~^~3~^~10500~
      ~613~^~g~^~F16D0~^~16:0~^~3~^~10700~
      ~614~^~g~^~F18D0~^~18:0~^~3~^~10900~
      ~615~^~g~^~F20D0~^~20:0~^~3~^~11100~
      ~617~^~g~^~F18D1~^~18:1 undifferentiated~^~3~^~12100~
      ~618~^~g~^~F18D2~^~18:2 undifferentiated~^~3~^~13100~
      ~619~^~g~^~F18D3~^~18:3 undifferentiated~^~3~^~13900~
      ~620~^~g~^~F20D4~^~20:4 undifferentiated~^~3~^~14700~
      ~621~^~g~^~F22D6~^~22:6 n-3 (DHA)~^~3~^~15300~
      ~624~^~g~^~F22D0~^~22:0~^~3~^~11200~
      ~625~^~g~^~F14D1~^~14:1~^~3~^~11500~
      ~626~^~g~^~F16D1~^~16:1 undifferentiated~^~3~^~11700~
      ~627~^~g~^~F18D4~^~18:4~^~3~^~14250~
      ~628~^~g~^~F20D1~^~20:1~^~3~^~12400~
      ~629~^~g~^~F20D5~^~20:5 n-3 (EPA)~^~3~^~15000~
      ~630~^~g~^~F22D1~^~22:1 undifferentiated~^~3~^~12500~
      ~631~^~g~^~F22D5~^~22:5 n-3 (DPA)~^~3~^~15200~
      ~636~^~mg~^~PHYSTR~^~Phytosterols~^~0~^~15800~
      ~638~^~mg~^~STID7~^~Stigmasterol~^~0~^~15900~
      ~639~^~mg~^~CAMD5~^~Campesterol~^~0~^~16000~
      ~641~^~mg~^~SITSTR~^~Beta-sitosterol~^~0~^~16200~
      ~645~^~g~^~FAMS~^~Fatty acids, total monounsaturated~^~3~^~11400~
      ~646~^~g~^~FAPU~^~Fatty acids, total polyunsaturated~^~3~^~12900~
      ~652~^~g~^~F15D0~^~15:0~^~3~^~10600~
      ~653~^~g~^~F17D0~^~17:0~^~3~^~10800~
      ~654~^~g~^~F24D0~^~24:0~^~3~^~11300~
      ~662~^~g~^~F16D1T~^~16:1 t~^~3~^~11900~
      ~663~^~g~^~F18D1T~^~18:1 t~^~3~^~12300~
      ~664~^~g~^~F22D1T~^~22:1 t~^~3~^~12700~
      ~665~^~g~^~~^~18:2 t not further defined~^~3~^~13800~
      ~666~^~g~^~~^~18:2 i~^~3~^~13700~
      ~669~^~g~^~F18D2TT~^~18:2 t,t~^~3~^~13600~
      ~670~^~g~^~F18D2CLA~^~18:2 CLAs~^~3~^~13300~
      ~671~^~g~^~F24D1C~^~24:1 c~^~3~^~12800~
      ~672~^~g~^~F20D2CN6~^~20:2 n-6 c,c~^~3~^~14300~
      ~673~^~g~^~F16D1C~^~16:1 c~^~3~^~11800~
      ~674~^~g~^~F18D1C~^~18:1 c~^~3~^~12200~
      ~675~^~g~^~F18D2CN6~^~18:2 n-6 c,c~^~3~^~13200~
      ~676~^~g~^~F22D1C~^~22:1 c~^~3~^~12600~
      ~685~^~g~^~F18D3CN6~^~18:3 n-6 c,c,c~^~3~^~14100~
      ~687~^~g~^~F17D1~^~17:1~^~3~^~12000~
      ~689~^~g~^~F20D3~^~20:3 undifferentiated~^~3~^~14400~
      ~693~^~g~^~FATRNM~^~Fatty acids, total trans-monoenoic~^~3~^~15500~
      ~695~^~g~^~FATRNP~^~Fatty acids, total trans-polyenoic~^~3~^~15600~
      ~696~^~g~^~F13D0~^~13:0~^~3~^~10400~
      ~697~^~g~^~F15D1~^~15:1~^~3~^~11600~
      ~851~^~g~^~F18D3CN3~^~18:3 n-3 c,c,c (ALA)~^~3~^~14000~
      ~852~^~g~^~F20D3N3~^~20:3 n-3~^~3~^~14500~
      ~853~^~g~^~F20D3N6~^~20:3 n-6~^~3~^~14600~
      ~855~^~g~^~F20D4N6~^~20:4 n-6~^~3~^~14900~
      ~856~^~g~^~~^~18:3i~^~3~^~14200~
      ~857~^~g~^~F21D5~^~21:5~^~3~^~15100~
      ~858~^~g~^~F22D4~^~22:4~^~3~^~15160~
      ~859~^~g~^~F18D1TN7~^~18:1-11 t (18:1t n-7)~^~3~^~12310~
      */


      public FoodDescriptionRecord(String[] strs) : base(strs)
      {
         NDB_No = base.primaryKey;
         FoodGroupCode = stripTildas(strs[1]);
         Description = stripTildas(strs[2]);
         ShortDescription = stripTildas(strs[3]);
         CommonName = stripTildas(strs[4]);
         ManufacturerName = stripTildas(strs[5]);
         Sugars = new Sugars();
         Minerals = new Minerals();
         Vitamins = new Vitamins();
         AminoAcids = new AminoAcids();
         Fats = new Fats();
      }

      internal void AssociateNutrientValues(List<NutrientDataRecord> nutrientValues)
      {
         foreach(var rcrd in nutrientValues)
         {
            switch(rcrd.Nutr_No)
            {
               case "203": { this.Protien = rcrd.Nutr_Val; break; }
               case "204": { this.FatTotal = rcrd.Nutr_Val; break; }
               case "205": { this.CarbohydrateTotal = rcrd.Nutr_Val; break; }
               case "207": { this.Ash = rcrd.Nutr_Val; break; }
               case "208": { this.Energy_Kcal = rcrd.Nutr_Val; break; }
               case "209": { this.Starch = rcrd.Nutr_Val; break; }
               case "210": { this.Sugars.Sucrose = rcrd.Nutr_Val; break; }
               case "211": { this.Sugars.Glucose = rcrd.Nutr_Val; break; }
               case "212": { this.Sugars.Fructose = rcrd.Nutr_Val; break; }
               case "213": { this.Sugars.Lactose = rcrd.Nutr_Val; break; }
               case "214": { this.Sugars.Maltose = rcrd.Nutr_Val; break; }
               case "221": { this.Alchohol = rcrd.Nutr_Val; break; }
               case "255": { this.Water = rcrd.Nutr_Val; break; }
               case "257": { this.ProteinAdjusted = rcrd.Nutr_Val; break; }
               case "262": { this.Caffeine = rcrd.Nutr_Val; break; }
               case "263": { this.Theobromine = rcrd.Nutr_Val; break; }
               case "269": { this.SugarsTotal = rcrd.Nutr_Val; break; }
               case "287": { this.Sugars.Galactose = rcrd.Nutr_Val; break; }
               case "291": { this.FiberTotalDietary = rcrd.Nutr_Val; break; }
               case "301": { this.Minerals.Calcium = rcrd.Nutr_Val; break; }
               case "303": { this.Minerals.Iron = rcrd.Nutr_Val; break; }
               case "304": { this.Minerals.Magnesium = rcrd.Nutr_Val; break; }
               case "305": { this.Minerals.Phosphorus = rcrd.Nutr_Val; break; }
               case "306": { this.Minerals.Potassium = rcrd.Nutr_Val; break; }
               case "307": { this.Minerals.Sodium = rcrd.Nutr_Val; break; }
               case "309": { this.Minerals.Zinc = rcrd.Nutr_Val; break; }
               case "312": { this.Minerals.Copper = rcrd.Nutr_Val; break; }
               case "313": { this.Minerals.Flouride = rcrd.Nutr_Val; break; }
               case "315": { this.Minerals.Manganese = rcrd.Nutr_Val; break; }
               case "317": { this.Minerals.Selenium = rcrd.Nutr_Val; break; }
               case "318": { this.Vitamins.VitaminA_IU = rcrd.Nutr_Val; break; }
               case "319": { this.Vitamins.Retinol = rcrd.Nutr_Val; break; }
               case "320": { this.Vitamins.VitaminA_ug = rcrd.Nutr_Val; break; }
               case "321": { this.Vitamins.CaroteneBeta = rcrd.Nutr_Val; break; }
               case "322": { this.Vitamins.CaroteneAlpha = rcrd.Nutr_Val; break; }
               case "323": { this.Vitamins.VitaminE = rcrd.Nutr_Val; break; }
               case "324": { this.Vitamins.VitaminD = rcrd.Nutr_Val; break; }
               case "325": { this.Vitamins.VitaminD2 = rcrd.Nutr_Val; break; }
               case "326": { this.Vitamins.VitaminD3 = rcrd.Nutr_Val; break; }
               case "328": { this.Vitamins.VitaminD2plus3 = rcrd.Nutr_Val; break; }
               case "334": { this.Vitamins.Cryptoxanthin = rcrd.Nutr_Val; break; }
               case "337": { this.Lycopene = rcrd.Nutr_Val; break; }
               case "338": { this.Lutein = rcrd.Nutr_Val; break; }
               case "341": { this.Vitamins.TocopherolBeta = rcrd.Nutr_Val; break; }
               case "342": { this.Vitamins.TocopherolGamma = rcrd.Nutr_Val; break; }
               case "343": { this.Vitamins.TocopherolDelta = rcrd.Nutr_Val; break; }
               case "344": { this.Vitamins.TocotrienolAlpha = rcrd.Nutr_Val; break; }
               case "345": { this.Vitamins.TocotrienolBeta = rcrd.Nutr_Val; break; }
               case "346": { this.Vitamins.TocotrienolGamma = rcrd.Nutr_Val; break; }
               case "347": { this.Vitamins.TocotrienolDelta = rcrd.Nutr_Val; break; }
               case "401": { this.Vitamins.VitaminC = rcrd.Nutr_Val; break; }
               case "404": { this.Vitamins.Thiamin = rcrd.Nutr_Val; break; }
               case "405": { this.Vitamins.Riboflavin = rcrd.Nutr_Val; break; }
               case "406": { this.Vitamins.Niacin = rcrd.Nutr_Val; break; }
               case "410": { this.Vitamins.PantothenicAcid = rcrd.Nutr_Val; break; }
               case "415": { this.Vitamins.VitaminB6 = rcrd.Nutr_Val; break; }
               case "417": { this.Vitamins.Folate = rcrd.Nutr_Val; break; }
               case "418": { this.Vitamins.VitaminB12 = rcrd.Nutr_Val; break; }
               case "421": { this.Vitamins.Choline = rcrd.Nutr_Val; break; }
               case "428": { this.Vitamins.Menaquinone_4 = rcrd.Nutr_Val; break; }
               case "429": { this.Vitamins.Dihydrophylloquinone = rcrd.Nutr_Val; break; }
               case "430": { this.Vitamins.VitaminK = rcrd.Nutr_Val; break; }
               case "431": { this.Vitamins.FolicAcid = rcrd.Nutr_Val; break; }
               case "432": { this.Vitamins.Folate_Food = rcrd.Nutr_Val; break; }
               case "435": { this.Vitamins.Folate_DFE = rcrd.Nutr_Val; break; }
               case "454": { this.Betaine = rcrd.Nutr_Val; break; }
               case "501": { this.AminoAcids.Tryptophan = rcrd.Nutr_Val; break; }
               case "502": { this.AminoAcids.Threonine = rcrd.Nutr_Val; break; }
               case "503": { this.AminoAcids.Isoleucine = rcrd.Nutr_Val; break; }
               case "504": { this.AminoAcids.Leucine = rcrd.Nutr_Val; break; }
               case "505": { this.AminoAcids.Lysine = rcrd.Nutr_Val; break; }
               case "506": { this.AminoAcids.Methionine = rcrd.Nutr_Val; break; }
               case "507": { this.AminoAcids.Cysteine = rcrd.Nutr_Val; break; }
               case "508": { this.AminoAcids.Phenylalanine = rcrd.Nutr_Val; break; }
               case "509": { this.AminoAcids.Tyrosine = rcrd.Nutr_Val; break; }
               case "510": { this.AminoAcids.Valine = rcrd.Nutr_Val; break; }
               case "511": { this.AminoAcids.Arginine = rcrd.Nutr_Val; break; }
               case "512": { this.AminoAcids.Histidine = rcrd.Nutr_Val; break; }
               case "513": { this.AminoAcids.Alanine = rcrd.Nutr_Val; break; }
               case "514": { this.AminoAcids.AsparticAcid = rcrd.Nutr_Val; break; }
               case "515": { this.AminoAcids.GlutamicAcid = rcrd.Nutr_Val; break; }
               case "516": { this.AminoAcids.Glycine = rcrd.Nutr_Val; break; }
               case "517": { this.AminoAcids.Proline = rcrd.Nutr_Val; break; }
               case "518": { this.AminoAcids.Serine = rcrd.Nutr_Val; break; }
               case "521": { this.AminoAcids.Hydroxyproline = rcrd.Nutr_Val; break; }
               case "573": { this.Vitamins.VitaminE_added = rcrd.Nutr_Val; break; }
               case "578": { this.Vitamins.VitaminB12_added = rcrd.Nutr_Val; break; }
               case "601": { this.Fats.Cholesterol = rcrd.Nutr_Val; break; }
               case "605": { this.FattyAcids_totalTrans = rcrd.Nutr_Val; break; }
               case "606": { this.FattyAcids_totalSaturated = rcrd.Nutr_Val; break; }
               case "607": { this.Fats.F4D0 = rcrd.Nutr_Val; break; }
               case "608": { this.Fats.F6D0 = rcrd.Nutr_Val; break; }
               case "609": { this.Fats.F8D0 = rcrd.Nutr_Val; break; }
               case "610": { this.Fats.F10D0 = rcrd.Nutr_Val; break; }
               case "611": { this.Fats.F12D0 = rcrd.Nutr_Val; break; }
               case "612": { this.Fats.F14D0 = rcrd.Nutr_Val; break; }
               case "613": { this.Fats.F16D0 = rcrd.Nutr_Val; break; }
               case "614": { this.Fats.F18D0 = rcrd.Nutr_Val; break; } /* * /
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; }
               case "6": { this.Fats = rcrd.Nutr_Val; break; } /* */
            }
         }
      }

      internal void AssignFoodGroup(Dictionary<string, FoodGroupRecord> foodGroups)
      {
         this.FoodGroup = foodGroups[this.FoodGroupCode].FdGrp_Desc;
      }
   }

   public class Vitamins
   {
      public InternationalUnit VitaminA_IU { get; internal set; }
      public Microgram Retinol { get; internal set; }
      public Microgram VitaminA_ug { get; internal set; }
      public Microgram CaroteneBeta { get; internal set; }
      public Microgram CaroteneAlpha { get; internal set; }
      public Milligram VitaminE { get; internal set; }
      public InternationalUnit VitaminD { get; internal set; }
      public Microgram VitaminD2 { get; internal set; }
      public Microgram VitaminD3 { get; internal set; }
      public Microgram VitaminD2plus3 { get; internal set; }
      public Microgram Cryptoxanthin { get; internal set; }
      public Milligram VitaminE_added { get; internal set; }
      public Milligram TocopherolBeta { get; internal set; }
      public Milligram TocopherolGamma { get; internal set; }
      public Milligram TocopherolDelta { get; internal set; }
      public Milligram TocotrienolAlpha { get; internal set; }
      public Milligram TocotrienolBeta { get; internal set; }
      public Milligram TocotrienolGamma { get; internal set; }
      public Milligram TocotrienolDelta { get; internal set; }
      public Milligram VitaminC { get; internal set; }
      public Milligram Thiamin { get; internal set; }
      public Milligram Riboflavin { get; internal set; }
      public Milligram Niacin { get; internal set; }
      public Milligram PantothenicAcid { get; internal set; }
      public Milligram VitaminB6 { get; internal set; }
      public Microgram Folate { get; internal set; }
      public Microgram VitaminB12 { get; internal set; }
      public Microgram VitaminB12_added { get; internal set; }
      public Milligram Choline { get; internal set; }
      public Microgram Menaquinone_4 { get; internal set; }
      public Microgram Dihydrophylloquinone { get; internal set; }
      public Microgram VitaminK { get; internal set; }
      public Microgram FolicAcid { get; internal set; }
      public Microgram Folate_Food { get; internal set; }
      public Microgram Folate_DFE { get; internal set; }
   }

   public class AminoAcids 
   {
      public Gram Alanine { get; internal set; }
      public Gram Arginine { get; internal set; }
      // public Gram Asparagine {get; internal set; }  // not in the database
      public Gram AsparticAcid { get; internal set; }
      public Gram Cysteine { get; internal set; }
      // public Gram Glutamine {get; internal set; }  // not in the database
      public Gram GlutamicAcid { get; internal set; }
      public Gram Glycine { get; internal set; }
      public Gram Histidine { get; internal set; }
      public Gram Hydroxyproline { get; internal set; }
      public Gram Isoleucine { get; internal set; }
      public Gram Leucine { get; internal set; }
      public Gram Lysine { get; internal set; }
      public Gram Methionine { get; internal set; }
      public Gram Phenylalanine { get; internal set; }
      public Gram Proline { get; internal set; }
      public Gram Serine { get; internal set; }
      public Gram Threonine { get; internal set; }
      public Gram Tryptophan { get; internal set; }
      public Gram Tyrosine { get; internal set; }
      public Gram Valine { get; internal set; }
   }
   public class Fats
   {
      public Milligram Cholesterol { get; internal set; }
      public Gram F4D0 { get; internal set; }
      public Gram F6D0 { get; internal set; }
      public Gram F8D0 { get; internal set; }
      public Gram F10D0 { get; internal set; }
      public Gram F12D0 { get; internal set; }
      public Gram F14D0 { get; internal set; }
      public Gram F16D0 { get; internal set; }
      public Gram F18D0 { get; internal set; }
      public Gram F20D0 { get; internal set; }
      public Gram F18D1 { get; internal set; }
      public Gram F18D2 { get; internal set; }
      public Gram F18D3 { get; internal set; }
      public Gram F20D4 { get; internal set; }
      public Gram F22D6 { get; internal set; }
      public Gram F22D0 { get; internal set; }
      public Gram F14D1 { get; internal set; }
      public Gram F16D1 { get; internal set; }
      public Gram F18D4 { get; internal set; }
      public Gram F20D1 { get; internal set; }
      public Gram F20D5 { get; internal set; }
      public Gram F22D1 { get; internal set; }
      public Gram F22D5 { get; internal set; }
      public Milligram Phytosterols { get; internal set; }
      public Milligram Stigmasterol { get; internal set; }
      public Milligram Campesterol { get; internal set; }
      public Milligram Beta_sitosterol { get; internal set; }
      public Gram F15D0 { get; internal set; }
      public Gram F17D0 { get; internal set; }
      public Gram F24D0 { get; internal set; }
      public Gram F16D1T { get; internal set; }
      public Gram F18D1T { get; internal set; }
      public Gram F22D1T { get; internal set; }
      public Gram F18D2T_notFurtherDefine { get; internal set; }
      public Gram F18D2i { get; internal set; }
      public Gram F18D2TT { get; internal set; }
      public Gram F18D2CLA { get; internal set; }
      public Gram F4D1C { get; internal set; }
      public Gram F20D2CN6 { get; internal set; }
      public Gram F16D1C { get; internal set; }
      public Gram F18D1C { get; internal set; }
      public Gram F18D2CN6 { get; internal set; }
      public Gram F17D1 { get; internal set; }
      public Gram F20D3 { get; internal set; }
      public Gram F13D0 { get; internal set; }
      public Gram F15D1 { get; internal set; }
      public Gram F18D3CN3 { get; internal set; }
      public Gram F20D3N3 { get; internal set; }
      public Gram F20D3N6 { get; internal set; }
      public Gram F20D4N6 { get; internal set; }
      public Gram F18D3I { get; internal set; }
      public Gram F21D5 { get; internal set; }
      public Gram F22D4 { get; internal set; }
      public Gram F18D1TN7 { get; internal set; }
   }

   public class Minerals
   {
      public Milligram Calcium { get; internal set; }
      public Milligram Iron { get; internal set; }
      public Milligram Magnesium { get; internal set; }
      public Milligram Manganese { get; internal set; }
      public Milligram Phosphorus { get; internal set; }
      public Milligram Potassium { get; internal set; }
      public Milligram Sodium { get; internal set; }
      public Milligram Zinc { get; internal set; }
      public Milligram Copper { get; internal set; }
      public Microgram Flouride { get; internal set; }
      public Microgram Selenium { get; internal set; }
   }

   public class Sugars
   {
      public Gram Sucrose { get; internal set; }
      public Gram Galactose { get; internal set; }
      public Gram Glucose { get; internal set; }
      public Gram Fructose { get; internal set; }
      public Gram Lactose { get; internal set; }
      public Gram Maltose { get; internal set; }
   }

}
