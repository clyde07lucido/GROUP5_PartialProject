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
            this.buttonBookNow = new System.Windows.Forms.Button();
            this.gbSched = new System.Windows.Forms.GroupBox();
            this.comboBoxBedType = new System.Windows.Forms.ComboBox();
            this.lblBedType = new System.Windows.Forms.Label();
            this.comboBoxBeds = new System.Windows.Forms.ComboBox();
            this.lblNoBeds = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.gbSched.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 36);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(23, 89);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 25);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(23, 146);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // buttonBookNow
            // 
            this.buttonBookNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookNow.Location = new System.Drawing.Point(531, 0);
            this.buttonBookNow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBookNow.Name = "buttonBookNow";
            this.buttonBookNow.Size = new System.Drawing.Size(211, 44);
            this.buttonBookNow.TabIndex = 4;
            this.buttonBookNow.Text = "✔ Book Now!";
            this.buttonBookNow.UseVisualStyleBackColor = true;
            this.buttonBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // gbSched
            // 
            this.gbSched.Controls.Add(this.comboBoxBedType);
            this.gbSched.Controls.Add(this.lblBedType);
            this.gbSched.Controls.Add(this.comboBoxBeds);
            this.gbSched.Controls.Add(this.lblNoBeds);
            this.gbSched.Controls.Add(this.lblRoomType);
            this.gbSched.Controls.Add(this.comboBoxRoomType);
            this.gbSched.Controls.Add(this.monthCalendar1);
            this.gbSched.Controls.Add(this.buttonBookNow);
            this.gbSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSched.Location = new System.Drawing.Point(16, 220);
            this.gbSched.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSched.Name = "gbSched";
            this.gbSched.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSched.Size = new System.Drawing.Size(808, 319);
            this.gbSched.TabIndex = 5;
            this.gbSched.TabStop = false;
            this.gbSched.Text = "Schedule Availability";
            this.gbSched.Enter += new System.EventHandler(this.gbSched_Enter);
            // 
            // comboBoxBedType
            // 
            this.comboBoxBedType.FormattingEnabled = true;
            this.comboBoxBedType.Location = new System.Drawing.Point(235, 188);
            this.comboBoxBedType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBedType.Name = "comboBoxBedType";
            this.comboBoxBedType.Size = new System.Drawing.Size(215, 46);
            this.comboBoxBedType.TabIndex = 12;
            this.comboBoxBedType.SelectedIndexChanged += new System.EventHandler(this.cbBedType_SelectedIndexChanged);
            // 
            // lblBedType
            // 
            this.lblBedType.AutoSize = true;
            this.lblBedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedType.Location = new System.Drawing.Point(20, 192);
            this.lblBedType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBedType.Name = "lblBedType";
            this.lblBedType.Size = new System.Drawing.Size(138, 31);
            this.lblBedType.TabIndex = 11;
            this.lblBedType.Text = "Bed Type:";
            this.lblBedType.Click += new System.EventHandler(this.lblBedType_Click);
            // 
            // comboBoxBeds
            // 
            this.comboBoxBeds.FormattingEnabled = true;
            this.comboBoxBeds.Location = new System.Drawing.Point(235, 130);
            this.comboBoxBeds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBeds.Name = "comboBoxBeds";
            this.comboBoxBeds.Size = new System.Drawing.Size(215, 46);
            this.comboBoxBeds.TabIndex = 10;
            this.comboBoxBeds.SelectedIndexChanged += new System.EventHandler(this.cbNoBeds_SelectedIndexChanged);
            // 
            // lblNoBeds
            // 
            this.lblNoBeds.AutoSize = true;
            this.lblNoBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBeds.Location = new System.Drawing.Point(20, 134);
            this.lblNoBeds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoBeds.Name = "lblNoBeds";
            this.lblNoBeds.Size = new System.Drawing.Size(164, 31);
            this.lblNoBeds.TabIndex = 9;
            this.lblNoBeds.Text = "No. of Beds:";
            this.lblNoBeds.Click += new System.EventHandler(this.lblNoBeds_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(20, 75);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(162, 31);
            this.lblRoomType.TabIndex = 8;
            this.lblRoomType.Text = "Room Type:";
            this.lblRoomType.Click += new System.EventHandler(this.lblRoomType_Click);
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(235, 71);
            this.comboBoxRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(215, 46);
            this.comboBoxRoomType.TabIndex = 7;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(484, 71);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(104, 25);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(317, 38);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(104, 80);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(317, 38);
            this.textBoxPhone.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(104, 138);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(317, 38);
            this.textBoxEmail.TabIndex = 8;
            // 
            // BookCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 554);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.gbSched);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button buttonBookNow;
        private System.Windows.Forms.GroupBox gbSched;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblNoBeds;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.ComboBox comboBoxBeds;
        private System.Windows.Forms.ComboBox comboBoxBedType;
        private System.Windows.Forms.Label lblBedType;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}