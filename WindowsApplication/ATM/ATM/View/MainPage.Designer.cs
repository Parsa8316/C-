namespace ATM.View
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnHolding = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnShowDeposit = new System.Windows.Forms.Button();
            this.BtnShowWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeposit.ForeColor = System.Drawing.Color.White;
            this.BtnDeposit.Location = new System.Drawing.Point(-6, 111);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(152, 46);
            this.BtnDeposit.TabIndex = 1;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = false;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWithdraw.ForeColor = System.Drawing.Color.White;
            this.BtnWithdraw.Location = new System.Drawing.Point(274, 111);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(154, 46);
            this.BtnWithdraw.TabIndex = 2;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = false;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Operation";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(-6, 173);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(152, 46);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnHolding
            // 
            this.BtnHolding.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnHolding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHolding.ForeColor = System.Drawing.Color.White;
            this.BtnHolding.Location = new System.Drawing.Point(274, 173);
            this.BtnHolding.Name = "BtnHolding";
            this.BtnHolding.Size = new System.Drawing.Size(154, 46);
            this.BtnHolding.TabIndex = 4;
            this.BtnHolding.Text = "Holding";
            this.BtnHolding.UseVisualStyleBackColor = false;
            this.BtnHolding.Click += new System.EventHandler(this.BtnHolding_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(274, 111);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(152, 46);
            this.BtnReturn.TabIndex = 6;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Visible = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnShowDeposit
            // 
            this.BtnShowDeposit.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnShowDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowDeposit.ForeColor = System.Drawing.Color.White;
            this.BtnShowDeposit.Location = new System.Drawing.Point(-6, 225);
            this.BtnShowDeposit.Name = "BtnShowDeposit";
            this.BtnShowDeposit.Size = new System.Drawing.Size(134, 32);
            this.BtnShowDeposit.TabIndex = 7;
            this.BtnShowDeposit.Text = "ShowDeposit";
            this.BtnShowDeposit.UseVisualStyleBackColor = false;
            this.BtnShowDeposit.Click += new System.EventHandler(this.BtnShowDeposit_Click);
            // 
            // BtnShowWithdraw
            // 
            this.BtnShowWithdraw.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnShowWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowWithdraw.ForeColor = System.Drawing.Color.White;
            this.BtnShowWithdraw.Location = new System.Drawing.Point(294, 225);
            this.BtnShowWithdraw.Name = "BtnShowWithdraw";
            this.BtnShowWithdraw.Size = new System.Drawing.Size(134, 32);
            this.BtnShowWithdraw.TabIndex = 8;
            this.BtnShowWithdraw.Text = "ShowWithdraw";
            this.BtnShowWithdraw.UseVisualStyleBackColor = false;
            this.BtnShowWithdraw.Click += new System.EventHandler(this.BtnShowWithdraw_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(421, 269);
            this.Controls.Add(this.BtnShowWithdraw);
            this.Controls.Add(this.BtnShowDeposit);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnHolding);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnWithdraw);
            this.Controls.Add(this.BtnDeposit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnHolding;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnShowDeposit;
        private System.Windows.Forms.Button BtnShowWithdraw;
    }
}