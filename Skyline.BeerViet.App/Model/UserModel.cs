namespace Skyline.BeerViet.App
{
    public class UserModel
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int ProvinceId { get; set; }
        public bool IsActive { get; set; }
        public string ShiftWork { get; set; }
        public bool IsChecked { get; set; }

    }
}
