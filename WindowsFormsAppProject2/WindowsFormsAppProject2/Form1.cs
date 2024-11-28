using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YunsLoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            btnProducts.Visible = false;
            

            決定權限顯示功能();
        }



        void 決定權限顯示功能()
        {
            lblUserName.Text = $"{GlobalVar.使用者名稱}";

            if ((GlobalVar.使用者權限 > 0) && (GlobalVar.使用者權限 <= 10))
            {//staff
                btnProducts.Visible = true;
                           
            }          
            else if ((GlobalVar.使用者權限 >= 100) && (GlobalVar.使用者權限 < 200))
            {//會員

                btnProducts.Visible = false;
                
            }
            else
            {
                if (GlobalVar.使用者權限 == 0)
                {//訪客
                    btnProducts.Visible = false;
                   
                }
                else
                {

                }
            }
        }






        private void btnCloseForm_Click(object sender, EventArgs e)
        {           
            Close();
        }

       

        private void btnChair_Click(object sender, EventArgs e)
        {
            FormChair chair = new FormChair();
            chair.Show();
            Hide();
        }

        private void btnLighting_Click(object sender, EventArgs e)
        {
            FormLighting lighting = new FormLighting();
            lighting.Show();
            Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormProductsEdit edit = new FormProductsEdit();
            edit.Show();
            Hide() ;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            FormCart cart = new FormCart();
            cart.Show();
            Hide();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Form Activated");
            決定權限顯示功能();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            GlobalVar.list訂購品項集合.Clear();
            GlobalVar.is登入成功 = false;
            GlobalVar.使用者角色 = 0;
            GlobalVar.使用者權限 = 0;
            GlobalVar.使用者名稱 = "";
            GlobalVar.使用者id = 0;

            btnProducts.Visible = false;
           
            lblUserName.Text = "";

            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {           
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {

        }
    }
}
