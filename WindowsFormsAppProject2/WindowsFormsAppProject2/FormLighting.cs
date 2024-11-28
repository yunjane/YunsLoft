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
    public partial class FormLighting : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> list商品名稱 = new List<string>();
        List<int> list商品價格 = new List<int>();
        List<int> listId = new List<int>();
        List<string> listCategory = new List<string>();
      

        public FormLighting()
        {
            InitializeComponent();
        }

        private void FormLighting_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBconnectionString = scsb.ConnectionString.ToString();

            讀取商品資料庫();
            ShowListViewLighting();
        }
        

        void 讀取商品資料庫()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string strSQL = "select top 200 * from YuNSproducts where category = 'Lighting';";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {


                listId.Add((int)reader["id"]);
                list商品名稱.Add((string)reader["pname"]);
                list商品價格.Add((int)reader["price"]);
                listCategory.Add((string)reader["category"]);              
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
         
        #region ShowChPic
        void ShowListViewLighting()
        {
            listViewLighting.Clear();
            listViewLighting.View = View.LargeIcon;
            imageListProducts.ImageSize = new Size(120, 120);
            listViewLighting.LargeImageList = imageListProducts;
            listViewLighting.SmallImageList = imageListProducts;                      
                     
                for (int i = 0; i < listId.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    item.Text = $"{list商品名稱[i]}\r\n{list商品價格[i]}元";
                    item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                    item.Tag = listId[i];
                    listViewLighting.Items.Add(item);
                }            
           
        }
        #endregion

        private void listViewLighting_ItemActivate(object sender, EventArgs e)
        {
            FormPurchase purchase = new FormPurchase();
            purchase.LoadId = (int)listViewLighting.SelectedItems[0].Tag;
            purchase.SinPrice = (int)listViewLighting.SelectedItems[0].Tag;
            purchase.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            
            Hide();
        }
    }
}

