using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaReservation
{
    public partial class InformationBook : Form
    {
        private string connectionString = @"Data Source=MANHDZ\SQLEXPRESS;Initial Catalog = CinemaReservationDB; Integrated Security = True";
        string tableName = MethodUsing.GlobalData.ok;

        public InformationBook()
        {
            InitializeComponent();
        }

        public List<TimeSpan> listTime = new List<TimeSpan>()
        {
            new TimeSpan(9, 30, 0),
            new TimeSpan(12, 0, 0),
            new TimeSpan(20, 0, 0)
        };

        private void InformationBook_Load(object sender, EventArgs e)
        {
            lbHello.Text = "Hello, " + MethodUsing.GlobalData.nameout;
            lbMoviename.Text = MethodUsing.GlobalData.ok;
            comboBox1.DataSource = listTime;
            

            
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TimeSpan selectedTime = (TimeSpan)comboBox1.SelectedItem;

            
            LoadSeats(selectedTime);

            
            
        }

        private void LoadSeats(TimeSpan selectedTime)
        {
            checkedListBox1.Items.Clear(); 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT Seatnumber
                    FROM [Avengers: Endgame]
                    WHERE Available = 'A' AND Time = @Time";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Time", selectedTime.ToString(@"hh\:mm\:ss"));

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string seatNumber = reader["Seatnumber"].ToString();
                    checkedListBox1.Items.Add(seatNumber);
                }

                reader.Close();
            }
        }

        
        private void btnConfirm_Click_1(object sender, EventArgs e)
        { 
            string tableName = MethodUsing.GlobalData.ok;
            
            List<string> selectedSeats = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedSeats.Add(item.ToString());
            }

            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("No seat has been selected!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            MethodUsing.GlobalData.selectedSeats = selectedSeats;

           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (string seat in selectedSeats)
                {
                    string query = @"
                UPDATE [Avengers: Endgame]
                SET Available = 'N'
                WHERE Seatnumber = @Seatnumber AND Time = @Time";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Seatnumber", seat);
                    cmd.Parameters.AddWithValue("@Time", comboBox1.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Your seat booking was successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DetailTicket ticket = new DetailTicket();
            ticket.Show();
            this.Hide();
            
            LoadSeats((TimeSpan)comboBox1.SelectedItem);
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
