using System;

namespace Skyline.BeerViet.App
{
    public class WorkShopModel
    {
        public int Id { get; set; }//WorkShop id, this is primary key int table. Use it to edit, delete. If Id == 0 => add new.
        public int SessionId { get; set; }// ID resturn when user login success. it save in one day
        public bool IsMarket { get; set; }
        public string WorkShopName { get; set; }
        public string WorkShopAddress { get; set; }
        public string WorkShopDesc { get; set; }
        public string TrafficDesc { get; set; }
        public int Result { get; set; }//0: Confirm, 1: Reject, 2: Doi Trade tra loi => FOR MARKET
        public string ResultText { get; set; }//FOR SHOP
        public int ProvinceId { get; set; }
        public bool IsActive { get; set; }
        public bool IsChecked { get; set; }
        public DateTime ExecuteDate { get; set; }

    }
}
