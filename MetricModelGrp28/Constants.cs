using System.Collections.Generic;

namespace MetricModelGrp28
{
    public static class Constants
    {
        public const double DevCost = 37.50f;
        public const int HoursPerWeek = 40;
        public const int WeeksPerMonth = 4;

        public static IList<LanguagePoints> GetLanguagePoints()
        {
            var results = new List<LanguagePoints>();
            //read csv -- add to results






            //return list
            return results;
        }


    }

    public class LanguagePoints
    {
        public string Language { get; set; }
        public float Level { get; set; }
        public float FpManMonth { get; set; }
        public float LocFp { get; set; }
    }
}