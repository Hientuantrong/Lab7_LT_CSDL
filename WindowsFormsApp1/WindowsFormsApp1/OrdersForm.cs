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
    public partial class frmOrdersForm : Form
    {
        public void LoadBill()
        {
            string connectionString = @"Data Source=DESKTOP-CU4CFCO\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from Bills where CheckoutDate = @date";
            sqlCommand.Parameters.Add("@date", SqlDbType.DateTime);
            sqlCommand.Parameters["@date"].Value = DateTime.Parse(dtpNgayBD.Value.ToString("dd/MM/yyyy"));

            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable("Bills");
            da.Fill(dt);
            
            dgvHoaDon.DataSource = dt;

            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
        public frmOrdersForm()
        {
            InitializeComponent();
            LoadBill();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            string billsID = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
            if (billsID != "")
            {
                frmBillDetails foodForm = new frmBillDetails();
                foodForm.Show(this);
                foodForm.LoadBillDetails(Convert.ToInt32(billsID));
            }
        }

        private void btnXemHDNgay_Click(object sender, EventArgs e)
        {
            LoadBill();
        }
    }
}
