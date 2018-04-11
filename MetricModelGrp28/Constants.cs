using System.Collections.Generic;

namespace MetricModelGrp28
{
    public static class Constants
    {
        public const decimal DevCost = (decimal) 37.50;
        public const decimal SeniorDevCost = DevCost * (decimal) 1.33;
        public const int HoursPerWeek = 40;
        public const int WeeksPerMonth = 4;

        public static IList<LanguagePoints> GetLanguagePoints()
        {
            var results = new List<LanguagePoints>();
            //read csv -- add to results






            //return list
            return results;
        }

        public static IList<FrameworkPoint> GetFrameworkPoints()
        {
            var results = new List<FrameworkPoint>();
            //read csv -- add to results






            //return list
            return results;
        }
    }

    public class LanguagePoints
    {
        public string Language { get; set; }
        public decimal Level { get; set; }
        public decimal FpManMonth { get; set; }
        public decimal LocFp { get; set; }
    }

    public class FrameworkPoint
    {
        public string FrameworkName { get; set; }
        public decimal TimeReduction { get; set; }
    }

}