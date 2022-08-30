namespace WebApiApplication.viewModel
{
    public class OnTheMoment
    {
        public int FromEmployeeNumber { set; get; }
        public int ToEmployeeNumber { set; get; }
        public string Comments { set; get; }
        public DateOnly RequestedDate { set; get; }
        public DateOnly RespondedOn { set; get; }
        public string Action { set; get; }
    }
}
