namespace CinemaReservation
{
    partial class DetailTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.txbMovieName = new System.Windows.Forms.TextBox();
            this.txbCodeTicket = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txbSeat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seat Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code Ticket";
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Location = new System.Drawing.Point(307, 57);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.ReadOnly = true;
            this.txbCustomerName.Size = new System.Drawing.Size(322, 22);
            this.txbCustomerName.TabIndex = 4;
            this.txbCustomerName.TextChanged += new System.EventHandler(this.txbCustomerName_TextChanged);
            // 
            // txbMovieName
            // 
            this.txbMovieName.Location = new System.Drawing.Point(307, 118);
            this.txbMovieName.Name = "txbMovieName";
            this.txbMovieName.ReadOnly = true;
            this.txbMovieName.Size = new System.Drawing.Size(322, 22);
            this.txbMovieName.TabIndex = 5;
            // 
            // txbCodeTicket
            // 
            this.txbCodeTicket.Location = new System.Drawing.Point(307, 223);
            this.txbCodeTicket.Name = "txbCodeTicket";
            this.txbCodeTicket.ReadOnly = true;
            this.txbCodeTicket.Size = new System.Drawing.Size(322, 22);
            this.txbCodeTicket.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(326, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(133, 41);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txbSeat
            // 
            this.txbSeat.Location = new System.Drawing.Point(307, 169);
            this.txbSeat.Name = "txbSeat";
            this.txbSeat.ReadOnly = true;
            this.txbSeat.Size = new System.Drawing.Size(322, 22);
            this.txbSeat.TabIndex = 8;
            // 
            // DetailTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSeat);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txbCodeTicket);
            this.Controls.Add(this.txbMovieName);
            this.Controls.Add(this.txbCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailTicket";
            this.Text = "DetailTicket";
            this.Load += new System.EventHandler(this.DetailTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.TextBox txbMovieName;
        private System.Windows.Forms.TextBox txbCodeTicket;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txbSeat;
    }
}