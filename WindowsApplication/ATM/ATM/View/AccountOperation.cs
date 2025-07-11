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
    public partial class AccountOperation : Form
    {
        public AccountOperation()
        {
            InitializeComponent();
        }

        private void AccountOperation_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            TxtCardNo.Text = random.Next(1, 10000).ToString() + random.Next(0, 10000).ToString() +
                random.Next(0, 10000).ToString() + random.Next(0, 10000).ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Err.Clear();
            ATMEntities db = new ATMEntities();
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                Err.SetError(TxtName, "Please enter your name");
                TxtName.Focus();
            }
            else if (db.TblUser.Any(x => x.Recipient == TxtCardNo.Text))
            {
                Err.SetError(TxtCardNo, "This card number already taken. please try again");
            }
            else if (db.TblUser.Any(i => i.Username.ToLower() == TxtName.Text.ToLower()))
            {
                Err.SetError(TxtName, "This username already taken. try another one");
                TxtName.Focus();
            }
            else if (TxtPassword.Text.Length != 4)
            {
                Err.SetError(TxtPassword, "Password must be 4 characters");
                TxtPassword.Focus();
            }
            else
            {
                TblUser user = new TblUser();
                user.Username = TxtName.Text;
                user.Recipient = TxtCardNo.Text;
                user.Holding = Convert.ToInt32(TxtHolding.Text);
                user.Password = short.Parse(TxtPassword.Text);

                ATMEntities contex = new ATMEntities();
                contex.TblUser.Add(user);
                contex.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
