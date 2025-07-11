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
    public partial class ShowWithdraw : Form
    {
        public ShowWithdraw()
        {
            InitializeComponent();
        }

        private void ShowWithdraw_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTMDataSet2.ViewWithdraw' table. You can move, or remove it, as needed.
            //this.viewWithdrawTableAdapter.Fill(this.aTMDataSet2.ViewWithdraw);

            List<VmWithdraw> vmWithdraws = new List<VmWithdraw>();
            ATMEntities db = new ATMEntities();
            foreach (TblWithdraw i in db.TblWithdraw.ToList())
            {
                vmWithdraws.Add(new VmWithdraw(i));
            }
            foreach (VmWithdraw i in vmWithdraws)
            {
                dataGridView1.Rows.Add(i.id,i.User,i.Amount,i.Date);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
