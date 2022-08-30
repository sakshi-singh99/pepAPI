namespace WebApiApplication.viewModel
{
    public class QuarterFinancialYear
    {
        public string FinancialYearName { set; get; }
        public string QuarterFinancialYearName { set; get; }
        public DateOnly FromDate { set; get; }
        public DateTime ToDate { set; get; }
    }
}
