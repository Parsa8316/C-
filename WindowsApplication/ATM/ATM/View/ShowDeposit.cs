using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Model;
using ATM.ViewModel;

namespace ATM.View
{
    public partial class ShowDeposit : Form
    {
        public ShowDeposit()
        {
            InitializeComponent();
        }

        private void ShowDeposit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTMDataSet1.ViewDeposit' table. You can move, or remove it, as needed.
            //this.viewDepositTableAdapter.Fill(this.aTMDataSet1.ViewDeposit);

            ATMEntities db = new ATMEntities();
            List<VmDeposit> vmDeposits = new List<VmDeposit>();
            foreach (TblDeposit i in db.TblDeposit.ToList())
            {
                vmDeposits.Add(new VmDeposit(i));
            }

            foreach (VmDeposit i in vmDeposits)
            {
                dataGridView1.Rows.Add(i.id,i.From,i.To,i.Amount,i.Date);
            }

        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
