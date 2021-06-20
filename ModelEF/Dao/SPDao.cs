using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;
using PagedList;

namespace ModelEF.Dao
{
    public class SPDao
    {
        private PhamKhuyenContext db;
        public SPDao()
        {
            db = new PhamKhuyenContext();
        }
        public List<Product> getallSP()
        {
            var list= db.Products.ToList();
            var sp = (from s in list
                      orderby s.quantity orderby s.UnitCost descending
                      select s).ToList();
            return sp;
        }
        public int insert(Product sanpham)
        {
            try
            {
                db.Products.Add(sanpham);
                db.SaveChanges();
                return sanpham.proID;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        
        public Product Find(string tensp)
        {

            List<Product> list = getallSP();
            foreach (var item in list)
            {
                if (item.Name.Equals(tensp))
                    return item;
            }
            return null;
        }
        public Product FindbyID(int id)
        {
            return db.Products.Find(id);
        }
       
    }
}
