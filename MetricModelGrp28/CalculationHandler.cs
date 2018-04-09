using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricModelGrp28
{
    public class CalculationHandler
    {

        public double TotalProjectTime(double functionPoints, double fpManMonth, int developerCount)
        {
            return functionPoints / fpManMonth / developerCount;
        }

        public double TimePerPerson(double projectTime, double hoursPerWeek, int weeksPerMonth)
        {
            return projectTime * hoursPerWeek * weeksPerMonth;
        }

        public double TotalCost(int developerCount, double developerCost, double timePerPerson)
        {
            return developerCount * developerCost * timePerPerson;
        }

        public double LinesOfCode(double functionPoints, double locFp)
        {
            return functionPoints * locFp;
        }

        public double TotalDevelopmentTime(double timePerPerson, int developerCount)
        {
            return developerCount * timePerPerson;
        }
    }
}
