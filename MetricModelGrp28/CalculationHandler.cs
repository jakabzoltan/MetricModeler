using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetricModelGrp28.UniqueMetrics;

namespace MetricModelGrp28
{
    public class CalculationHandler
    {
        public decimal NumberOfDevelopers { get; set; }
        public decimal NumberOfFunctionPoints { get; set; }
        public LanguagePoints ProgrammingLanguage { get; set; }

        public ZoltanMetric ZoltanMetric { get; set; }
        public StevenMetric StevenMetric { get; set; }
        public VictorMetric VictorMetric { get; set; }
        public TylerMetric TylerMetric { get; set; }

        public CalculationHandler(decimal numberOfDevelopers, decimal numberOfFunctionPoints, LanguagePoints programmingLanguage, ZoltanMetric zoltanMetric, StevenMetric stevenMetric, VictorMetric victorMetric, TylerMetric tylerMetric)
        {
            NumberOfDevelopers = numberOfDevelopers;
            NumberOfFunctionPoints = numberOfFunctionPoints;
            ProgrammingLanguage = programmingLanguage;
            ZoltanMetric = zoltanMetric;
            StevenMetric = stevenMetric;
            VictorMetric = victorMetric;
            TylerMetric = tylerMetric;
        }

        public decimal TotalProjectTime()
        {
            return StevenMetric.SeniorDeveloperProjecTime(VictorMetric.CalculateNewProjectTime(ZoltanMetric.CalculateWithDataModels(NumberOfFunctionPoints) / ProgrammingLanguage.FpManMonth / NumberOfDevelopers));
        }

        public decimal TimePerPerson(decimal projectTime)
        {
            return projectTime * Constants.HoursPerWeek * Constants.WeeksPerMonth;
        }

        public decimal TotalCost(decimal projectTime)
        {
            return NumberOfDevelopers * Constants.DevCost * TimePerPerson(projectTime);
        }

        public decimal LinesOfCode()
        {
            return ZoltanMetric.CalculateWithDataModels(NumberOfFunctionPoints) * ProgrammingLanguage.LocFp;
        }

        public decimal TotalDevelopmentTime(decimal projectTime)
        {
            return NumberOfDevelopers * TimePerPerson(projectTime);
        }
    }
}
