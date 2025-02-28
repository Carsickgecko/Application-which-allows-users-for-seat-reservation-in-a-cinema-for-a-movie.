namespace CinemaReservation
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lvMovies;
        private System.Windows.Forms.ColumnHeader chMovieName;
        private System.Windows.Forms.ColumnHeader chShowTime;

        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Avengers: Endgame", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "120 Mins", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0))))}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Captain America: Brave New World ",
            "90 Mins"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Spider-Man: No Way HomeSpider-Man: No Way Home",
            "180 Mins"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.lvMovies = new System.Windows.Forms.ListView();
            this.chMovieName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chShowTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvMovies
            // 
            this.lvMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMovieName,
            this.chShowTime});
            this.lvMovies.FullRowSelect = true;
            this.lvMovies.HideSelection = false;
            this.lvMovies.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvMovies.Location = new System.Drawing.Point(4, 72);
            this.lvMovies.Margin = new System.Windows.Forms.Padding(4);
            this.lvMovies.Name = "lvMovies";
            this.lvMovies.Size = new System.Drawing.Size(614, 167);
            this.lvMovies.TabIndex = 0;
            this.lvMovies.UseCompatibleStateImageBehavior = false;
            this.lvMovies.View = System.Windows.Forms.View.Details;
            this.lvMovies.ItemActivate += new System.EventHandler(this.lvMovies_ItemActivate);
            this.lvMovies.SelectedIndexChanged += new System.EventHandler(this.lvMovies_SelectedIndexChanged);
            // 
            // chMovieName
            // 
            this.chMovieName.Text = "Movie Name";
            this.chMovieName.Width = 350;
            // 
            // chShowTime
            // 
            this.chShowTime.Text = "Show Time";
            this.chShowTime.Width = 180;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(93, 255);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(405, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.Location = new System.Drawing.Point(28, 25);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(54, 20);
            this.lbHello.TabIndex = 3;
            this.lbHello.Text = "label1";
            this.lbHello.Click += new System.EventHandler(this.lbHello_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 351);
            this.Controls.Add(this.lbHello);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lvMovies);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingForm";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbHello;
    }
}