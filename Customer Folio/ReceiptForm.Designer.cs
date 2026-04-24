namespace Customer_Folio
{
    partial class ReceiptForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblSched = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picProduct1 = new System.Windows.Forms.PictureBox();
            this.panelProduct1 = new System.Windows.Forms.Panel();
            this.lblProd1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProd2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct1)).BeginInit();
            this.panelProduct1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTransactions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSched);
            this.panel1.Controls.Add(this.lblRoomNo);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 443);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.panelProduct1);
            this.panel2.Location = new System.Drawing.Point(397, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 443);
            this.panel2.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(22, 64);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(84, 20);
            this.lblRoomNo.TabIndex = 1;
            this.lblRoomNo.Text = "Room No.:";
            this.lblRoomNo.Click += new System.EventHandler(this.lblRoomNo_Click);
            // 
            // lblSched
            // 
            this.lblSched.AutoSize = true;
            this.lblSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSched.Location = new System.Drawing.Point(22, 99);
            this.lblSched.Name = "lblSched";
            this.lblSched.Size = new System.Drawing.Size(80, 20);
            this.lblSched.TabIndex = 2;
            this.lblSched.Text = "Schedule:";
            this.lblSched.Click += new System.EventHandler(this.lblSched_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "09602725953";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(228, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(128, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "theo@gmail.com";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transactions";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(26, 182);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.Size = new System.Drawing.Size(330, 244);
            this.dgvTransactions.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(14, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(119, 20);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search Product";
            this.lblSearch.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(134, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // picProduct1
            // 
            this.picProduct1.Location = new System.Drawing.Point(15, 12);
            this.picProduct1.Name = "picProduct1";
            this.picProduct1.Size = new System.Drawing.Size(100, 89);
            this.picProduct1.TabIndex = 9;
            this.picProduct1.TabStop = false;
            // 
            // panelProduct1
            // 
            this.panelProduct1.Controls.Add(this.btnAdd);
            this.panelProduct1.Controls.Add(this.label4);
            this.panelProduct1.Controls.Add(this.label2);
            this.panelProduct1.Controls.Add(this.lblProd1);
            this.panelProduct1.Controls.Add(this.picProduct1);
            this.panelProduct1.Location = new System.Drawing.Point(18, 64);
            this.panelProduct1.Name = "panelProduct1";
            this.panelProduct1.Size = new System.Drawing.Size(256, 143);
            this.panelProduct1.TabIndex = 10;
            // 
            // lblProd1
            // 
            this.lblProd1.AutoSize = true;
            this.lblProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd1.Location = new System.Drawing.Point(154, 12);
            this.lblProd1.Name = "lblProd1";
            this.lblProd1.Size = new System.Drawing.Size(71, 20);
            this.lblProd1.TabIndex = 11;
            this.lblProd1.Text = "Iced Tea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(135, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "➕ Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdd2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblProd2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(18, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 143);
            this.panel3.TabIndex = 15;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.Location = new System.Drawing.Point(135, 108);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(90, 23);
            this.btnAdd2.TabIndex = 14;
            this.btnAdd2.Text = "➕ Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock:";
            // 
            // lblProd2
            // 
            this.lblProd2.AutoSize = true;
            this.lblProd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd2.Location = new System.Drawing.Point(154, 12);
            this.lblProd2.Name = "lblProd2";
            this.lblProd2.Size = new System.Drawing.Size(89, 20);
            this.lblProd2.TabIndex = 11;
            this.lblProd2.Text = "Hamburger";
            this.lblProd2.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReceiptForm";
            this.Text = "Receipt Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct1)).EndInit();
            this.panelProduct1.ResumeLayout(false);
            this.panelProduct1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSched;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelProduct1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProd1;
        private System.Windows.Forms.PictureBox picProduct1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProd2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
    }
}