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
    public partial class frmRoloAccount : Form
    {
        public void LoadRoleAccount()
        {
                string connectionString = @"Data Source=DESKTOP-CU4CFCO\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "select * from RoleAccount";

                sqlConnection.Open();

                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

                DataTable dt = new DataTable("RoleAccount");
                da.Fill(dt);

                dgvRoleAccount.DataSource = dt;

                sqlConnection.Close();
                sqlConnection.Dispose();
                da.Dispose();
        }
        public frmRoloAccount()
        {
            InitializeComponent();
            LoadRoleAccount();
        }

        private void dgvRoleAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvRoleAccount.CurrentRow.Index;
            txtRoleID.Text = dgvRoleAccount.Rows[i].Cells[0].Value.ToString();
            txtAccountName.Text = dgvRoleAccount.Rows[i].Cells[1].Value.ToString();
            txtActived.Text = dgvRoleAccount.Rows[i].Cells[2].Value.ToString();
            txtNotes.Text = dgvRoleAccount.Rows[i].Cells[3].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-CU4CFCO\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "insert into RoleAccount values('" + txtRoleID.Text + "','" + txtAccountName.Text + "', '" + txtActived.Text + "', '" + txtNotes.Text + "')";

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm vai trò thành công");

                LoadRoleAccount();

                txtRoleID.Text = "";
                txtAccountName.Text = "";
                txtActived.Text = "";
                txtNotes.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xẩy ra. Vui lòng thử lại");
            }
        }

        private void btnUppdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-CU4CFCO\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "update RoleAccount set AccountName = N'" + txtAccountName.Text + "', Actived = " + txtActived.Text + "', Notes = " + txtNotes.Text + "where RoleID = " + txtRoleID.Text;

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
    }
}
