namespace Customer_Folio
{
    partial class Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(44, 42);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(226, 33);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer Name";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(44, 89);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(155, 33);
            this.lblRoomNo.TabIndex = 1;
            this.lblRoomNo.Text = "Room No.:";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(44, 137);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(146, 33);
            this.lblSchedule.TabIndex = 2;
            this.lblSchedule.Text = "Schedule:";
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactions.Location = new System.Drawing.Point(38, 187);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(183, 31);
            this.lblTransactions.TabIndex = 3;
            this.lblTransactions.Text = "Transactions";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(44, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 195);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(480, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(271, 252);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTransactions);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.lblCustomer);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ListView listView1;
    }
}