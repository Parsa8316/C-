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
using ATM.Utility;

namespace ATM.View
{
    public partial class MainPage : Form
    {
        public int Userid = 0;
        public string CardNo = "";
        //public int holding = 0;
        bool isHolding = false;
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            if (!isHolding)
            {
                Deposit form = new Deposit();
                this.Hide();
                form.UserId = Userid;
                form.cardNo = CardNo;
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
                this.Show();
            }
            else if(isHolding)
            {
                Application.Exit();
            }
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw form = new Withdraw();
            this.Hide();
            form.UserId = Userid;
            form.CardNo = CardNo;
            if(form.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void BtnHolding_Click(object sender, EventArgs e)
        {
            ATMEntities db = new ATMEntities();
            BtnWithdraw.Visible = false;
            BtnHolding.Visible = false;
            BtnReturn.Visible = true;
            BtnExit.Visible = false;
            BtnDeposit.Text = "Exit";
            isHolding = true;
            this.Size = new Size(330, 200);
            long holding = db.TblUser.SingleOrDefault(i => i.id == Userid).Holding;
            label1.Text = "Your Holding is " + holding.ToString();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            BtnExit.Visible = true;
            BtnWithdraw.Visible = true;
            BtnHolding.Visible = true;
            BtnReturn.Visible = false;
            BtnDeposit.Text = "Deposit";
            isHolding = false;
            this.Size = new Size(330, 260);
            label1.Text = "Choose operation";
        }

        private void BtnShowDeposit_Click(object sender, EventArgs e)
        {
            ShowDeposit form = new ShowDeposit();
            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BtnShowWithdraw_Click(object sender, EventArgs e)
        {
            ShowWithdraw form = new ShowWithdraw();
            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
