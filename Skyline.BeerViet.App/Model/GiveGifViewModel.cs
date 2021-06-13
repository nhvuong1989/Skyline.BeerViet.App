using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyline.BeerViet.App
{
    public class GifViewModel
    {
        public int SaleId { get; set; }

        public int[] Gifs { get; set; }

    }
    public class GiveGifViewModel
    {
        public int TeamId { get; set; }
        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string Gener { get; set; }
        public GifViewModel GifReceive { get; set; }
    }
}
