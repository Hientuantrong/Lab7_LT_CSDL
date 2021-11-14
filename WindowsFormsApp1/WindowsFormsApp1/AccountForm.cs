using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAccountForm : Form
    {
        public void LoadAccount()
        {
            string connectionString = @"Data Source=DESKTOP-CU4CFCO\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from Account";

            sqlConnection.Open();

            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách xem danh sách tài khoản" + catName;

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable("Account");
            da.Fill(dt);

            dgvAccount.DataSource = dt;

            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
        public frmAccountForm()
        {
            InitializeComponent();
            LoadAccount();
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvAccount.CurrentRow.Index;
            txtTenTK.Text = dgvAccount.Rows[i].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvAccount.Rows[i].Cells[1].Value.ToString();
            txtTen.Text = dgvAccount.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = dgvAccount.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvAccount.Rows[i].Cells[4].Value.ToString();
            dtpNgayTao.Text = dgvAccount.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-CU4CFCO\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "insert into Account values('" + txtTenTK.Text + "','" + txtMatKhau.Text + "', '" + txtTen.Text + "', '" + txtEmail.Text + "', '" + txtSDT.Text + "', '" + dtpNgayTao.Text + "')";

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm tài khoản thành công");

                LoadAccount();

                txtTenTK.Text = "";
                txtMatKhau.Text = "";
                txtTen.Text = "";
                txtEmail.Text = "";
                txtSDT.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xẩy ra. Vui lòng thử lại");
            }
        }

        private void btnCapNhatTK_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-CU4CFCO\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "update Account set Password = N'" + txtMatKhau.Text + "', FullName = " + txtTen.Text + "', Email = " + txtEmail.Text + "', Tell = " + txtSDT.Text + "', DateCreated = " + dtpNgayTao.Text + "where AccountName = " + txtTenTK.Text;

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {

                MessageBox.Show("Cập nhật nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xẫy ra. Vui lòng thử lại");
            }
        }

        private void tsmXemDS_Click(object sender, EventArgs e)
        {
            frmRoloAccount roleAccount = new frmRoloAccount();
            roleAccount.ShowDialog();
        }
    }
}
