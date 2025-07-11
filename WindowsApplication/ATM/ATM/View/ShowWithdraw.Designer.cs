namespace ATM.View
{
    partial class ShowWithdraw
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewWithdrawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTMDataSet2 = new ATM.ATMDataSet2();
            this.viewWithdrawTableAdapter = new ATM.ATMDataSet2TableAdapters.ViewWithdrawTableAdapter();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewWithdrawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.User,
            this.Amount,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // viewWithdrawBindingSource
            // 
            this.viewWithdrawBindingSource.DataMember = "ViewWithdraw";
            this.viewWithdrawBindingSource.DataSource = this.aTMDataSet2;
            // 
            // aTMDataSet2
            // 
            this.aTMDataSet2.DataSetName = "ATMDataSet2";
            this.aTMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewWithdrawTableAdapter
            // 
            this.viewWithdrawTableAdapter.ClearBeforeFill = true;
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(772, 13);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(81, 46);
            this.BtnReturn.TabIndex = 1;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // ShowWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowWithdraw";
            this.Load += new System.EventHandler(this.ShowWithdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewWithdrawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ATMDataSet2 aTMDataSet2;
        private System.Windows.Forms.BindingSource viewWithdrawBindingSource;
        private ATMDataSet2TableAdapters.ViewWithdrawTableAdapter viewWithdrawTableAdapter;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}