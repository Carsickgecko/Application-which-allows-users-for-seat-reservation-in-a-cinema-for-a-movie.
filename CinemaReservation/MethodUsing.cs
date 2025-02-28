using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaReservation
{
    public class MethodUsing
    {
        public static void Showpassword(System.Windows.Forms.CheckBox ckb, TextBox txb)
        {
            if (ckb.Checked)
            {
                txb.UseSystemPasswordChar = false;
            }
            else
            {
                txb.UseSystemPasswordChar = true;
            }
        }

        public static bool NullTxb(TextBox txb)
        {
            if (txb.Text == "")
            {
                return true;
                txb.Focus();
            }
            return false;
        }

        public static class GlobalData
        {
            
            public static string ok { get; set; }
            public static string nameout { get; set; }

            public static List<string> selectedSeats = new List<string>();

            public static string NameFilm { get; set; }
        }

        
    }
}
