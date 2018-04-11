using System.Linq;

namespace MetricModelGrp28.UniqueMetrics
{
    public class VictorMetric
    {
        public FrameworkPoint FrameworkUsed { get; set; }
        public VictorMetric(string frameworkUsed)
        {
            FrameworkUsed = Constants.GetFrameworkPoints().FirstOrDefault(x=>x.FrameworkName == frameworkUsed);
        }

        public decimal CalculateNewProjectTime(decimal currentProjecTime)
        {
            return currentProjecTime * FrameworkUsed.TimeReduction;
        }
    }
}