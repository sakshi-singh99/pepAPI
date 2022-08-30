namespace WebApiApplication.viewModel
{
    public class CheckList
    {
        public int EmployeeId { set; get; }
        public DateOnly QuarterYear { set; get; }
        public string Type { set; get; }    
        public int Achievable { set; get; }
        public int Achieved { set; get; }
    }
}
