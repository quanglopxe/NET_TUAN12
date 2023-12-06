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

namespace KT_THU
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=A209PC38;Initial Catalog=QLHN;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            load_cbo();
            conn.Open();
        }

        private void Show()
        {
            string sql = "select * from HoiNghi";
            da = new SqlDataAdapter(sql,conn);
            dt = new DataTable();
            da.Fill(dt);
            dtgv_HN.DataSource = dt;
            txt_maHN.Clear();
            txt_tenHN.Clear();
            txt_soLuong.Clear();
        }
        private void load_cbo()
        {
            string sql = "select * from LoaiPhong";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            cbo_loaiPH.DataSource = dt;
            cbo_loaiPH.DisplayMember = "tenLoaiPhong";
            cbo_loaiPH.ValueMember = "maLoaiPhong";
        }
        private string Them(string maHN, string tenHN, int soNguoi, string maLoai)
        {
            string sql = "insert into HoiNghi values ('" + maHN + "','" + tenHN + "'," + soNguoi + ",'" + maLoai + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
                MessageBox.Show("Trùng mã hội nghị!");
            return sql;
        }
        private string Xoa(string maHN)
        {
            string sql = "delete from HoiNghi where maHoiNghi = '" + maHN + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
                MessageBox.Show("Không tìm thấy hội nghị để xóa");
            return sql;
        }
        private string Loc(string maPH)
        {
            string sql = "select * from HoiNghi where maLoaiPhong = '" + maPH + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Lọc thành công!");
            }
            else
                MessageBox.Show("Không tìm thấy mã phòng để lọc");
            return sql;
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_maHN.Clear();
            txt_tenHN.Clear();
            txt_soLuong.Clear();
            cbo_loaiPH.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maHN = txt_maHN.Text;
            string tenHN = txt_tenHN.Text;
            int soNguoi = int.Parse(txt_soLuong.Text);
            string maLoai = cbo_loaiPH.SelectedValue.ToString();
            string sql = "select count(*) from HoiNghi where maHoiNghi = '" + maHN + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int countRow = (int)cmd.ExecuteScalar();
            if (countRow == 0)
            {
                Them(maHN, tenHN, soNguoi, maLoai);
                Show();
            }
        }

        private void dtgv_HN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dtgv_HN.Rows[e.RowIndex];
                txt_maHN.Text = row.Cells[0].Value.ToString();
                txt_tenHN.Text = row.Cells[1].Value.ToString();
                txt_soLuong.Text = row.Cells[2].Value.ToString();
                cbo_loaiPH.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
                txt_maHN.Clear();
                txt_tenHN.Clear();
                txt_soLuong.Clear();
                cbo_loaiPH.Text = "";
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maHN = txt_maHN.Text;
            da = new SqlDataAdapter(Xoa(maHN), conn);
            da.Fill(dt);
            dtgv_HN.DataSource = dt;
            Show();
            txt_maHN.Clear();
            txt_tenHN.Clear();
            txt_soLuong.Clear();
            cbo_loaiPH.Text = "";
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            string maPH = cbo_loaiPH.SelectedValue.ToString();
            da = new SqlDataAdapter(Loc(maPH), conn);
            da.Fill(dt);
            dtgv_HN.DataSource = dt;
            Show();
        }
    }
}
