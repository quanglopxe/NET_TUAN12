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
    public partial class fLogin : Form
    {
        bool isExit = true;
        SqlConnection conn = new SqlConnection("Data Source=A209PC38;Initial Catalog=QL_SP;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public fLogin()
        {
            InitializeComponent();
            conn.Open();
        }

        public int GetUserRole()
        {
            string userName = txt_UserName.Text;
            int role = 0;
            string sql = "select ROLE from ACCOUNT where USERNAME = '" + userName + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr.Read())
                    role = rdr.GetInt32(0);
                rdr.Close();
            }
            return role;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string sql = "select * from ACCOUNT where USERNAME = '" + txt_UserName.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);

            int count = dt.Rows.Count;
            if (count > 0)
            {
                string userName = txt_UserName.Text;
                string password = txt_Password.Text;
                bool re_pw = rbtn_Remember.Checked;
                if (re_pw)
                {
                    userName = dt.Rows[0]["USERNAME"].ToString();
                    password = dt.Rows[0]["PASSWORD"].ToString();
                }
                if (userName == dt.Rows[0]["USERNAME"].ToString() && password == dt.Rows[0]["PASSWORD"].ToString())
                {
                    isExit = false;
                    this.Hide();
                    Form1 f = new Form1(this);
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                txt_UserName.Clear();
                txt_Password.Clear();
            }
        }

        private void fLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit == true)
            {
                Application.Exit();
                conn.Close();
            }
        }
    }
}
