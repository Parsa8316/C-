using ATM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ViewModel
{
    class VmWithdraw
    {
        public int id { get; set; }
        public string User { get; set; }
        public int Amount { get; set; }
        public DateTime? Date { get; set; }

        public VmWithdraw() { }
        public VmWithdraw(int id, string user, int amount, DateTime? date)
        {
            this.id = id;
            User = user;
            Amount = amount;
            Date = date;
        }
        public VmWithdraw(TblWithdraw tblWithdraw)
        {
            ATMEntities db = new ATMEntities();
            this.id = tblWithdraw.id;
            User = db.TblUser.SingleOrDefault(i => i.id == tblWithdraw.UserId).Username;
            Amount = tblWithdraw.Amount;
            Date = tblWithdraw.Date;
        }
    }
}
