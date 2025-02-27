using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaReservation
{
    public partial class SeatSelectionForm : Form
    {
        private string connectionString = @"Data Source=MANHDZ\SQLEXPRESS;Initial Catalog = CinemaReservationDB; Integrated Security = True";
        private string movieName;
        private string showTime;

        public SeatSelectionForm(string movieName, string showTime)
        {
            InitializeComponent();
            this.movieName = movieName;
            this.showTime = showTime;
            LoadMovieDetails();
        }

        private void LoadMovieDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Reservations WHERE MovieName=@MovieName AND ShowTime=@ShowTime";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieName", movieName);
                cmd.Parameters.AddWithValue("@ShowTime", showTime);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblMovieName.Text = "Movie Name: " + reader["MovieName"].ToString();
                    lblShowTime.Text = "Show Time: " + reader["ShowTime"].ToString();
                    lblShowDate.Text = "Show Date: " + reader["ShowDate"].ToString();
                    lblRoom.Text = "Room: " + reader["Room"].ToString();
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Reservations (MovieName, ShowTime, ShowDate, SeatNumber, Room) VALUES (@MovieName, @ShowTime, @ShowDate, @SeatNumber, @Room)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieName", movieName);
                cmd.Parameters.AddWithValue("@ShowTime", showTime);
                cmd.Parameters.AddWithValue("@ShowDate", dtpShowDate.Value);
                cmd.Parameters.AddWithValue("@SeatNumber", txtSeatNumber.Text);
                cmd.Parameters.AddWithValue("@Room", lblRoom.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seat reserved successfully!");
                this.Close();
            }
        }
    }
}