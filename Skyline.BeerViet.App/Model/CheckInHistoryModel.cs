namespace Skyline.BeerViet.App
{
    public class CheckInHistoryModel
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string WorkType { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string ProvinceName { get; set; }
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string TeamName { get; set; }
        public string CheckInTime { get; set; }
        public string CheckOutTime { get; set; }
    }
}
