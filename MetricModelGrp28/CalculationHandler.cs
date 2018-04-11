using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetricModelGrp28.UniqueMetrics;

namespace MetricModelGrp28
{
    public class CalculationHandler
    {
        public decimal NumberOfDevelopers { get; set; }
        public decimal NumberOfFunctionPoints { get; set; }
        public LanguagePoint ProgrammingLanguage { get; set; }

        public ZoltanMetric ZoltanMetric { get; set; }
        public StevenMetric StevenMetric { get; set; }
        public VictorMetric VictorMetric { get; set; }
        public TylerMetric TylerMetric { get; set; }
        public bool ErrorEncountered { get; set; }

        public CalculationHandler(decimal numberOfDevelopers, decimal numberOfFunctionPoints, LanguagePoint programmingLanguage, ZoltanMetric zoltanMetric, StevenMetric stevenMetric, VictorMetric victorMetric, TylerMetric tylerMetric)
        {
            ErrorEncountered = false;
            if (numberOfDevelopers <= 0)
            {
                MessageBox.Show("Must input a value for Number of Developers");
                ErrorEncountered = true;
            }
            if (numberOfDevelopers <= 0)
            {
                MessageBox.Show("Must input a value for Number of Function Points");
                ErrorEncountered = true;
            }
            if (programmingLanguage.Language == null)
            {
                MessageBox.Show("Must select a programming language");
                ErrorEncountered = true;
            }
            if (ErrorEncountered)
            {
                return;
            }
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
            return TylerMetric.CalculateWithDesignDiagrams(
                StevenMetric.DeveloperSkillModifier(
                    VictorMetric.CalculateNewProjectTime(
                        ZoltanMetric.CalculateWithDataModels(NumberOfFunctionPoints) / ProgrammingLanguage.FpManMonth / NumberOfDevelopers)));
        }

        public decimal TimePerPerson(decimal projectTime)
        {
            return projectTime * Constants.HoursPerWeek * Constants.WeeksPerMonth;
        }

        public decimal TotalCost(decimal projectTime)
        {
            return NumberOfDevelopers * StevenMetric.ModifiedDevCost() * TimePerPerson(projectTime);
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
