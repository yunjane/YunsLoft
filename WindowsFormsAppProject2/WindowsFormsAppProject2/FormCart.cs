using System;
using System.Collections;
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
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            

            foreach (ArrayList Product in GlobalVar.list訂購品項集合)
            {
                string Pname = (string)Product[0];
                int SinPrice = (int)Product[1];
                int Num = (int)Product[2];               
                int PtPrice = (int)Product[3];

                PtPrice = SinPrice * Num;
                

                lBoxOrder.Items.Add($"{Pname} {SinPrice} TWD  x {Num} Total Price: {PtPrice} TWD");
                
                計算訂單總價();
                
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

            lblTPrice.Text = $"Total Price: {TPrice} TWD";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lBoxOrder.Items.Clear();
            GlobalVar.list訂購品項集合.Clear();
            計算訂單總價();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
             if (lBoxOrder.SelectedIndex >= 0)
            {
                int selectedIdx = lBoxOrder.SelectedIndex;
                lBoxOrder.Items.RemoveAt(selectedIdx);
                GlobalVar.list訂購品項集合.RemoveAt(selectedIdx);
                計算訂單總價();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
           
            Hide();
        }

        private void btnKeep_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Hide();
            Hide();
        }

        private void btnChekOut_Click(object sender, EventArgs e)
        {
            if (lBoxOrder.Items.Count > 0)
            {
                
                FormBill bill = new FormBill();
                bill.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("The cart is empty now!!");
            }
            

        }
    }
}
