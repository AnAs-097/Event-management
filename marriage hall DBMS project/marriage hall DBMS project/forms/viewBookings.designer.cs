namespace Dbms_new_project
{
    partial class viewBookings
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
            this.TypeOfEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfPersons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Booking_ID,
            this.TypeOfEvent,
            this.Venue,
            this.NoOfPersons,
            this.EventTime,
            this.EventDate,
            this.BookingBy,
            this.TotalAmount});
            this.dataGridView1.Location = new System.Drawing.Point(2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 474);
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
            // TypeOfEvent
            // 
            this.TypeOfEvent.DataPropertyName = "type";
            this.TypeOfEvent.HeaderText = "Type Of Event";
            this.TypeOfEvent.Name = "TypeOfEvent";
            this.TypeOfEvent.Width = 80;
            // 
            // Venue
            // 
            this.Venue.DataPropertyName = "hall_no";
            this.Venue.HeaderText = "Venue";
            this.Venue.Name = "Venue";
            // 
            // NoOfPersons
            // 
            this.NoOfPersons.DataPropertyName = "no_of_guests";
            this.NoOfPersons.HeaderText = "No Of Persons";
            this.NoOfPersons.Name = "NoOfPersons";
            this.NoOfPersons.Width = 50;
            // 
            // EventTime
            // 
            this.EventTime.DataPropertyName = "event_time";
            this.EventTime.HeaderText = "Time";
            this.EventTime.Name = "EventTime";
            this.EventTime.Width = 70;
            // 
            // EventDate
            // 
            this.EventDate.DataPropertyName = "Event_Date";
            this.EventDate.HeaderText = "Date";
            this.EventDate.Name = "EventDate";
            // 
            // BookingBy
            // 
            this.BookingBy.DataPropertyName = "name";
            this.BookingBy.HeaderText = "Booked By";
            this.BookingBy.Name = "BookingBy";
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "amount";
            this.TotalAmount.HeaderText = "Amount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // viewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 318);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewBookings";
            this.Text = "Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Booking_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
    }
}