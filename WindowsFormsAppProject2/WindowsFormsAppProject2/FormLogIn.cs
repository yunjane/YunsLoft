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

namespace YunsLoft
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;

            GlobalVar.strDBconnectionString = scsb.ConnectionString.ToString();
            radioBtnCus.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();

            if (GlobalVar.is登入成功 == true)
            {
                Close();
            }
           
             
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txtId.Text.Trim(), out intId);
            string strPassword = txtPassw.Text.Trim();


            if ((intId > 0) && (strPassword != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();

                string tableName = "";

                switch (GlobalVar.使用者角色)
                {
                    case 1:
                        tableName = "YuNSstaff";//  staff 1
                        break;
                    case 2:
                        tableName = "YuNScustomer";//  Member 2
                        break;
                    default:
                        break;

                }

                string strSQL = $"select * from {tableName} where id=@SearchId and password=@SearchPassword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", intId);
                cmd.Parameters.AddWithValue("@SearchPassword", strPassword);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //登入成功
                    GlobalVar.is登入成功 = true;
                    GlobalVar.使用者名稱 = reader["name"].ToString();
                    GlobalVar.使用者id = intId;                 
                    MessageBox.Show("successful user log in.");
                    GlobalVar.list訂購品項集合.Clear();
                    reader.Close();
                    con.Close();
                    this.Close();
                }

                if (GlobalVar.is登入成功 == false)
                {
                    MessageBox.Show("Please fill out the correct id or password!");
                }
                reader.Close();
                con.Close();




            }
            else
            {
                MessageBox.Show("The form is required to fill out.");
            }

        }

        private void FormLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVar.is登入成功)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void radioBtnCus_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.使用者角色 = 2;
            GlobalVar.使用者權限 = 100;

        }

        private void radioBtnStaff_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.使用者角色 = 1;
            GlobalVar.使用者權限 = 1;
        }
    }
    
}
