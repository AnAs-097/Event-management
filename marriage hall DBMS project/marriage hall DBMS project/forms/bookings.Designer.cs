namespace marriage_hall_DBMS_project.forms
{
    partial class bookings
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Booking_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfPersons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Booking_ID,
            this.GuestName,
            this.TypeOfEvent,
            this.Venue,
            this.NoOfPersons,
            this.EventTime,
            this.EventDate,
            this.BookingDate,
            this.BookingBy,
            this.TotalAmount,
            this.View,
            this.Update});
            this.dataGridView1.Location = new System.Drawing.Point(1, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 406);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Booking_ID
            // 
            this.Booking_ID.DataPropertyName = "Booking_ID";
            this.Booking_ID.HeaderText = "Booking ID";
            this.Booking_ID.Name = "Booking_ID";
            this.Booking_ID.Width = 50;
            // 
            // GuestName
            // 
            this.GuestName.DataPropertyName = "GuestName";
            this.GuestName.HeaderText = "Guest  Name";
            this.GuestName.Name = "GuestName";
            // 
            // TypeOfEvent
            // 
            this.TypeOfEvent.DataPropertyName = "TypeOfEvent";
            this.TypeOfEvent.HeaderText = "Type Of Event";
            this.TypeOfEvent.Name = "TypeOfEvent";
            this.TypeOfEvent.Width = 80;
            // 
            // Venue
            // 
            this.Venue.DataPropertyName = "Venue";
            this.Venue.HeaderText = "Venue";
            this.Venue.Name = "Venue";
            // 
            // NoOfPersons
            // 
            this.NoOfPersons.DataPropertyName = "NoOfPersons";
            this.NoOfPersons.HeaderText = "No Of Persons";
            this.NoOfPersons.Name = "NoOfPersons";
            this.NoOfPersons.Width = 50;
            // 
            // EventTime
            // 
            this.EventTime.DataPropertyName = "EventTime";
            this.EventTime.HeaderText = "Time";
            this.EventTime.Name = "EventTime";
            this.EventTime.Width = 70;
            // 
            // EventDate
            // 
            this.EventDate.DataPropertyName = "EventDate";
            this.EventDate.HeaderText = "Date";
            this.EventDate.Name = "EventDate";
            // 
            // BookingDate
            // 
            this.BookingDate.DataPropertyName = "BookingDate";
            this.BookingDate.HeaderText = "Booking Date";
            this.BookingDate.Name = "BookingDate";
            // 
            // BookingBy
            // 
            this.BookingBy.DataPropertyName = "BookingBy";
            this.BookingBy.HeaderText = "Booked By";
            this.BookingBy.Name = "BookingBy";
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Amount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // View
            // 
            this.View.HeaderText = "Reciept View";
            this.View.Name = "View";
            this.View.Text = "View";
            this.View.UseColumnTextForButtonValue = true;
            this.View.Width = 50;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(771, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "bookings";
            this.Text = "bookings";
            this.Load += new System.EventHandler(this.bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Booking_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}