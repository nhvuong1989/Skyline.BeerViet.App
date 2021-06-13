namespace Skyline.BeerViet.App
{
    public class CreateUserReq
    {
        public string Region { get; set; }
        public int TeamType { get; set; }
        public int ProvinceId { get; set; }
        public string ProvinceCode { get; set; }
        public int TeamNum { get; set; }
    }
}
