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
    public partial class FormProductsEdit : Form
    {


        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> list商品名稱 = new List<string>();
        List<int> list商品價格 = new List<int>();
        List<int> listId = new List<int>();
        public FormProductsEdit()
        {
            InitializeComponent();
        }

        private void FormProductsEdit_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBconnectionString = scsb.ConnectionString.ToString();

            讀取商品資料庫();
            ShowListViewEdit();

        }

        void 讀取商品資料庫()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string strSQL = "select top 200 * from YuNSproducts;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {


                listId.Add((int)reader["id"]);
                list商品名稱.Add((string)reader["pname"]);
                list商品價格.Add((int)reader["price"]);
                string image_name = (string)reader["pimage"];
                string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑);
                Image img商品圖檔 = Image.FromStream(fs);

                imageListProducts.Images.Add(img商品圖檔);
                fs.Close();

                count++;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }

        void ShowListViewEdit()
        {
            listViewEdit.Clear();
            listViewEdit.View = View.LargeIcon;
            imageListProducts.ImageSize = new Size(120, 120);
            listViewEdit.LargeImageList = imageListProducts;
            listViewEdit.SmallImageList = imageListProducts;


            for (int i = 0; i < listId.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{list商品名稱[i]}\r\n{list商品價格[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = listId[i];
                listViewEdit.Items.Add(item);
            }
        }

        void 重新載入資料()
        {
            listId.Clear();
            list商品價格.Clear();
            list商品名稱.Clear();
            imageListProducts.Images.Clear();
            讀取商品資料庫();

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormDetail myFormDetail = new FormDetail();
            myFormDetail.Show();
            Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            重新載入資料();
        }

        private void listViewEdit_ItemActivate(object sender, EventArgs e)
        {
            FormDetail myFormDetail = new FormDetail();

            myFormDetail.loadId = (int)listViewEdit.SelectedItems[0].Tag;
            myFormDetail.Show();
            Hide();

        }

        private void FormProductsEdit_Activated(object sender, EventArgs e)
        {
            重新載入資料();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
           
            Hide();
        }
    }
}
