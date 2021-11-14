
namespace WindowsFormsApp1
{
    partial class frmOrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongDT = new System.Windows.Forms.Label();
            this.btnXemHDNgay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn ngày:";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(98, 9);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(153, 22);
            this.dtpNgayBD.TabIndex = 2;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 37);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(602, 391);
            this.dgvHoaDon.TabIndex = 4;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            this.dgvHoaDon.DoubleClick += new System.EventHandler(this.dgvHoaDon_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng doang thu:";
            // 
            // lblTongDT
            // 
            this.lblTongDT.AutoSize = true;
            this.lblTongDT.Location = new System.Drawing.Point(131, 441);
            this.lblTongDT.Name = "lblTongDT";
            this.lblTongDT.Size = new System.Drawing.Size(20, 17);
            this.lblTongDT.TabIndex = 6;
            this.lblTongDT.Text = "...";
            // 
            // btnXemHDNgay
            // 
            this.btnXemHDNgay.Location = new System.Drawing.Point(281, 8);
            this.btnXemHDNgay.Name = "btnXemHDNgay";
            this.btnXemHDNgay.Size = new System.Drawing.Size(180, 23);
            this.btnXemHDNgay.TabIndex = 7;
            this.btnXemHDNgay.Text = "Xem Hóa đơn theo ngày";
            this.btnXemHDNgay.UseVisualStyleBackColor = true;
            this.btnXemHDNgay.Click += new System.EventHandler(this.btnXemHDNgay_Click);
            // 
            // frmOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 467);
            this.Controls.Add(this.btnXemHDNgay);
            this.Controls.Add(this.lblTongDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.label1);
            this.Name = "frmOrdersForm";
            this.Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTongDT;
        private System.Windows.Forms.Button btnXemHDNgay;
    }
}