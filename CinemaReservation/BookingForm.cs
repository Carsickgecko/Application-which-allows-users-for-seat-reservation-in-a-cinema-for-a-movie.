using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaReservation
{
    public partial class BookingForm : Form
    {
        private string connectionString = @"Data Source=MANHDZ\SQLEXPRESS;Initial Catalog = CinemaReservationDB; Integrated Security = True";

        public BookingForm()
        {
            InitializeComponent();
           
        }
        private void lvMovies_ItemActivate(object sender, EventArgs e)
        {
            if (lvMovies.SelectedItems.Count > 0)
            {
                
                string movieName = lvMovies.SelectedItems[0].Text;

                
                MethodUsing.GlobalData.ok = movieName;

               
                InformationBook infoForm = new InformationBook();
                infoForm.Show();
            }
        }

        private void lvMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbHello_Click(object sender, EventArgs e)
        {
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            lbHello.Text = "Hello, " +MethodUsing.GlobalData.nameout;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}