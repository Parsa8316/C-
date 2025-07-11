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
    public partial class Deposit : Form
    {
        public int UserId = 0;
        public string cardNo = "";

        public Deposit()
        {
            InitializeComponent();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnConfirmation_Click(object sender, EventArgs e)
        {
            ATMEntities db = new ATMEntities();
            bool doesNameExist = db.TblUser.Any(x => x.Recipient == TxtDetinationCardNo.Text);

            Err.Clear();
            if (TxtDetinationCardNo.Text.Trim().Length != 19)
            {
                Err.SetError(TxtDetinationCardNo, "Card number is wrong");
                TxtDetinationCardNo.Focus();
                TxtDetinationCardNo.Text = "";
            }
            else if (!doesNameExist)
            {
                Err.SetError(TxtName, "Destinition card does not exist!");
                TxtName.Focus();
            }
            else
            {
                TblUser From = db.TblUser.SingleOrDefault(x => x.id == UserId);
                TblUser To = db.TblUser.SingleOrDefault(x => x.Recipient == TxtDetinationCardNo.Text);
                if (To.Recipient == From.Recipient)
                {
                    Err.SetError(TxtDetinationCardNo, "You cant deposit to yourself");
                    TxtDetinationCardNo.Focus();
                }
                else if (To.Username.ToLower() != TxtName.Text.ToLower())
                {
                    Err.SetError(TxtName, "Name is wrong!");
                    TxtName.Focus();
                }
                else
                {
                    if (TxtDetinationCardNo.Visible == true && NumAmount.Visible == false)
                    {
                        TxtDetinationCardNo.Visible = false;
                        TxtName.Visible = false;
                        NumAmount.Visible = true;
                        label1.Text = "Please enter amount of deposit(by Rial)";
                    }
                    else if (TxtDetinationCardNo.Visible == false && NumAmount.Visible == true)
                    {
                        if (From.Holding - NumAmount.Value >= 0)
                        {
                            if (TxtDetinationCardNo.Text != cardNo)
                            {
                                //Show Factor
                                label1.Text = "Deposit Factor";
                                TxtDetinationCardNo.Visible = false;
                                NumAmount.Visible = false;
                                TxtName.Visible = false;
                                BtnConfirmation.Visible = false;
                                BtnReturnToMainPage.Visible = false;
                                LblDate.Text = DateTime.Now.ToString();
                                LblCardNo1.Visible = true;
                                LblCardNo2.Visible = true;
                                LblFrom.Visible = true;
                                LblTo.Visible = true;
                                LblAmount.Visible = true;
                                LblIntAmount.Visible = true;
                                BtnExit.Visible = true;
                                LblCardNo1.Text = cardNo;
                                LblCardNo2.Text = TxtDetinationCardNo.Text;
                                LblIntAmount.Text = NumAmount.Value.ToString();

                                //Add data to database
                                TblDeposit deposit = new TblDeposit();

                                deposit.DepositFromUserId = From.id;
                                deposit.DepositToUserId = To.id;
                                deposit.Amount = Convert.ToInt32(NumAmount.Value);
                                deposit.Date = DateTime.Now;

                                From.Holding -= Convert.ToInt32(NumAmount.Value);
                                To.Holding += Convert.ToInt32(NumAmount.Value);
                                db.TblDeposit.Add(deposit);
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("You cant deposit to your self");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Not enough holding");
                        }
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }
    }
}
