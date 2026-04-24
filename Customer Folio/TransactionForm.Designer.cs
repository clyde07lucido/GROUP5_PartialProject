namespace Customer_Folio
{
    partial class TransactionForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.lblVatRate = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTot = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(29, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(29, 65);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(92, 20);
            this.lblBookingID.TabIndex = 1;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrans.Location = new System.Drawing.Point(29, 101);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(100, 20);
            this.lblTrans.TabIndex = 2;
            this.lblTrans.Text = "Transactions";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(279, 54);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(128, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "theo@gmail.com";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(279, 17);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(108, 20);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "09602725953";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblContact);
            this.panelMain.Controls.Add(this.lblEmail);
            this.panelMain.Location = new System.Drawing.Point(21, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(439, 120);
            this.panelMain.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblVat);
            this.panel1.Controls.Add(this.lblVatRate);
            this.panel1.Controls.Add(this.lblSubTot);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(21, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 273);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.UnitCost,
            this.Qty,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // UnitCost
            // 
            this.UnitCost.HeaderText = "Unit Cost";
            this.UnitCost.Name = "UnitCost";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // lblSubTot
            // 
            this.lblSubTot.AutoSize = true;
            this.lblSubTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTot.Location = new System.Drawing.Point(200, 159);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(77, 20);
            this.lblSubTot.TabIndex = 7;
            this.lblSubTot.Text = "Sub Total";
            // 
            // lblVatRate
            // 
            this.lblVatRate.AutoSize = true;
            this.lblVatRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatRate.Location = new System.Drawing.Point(200, 179);
            this.lblVatRate.Name = "lblVatRate";
            this.lblVatRate.Size = new System.Drawing.Size(73, 20);
            this.lblVatRate.TabIndex = 8;
            this.lblVatRate.Text = "Vat Rate";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(200, 199);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(34, 20);
            this.lblVat.TabIndex = 9;
            this.lblVat.Text = "Vat";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTot);
            this.panel2.Location = new System.Drawing.Point(197, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 34);
            this.panel2.TabIndex = 10;
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(5, 7);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(44, 20);
            this.lblTot.TabIndex = 11;
            this.lblTot.Text = "Total";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTrans);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelMain);
            this.Name = "TransactionForm";
            this.Text = "Transaction Form";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblVatRate;
        private System.Windows.Forms.Label lblSubTot;
    }
}