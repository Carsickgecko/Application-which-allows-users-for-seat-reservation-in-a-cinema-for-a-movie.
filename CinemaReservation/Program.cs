using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CinemaReservation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            //string connection = @"Data Source=MANHDZ\SQLEXPRESS;Initial Catalog = CinemaReservationDB; Integrated Security = True";
            //string sql = @"ALTER TABLE Movies ADD  NVARCHAR(50),Age INT;";
            //SqlConnection conn;
            //conn = new SqlConnection(connection);
            //conn.Open();
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();


        }
    }
}