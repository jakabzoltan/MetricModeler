namespace MetricModelGrp28.UniqueMetrics
{
    public class ZoltanMetric
    {
        public decimal AmountOfModels { get; set; }

        public ZoltanMetric(decimal amountOfModels)
        {
            AmountOfModels = amountOfModels;
        }
        public decimal CalculateWithDataModels(decimal functionPoints)
        {
            return functionPoints * (decimal) 0.2 * AmountOfModels;
        }
    }
}