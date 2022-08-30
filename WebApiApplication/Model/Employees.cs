namespace WebApiApplication.viewModel
{
    public class Employees
    {
        public int EmployeeId { set; get; }
        public string Name { set; get; }
        public string Designation { set; get; }
        public string SupervisiorName { set; get; }
        public string Department { set; get; }
        public int  Contact { set; get; }
        public DateOnly JoiningDate { set; get; }

    }
}
