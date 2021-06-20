using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;
namespace ModelEF.Dao
{

    public class CateDao
    {
        private PhamKhuyenContext db;
        public CateDao()
        {
            db = new PhamKhuyenContext();
        }
        public List<Category> getAllCate()
        {
           
            return db.Categories.ToList();
        }
    }
}
