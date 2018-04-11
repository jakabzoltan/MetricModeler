using System.Collections.Generic;
using System.Linq;

namespace MetricModelGrp28.UniqueMetrics
{
    public class StevenMetric
    {
        public DeveloperSkillLevel DeveloperSkillLevel { get; set; }

        public StevenMetric(string developerType)
        {
            DeveloperSkillLevel = Constants.GetDeveloperSkills().FirstOrDefault(x => x.Name == developerType);

        }
        public decimal DeveloperSkillModifier(decimal currentProjectTime)
        {
            return currentProjectTime / DeveloperSkillLevel.CostModifier;
        }

        public decimal ModifiedDevCost()
        {
            return Constants.DevCost * DeveloperSkillLevel.CostModifier;
        }
    }
}