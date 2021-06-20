using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;
using PagedList;

namespace ModelEF.Dao
{
    public class UserDao
    {
        private PhamKhuyenContext db;
        public UserDao()
        {
            db = new PhamKhuyenContext();
        }
        public int loginDao(string username, string password)
        {
            var result = db.UserAcounts.SingleOrDefault(x => x.UserName.Contains(username) && x.Password.Contains(password));
            if (result == null)
                return 0;
            else
                return 1;
        }
        public List<UserAcount> getalluser()
        {
            return db.UserAcounts.ToList();
        }
        public IEnumerable<UserAcount> getsearchuser(string username, int page, int pagesize)
        {
            IQueryable<UserAcount> model = db.UserAcounts;
            if (!string.IsNullOrEmpty(username))
            { model = model.Where(x => x.UserName.Contains(username)); }
            return model.OrderBy(x => x.UserName).ToPagedList(page, pagesize);
        }
       
        public bool Delete(string username)
        {
            var user = Find(username);
            if(user.Status.Contains("Blocked"))
            {
                db.UserAcounts.Remove(user);
                db.SaveChanges();
                return true;
            } else
            {
                return false;
            }
        }
        public UserAcount Find(string username)
        {

            var list = db.UserAcounts.ToList();
            foreach( var item in list)
            {
                if (item.UserName.Equals(username))
                    return item;
                
            }
            return null;
        }
    }
}
