using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaReservation
{
    public partial class RegisterForm : Form
    {
        private string connectionString = @"Data Source=MANHDZ\SQLEXPRESS;Initial Catalog = CinemaReservationDB; Integrated Security = True";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            // Kiểm tra độ dài của Username: từ 3 đến 20 ký tự
            if (txtUsername.Text.Length < 3 || txtUsername.Text.Length > 20)
            {
                MessageBox.Show("Username must be between 3 and 20 characters.");
                return;
            }

            // Kiểm tra độ dài của Name: từ 3 đến 20 ký tự
            if (txtName.Text.Length < 3 || txtName.Text.Length > 20)
            {
                MessageBox.Show("Name must be between 3 and 20 characters.");
                return;
            }

            // Kiểm tra điều kiện của Age: phải là số nguyên và nằm trong khoảng hợp lệ (ví dụ: từ 1 đến 120)
            int age;
            if (!int.TryParse(txtAge.Text, out age) || age < 1 || age > 120)
            {
                MessageBox.Show("Please enter a valid age between 1 and 120.");
                return;
            }

            // Kiểm tra độ dài của Password: từ 6 đến 10 ký tự
            if (txtPassword.Text.Length < 6 || txtPassword.Text.Length > 10)
            {
                MessageBox.Show("Password must be between 6 and 10 characters.");
                return;
            }

            // Kiểm tra xem Password có khớp với Confirm Password không
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra xem Username đã tồn tại trong cơ sở dữ liệu hay chưa
                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    int userCount = (int)checkCmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("This username already exists. Please choose a different username.");
                        return;
                    }
                }

                // Nếu Username chưa tồn tại, tiến hành đăng ký người dùng mới
                string query = "INSERT INTO Users (Username, Name, Age, Password) VALUES (@Username, @Name, @Age, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User registered successfully!");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}