namespace Skyline.BeerViet.App
{
    public class ProvinceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsChecked { get; set; }

        //--:[{"TeamId":1,"TeamName":"BV01","TeamType":1},   
    }

    public class ProvinceActiveModel
    { 
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int TeamType { get; set; }

    }
}
