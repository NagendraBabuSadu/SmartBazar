using SmartBazar.Models.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartBazar.Models.Repository
{
    public class CategoryRepository : ICategory
    {
        eCommerceEntities db = new eCommerceEntities();
        public void EditCategory(Category item)
        {
            tbl_category c = db.tbl_category.Where(x => x.cat_id == item.cat_id).SingleOrDefault();
            c.cat_id = item.cat_id;
            c.cat_name = item.cat_name;
            c.cat_icon = item.cat_icon;
            c.cat_createdon = DateTime.Now;
            c.cat_color = item.cat_color;
            c.cat_fk_Ad_id = item.cat_fk_Ad_id;
            db.SaveChanges();
        }

        public Category GetCategoryById(int id)
        {
            tbl_category item = db.tbl_category.Where(x => x.cat_id == id).SingleOrDefault();
            Category c = new Category();
            c.cat_id = item.cat_id;
            c.cat_name = item.cat_name;
            c.cat_icon = item.cat_icon;
            c.cat_color = item.cat_color;
            c.cat_createdon = item.cat_createdon;
            c.cat_fk_Ad_id = item.cat_fk_Ad_id;
            return c;
        }

        public void InsertCategory(Category item)
        {
            tbl_category c = new tbl_category();
            c.cat_id = item.cat_id;
            c.cat_name = item.cat_name;
            c.cat_color = item.cat_color;
            c.cat_icon = item.cat_icon;
            c.cat_createdon = DateTime.Now;
            c.cat_fk_Ad_id = item.cat_fk_Ad_id;
            db.tbl_category.Add(c);
            db.SaveChanges();
        }

        public List<Category> ViewCategory()
        {
            List<Category> li = new List<Category>();
            List<tbl_category> cat = db.tbl_category.ToList();
            foreach (var item in cat)
            {
                Category c = new Category();
                c.cat_id = item.cat_id;
                c.cat_color = item.cat_color;
                c.cat_name = item.cat_name;
                c.cat_icon = item.cat_icon;
                c.cat_createdon = item.cat_createdon;
                c.cat_fk_Ad_id = item.cat_fk_Ad_id;
                li.Add(c);
            }
            return li;
        }
    }
}