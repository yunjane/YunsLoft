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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace YunsLoft
{
    public partial class FormDetail : Form
    {
        

        public int loadId = 0;
        string str修改後的圖檔名稱 = "";
        bool is修改圖檔 = false;

        public FormDetail()
        {
            InitializeComponent();
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            

            Console.WriteLine($"loadId: {loadId}");

            if (loadId == 0)
            { //新增模式
                txtID.Visible = false;
                btnSaveEdit.Visible = false;
                btnDelete.Visible = false;
                btnChangePic.Visible = false;
            }
            else
            { //修改模式
                btnUploadPic.Visible = false;
                btnEditAdd.Visible = false;
                btnReset.Visible = false;
                顯示商品詳細資訊();
            }
        }

        void 顯示商品詳細資訊()
        {
            if (loadId > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string strSQL = "select * from YuNSproducts where id = @Id";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Id", loadId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtID.Text = reader["id"].ToString();
                    txtPname.Text = reader["pname"].ToString();
                    txtPrice.Text = reader["price"].ToString();
                    txtCategory.Text = reader["category"].ToString();
                    txtStatus.Text = reader["商品狀態"].ToString();
                    str修改後的圖檔名稱 = reader["pimage"].ToString();
                    string str完整圖檔路徑 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱}";
                    System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                    pBoxProduct.Image = Image.FromStream(fs);
                    fs.Close();
                    pBoxProduct.Tag = str完整圖檔路徑;
                }

                reader.Close();
                con.Close();
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if ((txtPname.Text != "") && (txtPrice.Text != "") &&  (pBoxProduct.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string strSQL = "update YuNSproducts set pname=@NewPname, price=@NewPrice, category=@Newcategory, \"商品狀態\"=@New商品狀態, pimage=@NewPimage where id=@SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", loadId);
                cmd.Parameters.AddWithValue("@NewPname", txtPname.Text);
                cmd.Parameters.AddWithValue("@Newcategory", txtCategory.Text);
                cmd.Parameters.AddWithValue("@New商品狀態", txtStatus.Text);
                int intPrice = 0;
                Int32.TryParse(txtPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);               
                cmd.Parameters.AddWithValue("@NewPimage", str修改後的圖檔名稱);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (is修改圖檔 == true)
                {
                    string str完整檔案路徑 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱}";
                    pBoxProduct.Tag = str完整檔案路徑;
                    pBoxProduct.Image.Save(str完整檔案路徑);
                    is修改圖檔 = false;
                }

                MessageBox.Show($"資料修改成功, 影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("所有欄位必填!");
            }
        }

        void 選取商品圖片()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(JPEG, JPG, PNG)|*.jpeg;*.jpg;*.png";

            DialogResult R = ofd.ShowDialog();

            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pBoxProduct.Image = Image.FromStream(fs);
                pBoxProduct.Tag = ofd.FileName;
                string str圖檔副檔名 = System.IO.Path.GetExtension(ofd.SafeFileName).ToLower();
                Random myRnd = new Random();
                str修改後的圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + str圖檔副檔名;
                //str修改後的圖檔名稱 = ofd.FileName.ToString() + str圖檔副檔名;
                is修改圖檔 = true;
                Console.WriteLine(str修改後的圖檔名稱);
                fs.Close();
            }
        }

        void 清空欄位()
        {
            txtID.Clear();
            txtPname.Clear();            
            txtPrice.Clear();
            pBoxProduct.Image = null;
        }


        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txtID.Text, out intId);

            if (intId > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string strSQL = "delete from YuNSproducts where id = @DeleteId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteId", intId);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                System.IO.File.Delete(pBoxProduct.Tag.ToString());
                清空欄位();

                MessageBox.Show($"Data have been deleted\n {rows}row(s) have been completed.");

            }
        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            if ((txtPname.Text != "") && (txtPrice.Text != "") && (pBoxProduct.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string strSQL = "insert into YuNSproducts values (@NewPname, @NewPrice, @Newcategory, @New商品狀態, @NewPimage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", loadId);
                cmd.Parameters.AddWithValue("@NewPname", txtPname.Text);
                cmd.Parameters.AddWithValue("@New商品狀態", txtStatus.Text);                
                cmd.Parameters.AddWithValue("@Newcategory",txtCategory.Text);
                int intPrice = 0;
                Int32.TryParse(txtPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPimage", str修改後的圖檔名稱);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (is修改圖檔 == true)
                {
                    string str完整檔案路徑 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱}";
                    pBoxProduct.Tag = str完整檔案路徑;
                    pBoxProduct.Image.Save(str完整檔案路徑);
                    is修改圖檔 = false;
                }

                MessageBox.Show($"Data have been created, {rows}row(s) have been successfully added .");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormProductsEdit edit = new FormProductsEdit();
            edit.Show();
            Hide();
        }
    }
}
