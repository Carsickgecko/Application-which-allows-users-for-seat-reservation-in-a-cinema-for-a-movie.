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
            

            // Kết nối sự kiện SelectedIndexChanged
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị thời gian được chọn
            TimeSpan selectedTime = (TimeSpan)comboBox1.SelectedItem;

            // Gọi phương thức LoadSeats
            LoadSeats(selectedTime);

            // Hiển thị giá trị thời gian đã chọn lên label3
            
        }

        private void LoadSeats(TimeSpan selectedTime)
        {
            checkedListBox1.Items.Clear(); // Xóa dữ liệu cũ trong checkedListBox1

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
            // Lấy danh sách các ghế được chọn từ checkedListBox1
            List<string> selectedSeats = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedSeats.Add(item.ToString());
            }

            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu danh sách ghế đã chọn vào GlobalData để sử dụng ở các form khác
            MethodUsing.GlobalData.selectedSeats = selectedSeats;

            // Cập nhật cột Available trong SQL
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
                    cmd.Parameters.AddWithValue("@Time", comboBox1.SelectedItem.ToString()); // Sử dụng thời gian đã chọn từ comboBox1

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Đã cập nhật trạng thái ghế thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DetailTicket ticket = new DetailTicket();
            ticket.Show();
            this.Hide();
            // Làm mới danh sách ghế
            LoadSeats((TimeSpan)comboBox1.SelectedItem);
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
