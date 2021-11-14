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
    public partial class frmNewFood : Form
    {
       
        public frmNewFood()
        {
            InitializeComponent();
        }

        private void frmNewFood_Load(object sender, EventArgs e)
        {

        }

        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-CU4CFCO\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "insert into Category(Name, [Type])" + "values(N'" + txtName.Text + "'," + txtType.Text + ")";

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm nhóm món ăn thành công");

                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xẩy ra. Vui lòng thử lại");
            }
        }
    }
}
