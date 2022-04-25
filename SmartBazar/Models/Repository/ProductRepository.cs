using SmartBazar.Models.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartBazar.Models.Repository
{
    public class ProductRepository : IProduct
    {
        eCommerceEntities db = new eCommerceEntities();
        public void EditProduct(Product cat)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            Product p = new Product();
            tbl_product item = db.tbl_product.Where(x => x.pro_id == id).SingleOrDefault();

            if (item != null)
            {
                p.pro_id = item.pro_id;
                p.pro_name = item.pro_name;
                p.pro_price = item.pro_price;
                p.pro_image3 = item.pro_image3;
                p.pro_image2 = item.pro_image2;
                p.pro_image1 = item.pro_image1;
                p.pro_fk_cat_id = item.pro_fk_cat_id;
                p.pro_desc = item.pro_desc;
                p.pro_old_price = 200;

            }
         
            return p;

        }

        public void InsertProduct(Product cat)
        {
            throw new NotImplementedException();
        }

        public List<Product> ViewProduct()
        {
            List<Product> li = new List<Product>();
            List<tbl_product> products = db.tbl_product.ToList();
            foreach (var item in products)
            {
                Product p = new Product();
                p.pro_id = item.pro_id;
                p.pro_name = item.pro_name;
                p.pro_price = item.pro_price;
                p.pro_image3 = item.pro_image3;
                p.pro_image2 = item.pro_image2;
                p.pro_image1 = item.pro_image1;
                p.pro_fk_cat_id = item.pro_fk_cat_id;
                p.pro_desc = item.pro_desc;
                p.pro_old_price = 200;
               
                li.Add(p);
            }
            return li;
        }
    }
}