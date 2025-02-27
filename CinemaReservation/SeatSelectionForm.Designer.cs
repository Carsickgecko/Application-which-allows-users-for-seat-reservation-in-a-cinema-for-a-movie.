namespace CinemaReservation
{
    partial class SeatSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.DateTimePicker dtpShowDate;

        private void InitializeComponent()
        {
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.dtpShowDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(12, 9);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(67, 13);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "Movie Name";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Location = new System.Drawing.Point(12, 32);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(58, 13);
            this.lblShowTime.TabIndex = 1;
            this.lblShowTime.Text = "Show Time";
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Location = new System.Drawing.Point(12, 55);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(59, 13);
            this.lblShowDate.TabIndex = 2;
            this.lblShowDate.Text = "Show Date";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(12, 78);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Room";
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Location = new System.Drawing.Point(93, 98);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(200, 20);
            this.txtSeatNumber.TabIndex = 4;
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Location = new System.Drawing.Point(12, 101);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(69, 13);
            this.lblSeatNumber.TabIndex = 5;
            this.lblSeatNumber.Text = "Seat Number";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(218, 124);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 6;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // dtpShowDate
            // 
            this.dtpShowDate.Location = new System.Drawing.Point(93, 49);
            this.dtpShowDate.Name = "dtpShowDate";
            this.dtpShowDate.Size = new System.Drawing.Size(200, 20);
            this.dtpShowDate.TabIndex = 7;
            // 
            // SeatSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.dtpShowDate);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblSeatNumber);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblShowDate);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.lblMovieName);
            this.Name = "SeatSelectionForm";
            this.Text = "Seat Selection";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}