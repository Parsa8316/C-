namespace ATM.View
{
    partial class Deposit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDetinationCardNo = new System.Windows.Forms.MaskedTextBox();
            this.BtnConfirmation = new System.Windows.Forms.Button();
            this.BtnReturnToMainPage = new System.Windows.Forms.Button();
            this.NumAmount = new System.Windows.Forms.NumericUpDown();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblDate = new System.Windows.Forms.Label();
            this.LblFrom = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblTo = new System.Windows.Forms.Label();
            this.LblCardNo1 = new System.Windows.Forms.Label();
            this.LblCardNo2 = new System.Windows.Forms.Label();
            this.LblIntAmount = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter destination card number";
            // 
            // TxtDetinationCardNo
            // 
            this.TxtDetinationCardNo.BackColor = System.Drawing.Color.MidnightBlue;
            this.TxtDetinationCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDetinationCardNo.ForeColor = System.Drawing.Color.White;
            this.TxtDetinationCardNo.Location = new System.Drawing.Point(114, 115);
            this.TxtDetinationCardNo.Mask = "0000 0000 0000 0000";
            this.TxtDetinationCardNo.Name = "TxtDetinationCardNo";
            this.TxtDetinationCardNo.Size = new System.Drawing.Size(214, 30);
            this.TxtDetinationCardNo.TabIndex = 1;
            // 
            // BtnConfirmation
            // 
            this.BtnConfirmation.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmation.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmation.Location = new System.Drawing.Point(246, 213);
            this.BtnConfirmation.Name = "BtnConfirmation";
            this.BtnConfirmation.Size = new System.Drawing.Size(213, 46);
            this.BtnConfirmation.TabIndex = 3;
            this.BtnConfirmation.Text = "Confirmation";
            this.BtnConfirmation.UseVisualStyleBackColor = false;
            this.BtnConfirmation.Click += new System.EventHandler(this.BtnConfirmation_Click);
            // 
            // BtnReturnToMainPage
            // 
            this.BtnReturnToMainPage.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnReturnToMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnToMainPage.ForeColor = System.Drawing.Color.White;
            this.BtnReturnToMainPage.Location = new System.Drawing.Point(246, 265);
            this.BtnReturnToMainPage.Name = "BtnReturnToMainPage";
            this.BtnReturnToMainPage.Size = new System.Drawing.Size(213, 46);
            this.BtnReturnToMainPage.TabIndex = 5;
            this.BtnReturnToMainPage.Text = "ReturnToMainPage ";
            this.BtnReturnToMainPage.UseVisualStyleBackColor = false;
            this.BtnReturnToMainPage.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // NumAmount
            // 
            this.NumAmount.BackColor = System.Drawing.Color.MidnightBlue;
            this.NumAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumAmount.ForeColor = System.Drawing.Color.White;
            this.NumAmount.Location = new System.Drawing.Point(114, 115);
            this.NumAmount.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.NumAmount.Name = "NumAmount";
            this.NumAmount.Size = new System.Drawing.Size(214, 30);
            this.NumAmount.TabIndex = 4;
            this.NumAmount.Tag = "ggg";
            this.NumAmount.Visible = false;
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.White;
            this.LblDate.Location = new System.Drawing.Point(36, 71);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(0, 25);
            this.LblDate.TabIndex = 7;
            // 
            // LblFrom
            // 
            this.LblFrom.AutoSize = true;
            this.LblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFrom.ForeColor = System.Drawing.Color.White;
            this.LblFrom.Location = new System.Drawing.Point(12, 115);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(68, 25);
            this.LblFrom.TabIndex = 8;
            this.LblFrom.Text = "From :";
            this.LblFrom.Visible = false;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.MidnightBlue;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.White;
            this.TxtName.Location = new System.Drawing.Point(114, 158);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(214, 30);
            this.TxtName.TabIndex = 2;
            // 
            // LblTo
            // 
            this.LblTo.AutoSize = true;
            this.LblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTo.ForeColor = System.Drawing.Color.White;
            this.LblTo.Location = new System.Drawing.Point(12, 161);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(47, 25);
            this.LblTo.TabIndex = 9;
            this.LblTo.Text = "To :";
            this.LblTo.Visible = false;
            // 
            // LblCardNo1
            // 
            this.LblCardNo1.AutoSize = true;
            this.LblCardNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardNo1.ForeColor = System.Drawing.Color.White;
            this.LblCardNo1.Location = new System.Drawing.Point(131, 118);
            this.LblCardNo1.Name = "LblCardNo1";
            this.LblCardNo1.Size = new System.Drawing.Size(0, 25);
            this.LblCardNo1.TabIndex = 10;
            this.LblCardNo1.Visible = false;
            // 
            // LblCardNo2
            // 
            this.LblCardNo2.AutoSize = true;
            this.LblCardNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardNo2.ForeColor = System.Drawing.Color.White;
            this.LblCardNo2.Location = new System.Drawing.Point(131, 163);
            this.LblCardNo2.Name = "LblCardNo2";
            this.LblCardNo2.Size = new System.Drawing.Size(0, 25);
            this.LblCardNo2.TabIndex = 11;
            this.LblCardNo2.Visible = false;
            // 
            // LblIntAmount
            // 
            this.LblIntAmount.AutoSize = true;
            this.LblIntAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIntAmount.ForeColor = System.Drawing.Color.White;
            this.LblIntAmount.Location = new System.Drawing.Point(131, 213);
            this.LblIntAmount.Name = "LblIntAmount";
            this.LblIntAmount.Size = new System.Drawing.Size(0, 25);
            this.LblIntAmount.TabIndex = 12;
            this.LblIntAmount.Visible = false;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmount.ForeColor = System.Drawing.Color.White;
            this.LblAmount.Location = new System.Drawing.Point(12, 213);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(91, 25);
            this.LblAmount.TabIndex = 13;
            this.LblAmount.Text = "Amount :";
            this.LblAmount.Visible = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(-40, 265);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(213, 46);
            this.BtnExit.TabIndex = 14;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Visible = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(439, 342);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.LblIntAmount);
            this.Controls.Add(this.LblCardNo2);
            this.Controls.Add(this.LblCardNo1);
            this.Controls.Add(this.LblTo);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblFrom);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.NumAmount);
            this.Controls.Add(this.BtnReturnToMainPage);
            this.Controls.Add(this.BtnConfirmation);
            this.Controls.Add(this.TxtDetinationCardNo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtDetinationCardNo;
        private System.Windows.Forms.Button BtnConfirmation;
        private System.Windows.Forms.Button BtnReturnToMainPage;
        private System.Windows.Forms.NumericUpDown NumAmount;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblFrom;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblTo;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.Label LblIntAmount;
        private System.Windows.Forms.Label LblCardNo2;
        private System.Windows.Forms.Label LblCardNo1;
    }
}