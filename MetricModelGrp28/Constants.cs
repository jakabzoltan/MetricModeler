using System;
using System.Collections.Generic;
using System.IO;

namespace MetricModelGrp28
{
    public static class Constants
    {
        public const decimal DevCost = (decimal)37.50;
        public const decimal SeniorDevCost = DevCost * (decimal)1.33;
        public const int HoursPerWeek = 40;
        public const int WeeksPerMonth = 4;

        public static IList<LanguagePoints> GetLanguagePoints()
        {
            var results = new List<LanguagePoints>();
            //read csv -- add to results
            using (var reader = new StreamReader("../../DataModels/Languages.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        var values = line.Split(',');
                        results.Add(new LanguagePoints()
                        {
                            Language = values[0],
                            Level = decimal.Parse(values[1].Replace(" ", "")),
                            FpManMonth = decimal.Parse(values[2].Replace(" ", "")),
                            LocFp = decimal.Parse(values[3].Replace(" ", ""))
                        });
                    }
                    else
                    {
                        break;
                    }

                }
            }





            //return list
            return results;
        }

        public static IList<FrameworkPoint> GetFrameworkPoints()
        {
            var results = new List<FrameworkPoint>();
            //read csv -- add to results
            using (var reader = new StreamReader("../../DataModels/Frameworks.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        var values = line.Split(',');
                        results.Add(new FrameworkPoint()
                        {
                            FrameworkName = values[0],
                            TimeReduction = Decimal.Parse(values[1].Replace(" ",""))
                        });
                    }
                    else
                    {
                        break;
                    }

                }
            }





            //return list
            return results;
        }

        public static IList<DeveloperSkillLevel> GetDeveloperSkills()
        {
            var results = new List<DeveloperSkillLevel>();
            //read csv -- add to results
            using (var reader = new StreamReader("../../DataModels/DeveloperSkills.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        var values = line.Split(',');
                        results.Add(new DeveloperSkillLevel()
                        {
                            Name = values[0],
                            CostModifier = Decimal.Parse(values[1].Replace(" ", ""))
                        });
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
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

    public class DeveloperSkillLevel
    {
        public string Name { get; set; }
        public decimal CostModifier { get; set; }
    }

}