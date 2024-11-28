using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YunsLoft
{
    public partial class FormBill : Form
    {

        public int LoadId = 0;
        public FormBill()
        {
            InitializeComponent();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            

            foreach (ArrayList Product in GlobalVar.list訂購品項集合)
            {
                string Pname = (string)Product[0];
                int SinPrice = (int)Product[1];
                int Num = (int)Product[2];
                int PtPrice = (int)Product[3];

                PtPrice = SinPrice * Num;


                lBoxBillInfo.Items.Add($"{Pname} {SinPrice} TWD  x {Num} Total Price: {PtPrice} TWD");

                計算訂單總價();
                

            }


            lblId.Text = $"id:{GlobalVar.使用者id.ToString()}";
            自動顯示會員資訊();



        }
        

        void 自動顯示會員資訊()
        {
            if (GlobalVar.使用者角色 == 2 && lblInfo.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string strSQL = "select * from YuNScustomer where id=@SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", GlobalVar.使用者id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    
                    txtName.Text = reader["name"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtAddress.Text = reader["adress"].ToString();
                }
            }

        }

        void 計算訂單總價()
        {
            int TPrice = 0;

            foreach (ArrayList Product in GlobalVar.list訂購品項集合)
            {
                string Pname = (string)Product[0];
                int SinPrice = (int)Product[1];
                int Num = (int)Product[2];
                int PtPrice = (int)Product[3];

                PtPrice = SinPrice * Num;


                TPrice += PtPrice;
            }

            
        }



        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            FormCart formCart = new FormCart();
            formCart.Show();
            Hide();
        }

        

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            

            if ((txtName.Text != "" && txtEmail.Text != "" && txtCard.Text != "" && txtAddress.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string strSQL = "insert into YuNSorderList values (@Newordernum, @Newname, @Newemail, @Newaddress, @Neworderinfo);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Newordernum", $"A{DateTime.Now.ToString("yyMMddHHmm")}");
                cmd.Parameters.AddWithValue("@Newname", txtName.Text);
                cmd.Parameters.AddWithValue("@Newemail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Newaddress", txtAddress.Text);             
                cmd.Parameters.AddWithValue("@Neworderinfo", lBoxBillInfo.Items[0]);
               
                int rows = cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("The pay is succeed!");
                
                計算訂單總價();
                GlobalVar.list訂購品項集合.Clear();
                Close();
            }                   
            else
            {
                MessageBox.Show("Please fill information above first.");
            }


        }
    }
}
