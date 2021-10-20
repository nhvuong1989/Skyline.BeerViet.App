using System.ComponentModel;

namespace Skyline.BeerViet.App
{
    public class SaleHistoryModel
    {
        public int HistoryId { get; set; }
        public int SaleId { get; set; }
        public int TeamId { get; set; }
        public string UserName { get; set; }
        [Description("Số lượng")]
        public int BeerVietNum { get; set; }
        [Description("Loại thùng bia")]
        public int Unit { get; set; }
        [Description("Giới tính")]
        public string Gener { get; set; }
        [Description("Tên khách hàng")]
        public string CustomerName { get; set; }
        [Description("Số điện thoại")]
        public string CustomerPhone { get; set; }
        [Description("Nón bảo hiểm")]
        public int Gif1 { get; set; }
        [Description("Thùng đá 1.6l")]
        public int Gif2 { get; set; }
        [Description("Ly thủy tinh")]
        public int Gif3 { get; set; }
        [Description("Đồng hồ treo tường")]
        public int Gif4 { get; set; }
        [Description("Áo mưa")]
        public int Gif5 { get; set; }
        [Description("Thùng đá 9l")]
        public int Gif6 { get; set; }
        [Description("Lon Bia")]
        public int Gif7 { get; set; }
        [Description("Ngày bán")]
        public string SaleDated { get; set; }
    }
}
