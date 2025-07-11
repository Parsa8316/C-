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

namespace ATM.View
{
    public partial class Withdraw : Form
    {
        public int UserId = 0;
        public string CardNo = "";
        public Withdraw()
        {
            InitializeComponent();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmation_Click(object sender, EventArgs e)
        {
            if(NumAmount.Value == 0 || string.IsNullOrEmpty(NumAmount.Value.ToString()))
            {
                Err.SetError(NumAmount, "Entered amount shouldnt be zero or empty");
                NumAmount.Focus();
            }
            else
            {
                ATMEntities db = new ATMEntities();
                TblUser IsHoldingEnough = db.TblUser.SingleOrDefault(x => x.id == UserId);
                if(IsHoldingEnough.Holding - NumAmount.Value >= 0)
                {
                    ATMEntities contex = new ATMEntities();
                    TblWithdraw withdraw = new TblWithdraw();
                    withdraw.UserId = UserId;
                    withdraw.Amount = Convert.ToInt32(NumAmount.Value);
                    withdraw.Date = DateTime.Now;

                    TblUser user = contex.TblUser.SingleOrDefault(x => x.id == UserId);
                    //TblUser2 user2 = contex.TblUser2.SingleOrDefault(x => x.id == UserId);
                    user.Holding -= Convert.ToInt32(NumAmount.Value);
                    //user2.Holding -= Convert.ToInt32(NumAmount.Value);
                    contex.TblWithdraw.Add(withdraw);
                    contex.SaveChanges();

                    if(MessageBox.Show("Do you want factor ?", "Withdraw", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        label1.Text = "Withdraw Factor";
                        BtnConfirmation.Visible = false;
                        BtnReturn.Visible = false;
                        NumAmount.Visible = false;
                        BtnReturn2.Visible = true;
                        BtnExit.Visible = true;
                        LblCardNo.Visible = true;
                        LblCardNoInt.Visible = true;
                        LblDate.Visible = true;
                        LblDate.Text = DateTime.Now.ToString();
                        LblAmount.Visible = true;
                        LblHolding.Visible = true;
                        LblCardNoInt.Text = CardNo;
                        LblIntAmount.Text = NumAmount.Value.ToString();
                        ATMEntities holding = new ATMEntities();
                        TblUser tblUser = holding.TblUser.SingleOrDefault(x => x.id == UserId);
                        LblHoldingInt.Text = tblUser.Holding.ToString();
                        this.Size = new Size(320, 310);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Your holding is not enough");
                }
            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReturn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
