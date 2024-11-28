namespace YunsLoft
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnChair = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnLighting = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1240, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "YuNS LOFT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnCloseForm.Location = new System.Drawing.Point(1174, 23);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(43, 39);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnChair
            // 
            this.btnChair.BackColor = System.Drawing.Color.White;
            this.btnChair.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChair.ForeColor = System.Drawing.Color.Black;
            this.btnChair.Location = new System.Drawing.Point(232, 340);
            this.btnChair.Name = "btnChair";
            this.btnChair.Size = new System.Drawing.Size(251, 156);
            this.btnChair.TabIndex = 2;
            this.btnChair.Text = "Chair\r\n";
            this.btnChair.UseVisualStyleBackColor = false;
            this.btnChair.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.DimGray;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(12, 18);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(202, 48);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Our Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCart
            // 
            this.btnCart.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Location = new System.Drawing.Point(781, 340);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(251, 156);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "Shopping Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnLighting
            // 
            this.btnLighting.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLighting.Location = new System.Drawing.Point(506, 340);
            this.btnLighting.Name = "btnLighting";
            this.btnLighting.Size = new System.Drawing.Size(251, 156);
            this.btnLighting.TabIndex = 6;
            this.btnLighting.Text = "Lighting";
            this.btnLighting.UseVisualStyleBackColor = true;
            this.btnLighting.Click += new System.EventHandler(this.btnLighting_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.DimGray;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(776, 33);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(130, 29);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "User name";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.White;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.Gray;
            this.lblAbout.Location = new System.Drawing.Point(145, 586);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(198, 32);
            this.lblAbout.TabIndex = 11;
            this.lblAbout.Text = "| About YuNS |";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(384, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "| Contact Us |";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(645, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "| Follow Us |";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(873, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "| Order Notification |";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(146, 645);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Investor Relations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(146, 685);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(385, 685);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "All times Eastern";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(385, 645);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "75 Middlesex Turnpike";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(646, 685);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Yt: YunsLoft Channel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(646, 645);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ins : yunLoFT1998_";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(885, 685);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Products Recalls";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(885, 645);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Return Policy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label13.Location = new System.Drawing.Point(29, 792);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(337, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Wayfair LLC, 4 Copley Place, 7th Floor, Boston";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DimGray;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(1055, 23);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 43);
            this.btnLogOut.TabIndex = 25;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DimGray;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(935, 23);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(112, 43);
            this.btnLogIn.TabIndex = 26;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 836);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnLighting);
            this.Controls.Add(this.btnChair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnChair;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnLighting;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnLogIn;
    }
}

