using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DuongThuanQuang
{
    public partial class Form1 : Form
    {
        private fLogin flg;
        bool isExit = true;
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QL_SP;Integrated Security=True");
        DataSet ds_SP = new DataSet();
        SqlDataAdapter da;
        DataTable dt;
        public Form1(fLogin flg)
        {
            InitializeComponent();
            this.flg = flg;
            conn.Open();
        }

        private string Them(int maSP, string tenSP)
        {
            string sql = "insert into SANPHAM values (" + maSP + ",'" + tenSP + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
                MessageBox.Show("Trùng mã sản phẩm!");
            return sql;
        }
        private string Xoa(int maSP)
        {
            string sql = "delete from SANPHAM where MASP = '" + maSP + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
                MessageBox.Show("Không tìm thấy sản phẩm để xóa");
            return sql;
        }
        private string Sua(int maSP, string tenSP)
        {
            string sql = "update SANPHAM set MASP = " + maSP + ",TENSP = '" + tenSP + "' where MASP = '" + maSP + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
                MessageBox.Show("Không tìm thấy sản phẩm để sửa!");
            return sql;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            
            int maSP = int.Parse(txt_MaSP.Text);
            string tenSP = txt_TenSP.Text;
            string sql = "select count(*) from SANPHAM where MASP = '" + maSP + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int countRow = (int)cmd.ExecuteScalar();
            if (countRow == 0)
            {
                Them(maSP, tenSP);
            }
            txt_MaSP.Clear();
            txt_TenSP.Clear();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            string sql = "select * from SANPHAM";
            da = new SqlDataAdapter(sql,conn);
            dt = new DataTable();
            da.Fill(dt);
            dtgv_SP.DataSource = dt;
            txt_MaSP.Clear();
            txt_TenSP.Clear();
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
            int maSP = int.Parse(txt_MaSP.Text);
            da = new SqlDataAdapter(Xoa(maSP), conn);
            da.Fill(dt);
            dtgv_SP.DataSource = dt;
            txt_MaSP.Clear();
            txt_TenSP.Clear();
        }

        private void dtgv_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dtgv_SP.Rows[e.RowIndex];
                txt_MaSP.Text = row.Cells["MASP"].Value.ToString();
                txt_TenSP.Text = row.Cells["TENSP"].Value.ToString();
            }
            catch
            {
                txt_MaSP.Clear();
                txt_TenSP.Clear();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
            int maSP = int.Parse(txt_MaSP.Text);
            string tenSP = txt_TenSP.Text;
            da = new SqlDataAdapter(Sua(maSP, tenSP), conn);
            da.Fill(dt);
            dtgv_SP.DataSource = dt;
            txt_MaSP.Clear();
            txt_TenSP.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit == true)
                Application.Exit();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Hide();
            fLogin f = new fLogin();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (flg.GetUserRole() == 1)
            {
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
            }
        }

        

    }
}
