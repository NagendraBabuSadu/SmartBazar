using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartBazar.Models.View_Models
{
    public class Product
    {
        public int pro_id { get; set; }
        public string pro_name { get; set; }
        public string pro_image1 { get; set; }
        public string pro_image2 { get; set; }
        public string pro_image3 { get; set; }
        public string pro_desc { get; set; }
        public Nullable<double> pro_price { get; set; }

        public Nullable<double> pro_old_price { get; set; }


        public Nullable<int> pro_fk_cat_id { get; set; }
    }
}