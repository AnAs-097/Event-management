namespace marriage_hall_DBMS_project.forms
{
    partial class cancel_booking
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bamount = new System.Windows.Forms.Label();
            this.bdate = new System.Windows.Forms.Label();
            this.bname = new System.Windows.Forms.Label();
            this.bid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Booking ID to cancel";
            // 
            // searchid
            // 
            this.searchid.Location = new System.Drawing.Point(419, 42);
            this.searchid.Name = "searchid";
            this.searchid.Size = new System.Drawing.Size(75, 23);
            this.searchid.TabIndex = 1;
            this.searchid.Text = "Search";
            this.searchid.UseVisualStyleBackColor = true;
            this.searchid.Click += new System.EventHandler(this.searchid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Booking ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount:";
            // 
            // bamount
            // 
            this.bamount.AutoSize = true;
            this.bamount.Location = new System.Drawing.Point(129, 167);
            this.bamount.Name = "bamount";
            this.bamount.Size = new System.Drawing.Size(0, 13);
            this.bamount.TabIndex = 9;
            // 
            // bdate
            // 
            this.bdate.AutoSize = true;
            this.bdate.Location = new System.Drawing.Point(129, 142);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(0, 13);
            this.bdate.TabIndex = 10;
            // 
            // bname
            // 
            this.bname.AutoSize = true;
            this.bname.Location = new System.Drawing.Point(129, 116);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(0, 13);
            this.bname.TabIndex = 11;
            this.bname.Click += new System.EventHandler(this.label8_Click);
            // 
            // bid
            // 
            this.bid.AutoSize = true;
            this.bid.Location = new System.Drawing.Point(129, 90);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(0, 13);
            this.bid.TabIndex = 12;
            // 
            // cancel_booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 327);
            this.Controls.Add(this.bid);
            this.Controls.Add(this.bname);
            this.Controls.Add(this.bdate);
            this.Controls.Add(this.bamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchid);
            this.Controls.Add(this.textBox1);
            this.Name = "cancel_booking";
            this.Text = "cancel_booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bamount;
        private System.Windows.Forms.Label bdate;
        private System.Windows.Forms.Label bname;
        private System.Windows.Forms.Label bid;
    }
}