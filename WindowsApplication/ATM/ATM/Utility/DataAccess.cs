using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Model;

namespace ATM.Utility
{
    public class DataAccess
    {
        public int UserId;

        public List<TblUser> GetAllUsers()
        {
            ATMEntities db = new ATMEntities();
            List<TblUser> users = db.TblUser.ToList();
            return users;
        }

        //public List<int> GetUserId(int id)
        //{
        //    List<int> users = new List<int>();
        //    users.Add(id);
        //    return users;
        //}
    }
}
