namespace WebApiApplication.viewModel
{
    public class PromotionData
    {
        public int EmployeeId { set; get; }
        public DateOnly LastPromotionDate { set; get; }
        public string ReadyForPromotion { set; get; }
        public string PromotionComments { set; get; }
    }
}
