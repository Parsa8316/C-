using ATM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ViewModel
{
    public class VmDeposit
    {
        public int id {  get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Amount { get; set; }
        public DateTime? Date { get; set; }

        public VmDeposit() { }
        public VmDeposit(int id, string from, string to, int amount, DateTime date)
        {
            this.id = id;
            From = from;
            To = to;
            Amount = amount;
            Date = date;
        }
        public VmDeposit(TblDeposit deposit)
        {
            ATMEntities db = new ATMEntities();
            this.id = deposit.id;
            From = db.TblUser.SingleOrDefault(i => i.id == deposit.DepositFromUserId).Username;
            To = db.TblUser.SingleOrDefault(i => i.id == deposit.DepositToUserId).Username;
            Amount = deposit.Amount;
            Date = deposit.Date;
        }
    }
}
