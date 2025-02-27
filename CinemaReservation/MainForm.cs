using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaReservation
{
    public partial class MainForm : Form
    {
        private string connectionString = @"Data Source=MANHDZ\SQLEXPRESS;Initial Catalog = CinemaReservationDB; Integrated Security = True";

        public MainForm()
        {
            InitializeComponent();
            //LoadReservations();
        }

        //private void LoadReservations()
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Reservations", conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
                
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Logic to add a reservation
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Logic to edit a reservation
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Logic to delete a reservation
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}