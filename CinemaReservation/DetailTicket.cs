using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaReservation
{
    public partial class DetailTicket : Form
    {
        public DetailTicket()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DetailTicket_Load(object sender, EventArgs e)
        {
            txbMovieName.Text = MethodUsing.GlobalData.ok;
            txbCustomerName.Text = MethodUsing.GlobalData.nameout;
            txbSeat.Text = string.Join(", ", MethodUsing.GlobalData.selectedSeats);
            txbCodeTicket.Text = GenerateTicketCode();
        }

        private string GenerateTicketCode()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Chữ cái và số
            StringBuilder ticketCode = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                ticketCode.Append(chars[random.Next(chars.Length)]);
            }

            return ticketCode.ToString();
        }
    }
}
