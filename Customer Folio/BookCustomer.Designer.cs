namespace Customer_Folio
{
    partial class BookCustomer
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
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.gbSched = new System.Windows.Forms.GroupBox();
            this.cbBedType = new System.Windows.Forms.ComboBox();
            this.lblBedType = new System.Windows.Forms.Label();
            this.cbNoBeds = new System.Windows.Forms.ComboBox();
            this.lblNoBeds = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gbSched.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(17, 72);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 18);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // btnBookNow
            // 
            this.btnBookNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookNow.Location = new System.Drawing.Point(398, 0);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(158, 36);
            this.btnBookNow.TabIndex = 4;
            this.btnBookNow.Text = "✔ Book Now!";
            this.btnBookNow.UseVisualStyleBackColor = true;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // gbSched
            // 
            this.gbSched.Controls.Add(this.cbBedType);
            this.gbSched.Controls.Add(this.lblBedType);
            this.gbSched.Controls.Add(this.cbNoBeds);
            this.gbSched.Controls.Add(this.lblNoBeds);
            this.gbSched.Controls.Add(this.lblRoomType);
            this.gbSched.Controls.Add(this.cbRoomType);
            this.gbSched.Controls.Add(this.monthCalendar1);
            this.gbSched.Controls.Add(this.btnBookNow);
            this.gbSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSched.Location = new System.Drawing.Point(12, 179);
            this.gbSched.Name = "gbSched";
            this.gbSched.Size = new System.Drawing.Size(606, 259);
            this.gbSched.TabIndex = 5;
            this.gbSched.TabStop = false;
            this.gbSched.Text = "Schedule Availability";
            this.gbSched.Enter += new System.EventHandler(this.gbSched_Enter);
            // 
            // cbBedType
            // 
            this.cbBedType.FormattingEnabled = true;
            this.cbBedType.Location = new System.Drawing.Point(176, 153);
            this.cbBedType.Name = "cbBedType";
            this.cbBedType.Size = new System.Drawing.Size(162, 37);
            this.cbBedType.TabIndex = 12;
            this.cbBedType.SelectedIndexChanged += new System.EventHandler(this.cbBedType_SelectedIndexChanged);
            // 
            // lblBedType
            // 
            this.lblBedType.AutoSize = true;
            this.lblBedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedType.Location = new System.Drawing.Point(15, 156);
            this.lblBedType.Name = "lblBedType";
            this.lblBedType.Size = new System.Drawing.Size(97, 24);
            this.lblBedType.TabIndex = 11;
            this.lblBedType.Text = "Bed Type:";
            this.lblBedType.Click += new System.EventHandler(this.lblBedType_Click);
            // 
            // cbNoBeds
            // 
            this.cbNoBeds.FormattingEnabled = true;
            this.cbNoBeds.Location = new System.Drawing.Point(176, 106);
            this.cbNoBeds.Name = "cbNoBeds";
            this.cbNoBeds.Size = new System.Drawing.Size(162, 37);
            this.cbNoBeds.TabIndex = 10;
            this.cbNoBeds.SelectedIndexChanged += new System.EventHandler(this.cbNoBeds_SelectedIndexChanged);
            // 
            // lblNoBeds
            // 
            this.lblNoBeds.AutoSize = true;
            this.lblNoBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBeds.Location = new System.Drawing.Point(15, 109);
            this.lblNoBeds.Name = "lblNoBeds";
            this.lblNoBeds.Size = new System.Drawing.Size(113, 24);
            this.lblNoBeds.TabIndex = 9;
            this.lblNoBeds.Text = "No. of Beds:";
            this.lblNoBeds.Click += new System.EventHandler(this.lblNoBeds_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(15, 61);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(114, 24);
            this.lblRoomType.TabIndex = 8;
            this.lblRoomType.Text = "Room Type:";
            this.lblRoomType.Click += new System.EventHandler(this.lblRoomType_Click);
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(176, 58);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(162, 37);
            this.cbRoomType.TabIndex = 7;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(363, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(78, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 29);
            this.txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(78, 65);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(239, 29);
            this.txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(78, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 29);
            this.txtEmail.TabIndex = 8;
            // 
            // BookCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gbSched);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "BookCustomer";
            this.Text = "BookCustomer";
            this.Load += new System.EventHandler(this.BookCustomer_Load);
            this.gbSched.ResumeLayout(false);
            this.gbSched.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.GroupBox gbSched;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblNoBeds;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.ComboBox cbNoBeds;
        private System.Windows.Forms.ComboBox cbBedType;
        private System.Windows.Forms.Label lblBedType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
    }
}