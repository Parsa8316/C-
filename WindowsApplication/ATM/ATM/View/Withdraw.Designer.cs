namespace ATM.View
{
    partial class Withdraw
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
            this.NumAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirmation = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblDate = new System.Windows.Forms.Label();
            this.LblCardNo = new System.Windows.Forms.Label();
            this.LblCardNoInt = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.LblIntAmount = new System.Windows.Forms.Label();
            this.LblHolding = new System.Windows.Forms.Label();
            this.LblHoldingInt = new System.Windows.Forms.Label();
            this.BtnReturn2 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // NumAmount
            // 
            this.NumAmount.BackColor = System.Drawing.Color.MidnightBlue;
            this.NumAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumAmount.ForeColor = System.Drawing.Color.White;
            this.NumAmount.Location = new System.Drawing.Point(97, 95);
            this.NumAmount.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.NumAmount.Name = "NumAmount";
            this.NumAmount.Size = new System.Drawing.Size(214, 30);
            this.NumAmount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the desire amount";
            // 
            // BtnConfirmation
            // 
            this.BtnConfirmation.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmation.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmation.Location = new System.Drawing.Point(272, 164);
            this.BtnConfirmation.Name = "BtnConfirmation";
            this.BtnConfirmation.Size = new System.Drawing.Size(152, 46);
            this.BtnConfirmation.TabIndex = 7;
            this.BtnConfirmation.Text = "Confirmation";
            this.BtnConfirmation.UseVisualStyleBackColor = false;
            this.BtnConfirmation.Click += new System.EventHandler(this.BtnConfirmation_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(-17, 164);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(152, 46);
            this.BtnReturn.TabIndex = 8;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
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
            this.LblDate.Location = new System.Drawing.Point(38, 61);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(0, 25);
            this.LblDate.TabIndex = 9;
            // 
            // LblCardNo
            // 
            this.LblCardNo.AutoSize = true;
            this.LblCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardNo.ForeColor = System.Drawing.Color.White;
            this.LblCardNo.Location = new System.Drawing.Point(38, 100);
            this.LblCardNo.Name = "LblCardNo";
            this.LblCardNo.Size = new System.Drawing.Size(91, 25);
            this.LblCardNo.TabIndex = 10;
            this.LblCardNo.Text = "CardNo :";
            this.LblCardNo.Visible = false;
            // 
            // LblCardNoInt
            // 
            this.LblCardNoInt.AutoSize = true;
            this.LblCardNoInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardNoInt.ForeColor = System.Drawing.Color.White;
            this.LblCardNoInt.Location = new System.Drawing.Point(156, 100);
            this.LblCardNoInt.Name = "LblCardNoInt";
            this.LblCardNoInt.Size = new System.Drawing.Size(0, 25);
            this.LblCardNoInt.TabIndex = 11;
            this.LblCardNoInt.Visible = false;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmount.ForeColor = System.Drawing.Color.White;
            this.LblAmount.Location = new System.Drawing.Point(38, 145);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(91, 25);
            this.LblAmount.TabIndex = 15;
            this.LblAmount.Text = "Amount :";
            this.LblAmount.Visible = false;
            // 
            // LblIntAmount
            // 
            this.LblIntAmount.AutoSize = true;
            this.LblIntAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIntAmount.ForeColor = System.Drawing.Color.White;
            this.LblIntAmount.Location = new System.Drawing.Point(157, 145);
            this.LblIntAmount.Name = "LblIntAmount";
            this.LblIntAmount.Size = new System.Drawing.Size(0, 25);
            this.LblIntAmount.TabIndex = 14;
            // 
            // LblHolding
            // 
            this.LblHolding.AutoSize = true;
            this.LblHolding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHolding.ForeColor = System.Drawing.Color.White;
            this.LblHolding.Location = new System.Drawing.Point(38, 185);
            this.LblHolding.Name = "LblHolding";
            this.LblHolding.Size = new System.Drawing.Size(89, 25);
            this.LblHolding.TabIndex = 16;
            this.LblHolding.Text = "Holding :";
            this.LblHolding.Visible = false;
            // 
            // LblHoldingInt
            // 
            this.LblHoldingInt.AutoSize = true;
            this.LblHoldingInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoldingInt.ForeColor = System.Drawing.Color.White;
            this.LblHoldingInt.Location = new System.Drawing.Point(157, 185);
            this.LblHoldingInt.Name = "LblHoldingInt";
            this.LblHoldingInt.Size = new System.Drawing.Size(0, 25);
            this.LblHoldingInt.TabIndex = 17;
            // 
            // BtnReturn2
            // 
            this.BtnReturn2.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnReturn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn2.ForeColor = System.Drawing.Color.White;
            this.BtnReturn2.Location = new System.Drawing.Point(-17, 234);
            this.BtnReturn2.Name = "BtnReturn2";
            this.BtnReturn2.Size = new System.Drawing.Size(152, 46);
            this.BtnReturn2.TabIndex = 18;
            this.BtnReturn2.Text = "Return";
            this.BtnReturn2.UseVisualStyleBackColor = false;
            this.BtnReturn2.Visible = false;
            this.BtnReturn2.Click += new System.EventHandler(this.BtnReturn2_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(272, 234);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(152, 46);
            this.BtnExit.TabIndex = 19;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Visible = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(410, 263);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnReturn2);
            this.Controls.Add(this.LblHoldingInt);
            this.Controls.Add(this.LblHolding);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.LblIntAmount);
            this.Controls.Add(this.LblCardNoInt);
            this.Controls.Add(this.LblCardNo);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnConfirmation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumAmount);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirmation;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblCardNoInt;
        private System.Windows.Forms.Label LblCardNo;
        private System.Windows.Forms.Label LblHoldingInt;
        private System.Windows.Forms.Label LblHolding;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.Label LblIntAmount;
        private System.Windows.Forms.Button BtnReturn2;
        private System.Windows.Forms.Button BtnExit;
    }
}