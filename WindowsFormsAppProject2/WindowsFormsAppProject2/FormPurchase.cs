using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YunsLoft
{
    public partial class FormPurchase : Form
    {
        int Num = 0;
        public int LoadId = 0;
        string str修改後的圖檔名稱 = "";
        string Pname = "";
        int TPrice = 0;
        public int SinPrice = 0;
        int status = 0;




        public FormPurchase()
        {
            InitializeComponent();
        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {

            ShowProductInfo();

            Num = 1;
            txtNum.Text = Num.ToString();
            Pname = lblPname.Text;
            TPrice = SinPrice * Num;
            SinPrice = Convert.ToInt32(lblPrice.Text);

            
            lblReminder.Visible = false;

        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            Num = Num + 1;

            if (Num < 100)
            {
                txtNum.Text = Num.ToString();
            }
            else
            {
                MessageBox.Show("The number is over limit.");
            }

        }

        private void btnMinor_Click(object sender, EventArgs e)
        {
            Num = Num - 1;

            if (Num > 0)
            {
                txtNum.Text = Num.ToString();
            }
            else
            {
                MessageBox.Show("Please fill correct number");
                Num = 1;
                txtNum.Text = Num.ToString();
            }
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            if ((LoadId >= 0) && (Num < 100))
            {
                ArrayList Product = new ArrayList();
                Product.Add(Pname);
                Product.Add(SinPrice);
                Product.Add(Num);
                Product.Add(TPrice);
                Product.Add(status);

                GlobalVar.list訂購品項集合.Add(Product);

                MessageBox.Show("Selected items have been added!");

            } 
            else if (status == 0)
            {
                lblReminder.Visible = true;
            }
            else if (Num > 100)
            {
                MessageBox.Show("The number is over limit.");
            }         
            else
            {
                MessageBox.Show("Please selected items first.");
            }

        }


        void ShowProductInfo()
        {
            if (LoadId > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string strSQL = "select * from YuNSproducts where id = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", LoadId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblID.Text = reader["id"].ToString();
                    lblPname.Text = reader["pname"].ToString();
                    lblPrice.Text = reader["price"].ToString();
                    str修改後的圖檔名稱 = reader["pimage"].ToString();
                    string str完整圖檔路徑 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱}";
                    System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                    pictureBoxChair.Image = Image.FromStream(fs);
                    fs.Close();
                    pictureBoxChair.Tag = str完整圖檔路徑;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            Hide();
        }


        //void 判斷status()
        //{
        //    if (LoadId > 0)
        //    {
        //        SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
        //        con.Open();
        //        string strSQL = "select \"商品狀態\" from YuNSproducts where id = @SearchId";
        //        SqlCommand cmd = new SqlCommand(strSQL, con);
        //        cmd.Parameters.AddWithValue("@SearchId", LoadId);
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        if ()
        //        {
        //            lblID.Text = reader["id"].ToString();
        //            lblPname.Text = reader["pname"].ToString();
        //            lblPrice.Text = reader["price"].ToString();
        //            str修改後的圖檔名稱 = reader["pimage"].ToString();
        //            string str完整圖檔路徑 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱}";
        //            System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
        //            pictureBoxChair.Image = Image.FromStream(fs);
        //            fs.Close();
        //            pictureBoxChair.Tag = str完整圖檔路徑;
        //        }
        //    }
        //}











    }
}
