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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTMDataSet.TblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.aTMDataSet.TblUser);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Err.Clear();
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                Err.SetError(TxtName, "Please enter your name");
                TxtName.Focus();
            }
            else if (TxtPassword.Text.Length != 4)
            {
                Err.SetError(TxtPassword, "Password must be 4 characters");
                TxtPassword.Focus();
            }
            else if (TxtCardNo.Text.Trim().Length != 19)
            {
                Err.SetError(TxtCardNo, "Entered card number is not correct");
                TxtCardNo.Focus();
            }
            else
            {
                ATMEntities db = new ATMEntities();
                if (db.TblUser.Any(i => i.Username == TxtName.Text))
                {
                    TblUser user = db.TblUser.SingleOrDefault(i => i.Username == TxtName.Text);
                    if (TxtPassword.Text.Trim() == user.Password.ToString() && TxtCardNo.Text.Trim() == user.Recipient)
                    {
                        try
                        {
                            MainPage form = new MainPage();
                            this.Hide();
                            form.Userid = user.id;
                            form.CardNo = user.Recipient;
                            //form.holding = Convert.ToInt32(user.Holding);
                            if (form.ShowDialog() == DialogResult.OK)
                            {

                            }
                            this.Show();
                        }
                        catch (ObjectDisposedException)
                        {
                            this.Close();
                        }
                    }
                    else if (TxtPassword.Text.Trim() != user.Password.ToString())
                    {
                        Err.SetError(TxtPassword, "Password is wrong");
                        TxtPassword.Focus();
                    }
                    else if (TxtCardNo.Text.Trim() != user.Recipient)
                    {
                        Err.SetError(TxtCardNo, "Card number is wrong");
                        TxtCardNo.Focus();
                    }
                }
                else
                {
                    Err.SetError(TxtName, "User does not exist");
                    TxtName.Focus();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AccountOperation form = new AccountOperation();
            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
