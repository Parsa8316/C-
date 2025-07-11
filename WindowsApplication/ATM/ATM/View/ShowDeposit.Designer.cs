namespace ATM.View
{
    partial class ShowDeposit
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
            this.viewDepositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTMDataSet1 = new ATM.ATMDataSet1();
            this.viewDepositTableAdapter = new ATM.ATMDataSet1TableAdapters.ViewDepositTableAdapter();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDepositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.From,
            this.To,
            this.Amount,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // viewDepositBindingSource
            // 
            this.viewDepositBindingSource.DataMember = "ViewDeposit";
            this.viewDepositBindingSource.DataSource = this.aTMDataSet1;
            // 
            // aTMDataSet1
            // 
            this.aTMDataSet1.DataSetName = "ATMDataSet1";
            this.aTMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewDepositTableAdapter
            // 
            this.viewDepositTableAdapter.ClearBeforeFill = true;
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(966, 13);
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
            // From
            // 
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 6;
            this.From.Name = "From";
            this.From.Width = 125;
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 6;
            this.To.Name = "To";
            this.To.Width = 125;
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
            // ShowDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowDeposit";
            this.Load += new System.EventHandler(this.ShowDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDepositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ATMDataSet1 aTMDataSet1;
        private System.Windows.Forms.BindingSource viewDepositBindingSource;
        private ATMDataSet1TableAdapters.ViewDepositTableAdapter viewDepositTableAdapter;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}