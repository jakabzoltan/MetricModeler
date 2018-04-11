namespace MetricModelGrp28.UniqueMetrics
{
    public class TylerMetric
    {
        public bool DiagramsComplete { get; set; }
        //design sessions
        public TylerMetric(bool diagramsComplete)
        {
            DiagramsComplete = diagramsComplete;
        }

        public decimal CalculateWithDesignDiagrams(decimal currentProjectTime)
        {
            return DiagramsComplete ? currentProjectTime * (decimal) 0.75 : currentProjectTime * (decimal) 1.1; 
        }
    }
}