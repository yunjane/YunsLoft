namespace YunsLoft
{
    partial class FormPurchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxChair = new System.Windows.Forms.PictureBox();
            this.lblPname = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCar = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinor = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblReminder = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChair)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxChair
            // 
            this.pictureBoxChair.Location = new System.Drawing.Point(49, 113);
            this.pictureBoxChair.Name = "pictureBoxChair";
            this.pictureBoxChair.Size = new System.Drawing.Size(346, 308);
            this.pictureBoxChair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChair.TabIndex = 0;
            this.pictureBoxChair.TabStop = false;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPname.Location = new System.Drawing.Point(414, 113);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(167, 29);
            this.lblPname.TabIndex = 1;
            this.lblPname.Text = "Product Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(418, 159);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(110, 26);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "$   Price   ";
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(423, 377);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(272, 44);
            this.btnCar.TabIndex = 4;
            this.btnCar.Text = "Add to Car";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(467, 260);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 30);
            this.txtNum.TabIndex = 5;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(573, 257);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(38, 33);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinor
            // 
            this.btnMinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinor.Location = new System.Drawing.Point(423, 257);
            this.btnMinor.Name = "btnMinor";
            this.btnMinor.Size = new System.Drawing.Size(38, 33);
            this.btnMinor.TabIndex = 7;
            this.btnMinor.Text = "-";
            this.btnMinor.UseVisualStyleBackColor = true;
            this.btnMinor.Click += new System.EventHandler(this.btnMinor_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(55, 71);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 26);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.ForeColor = System.Drawing.Color.Brown;
            this.lblReminder.Location = new System.Drawing.Point(493, 443);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(202, 20);
            this.lblReminder.TabIndex = 9;
            this.lblReminder.Text = "This product is out of stock!";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(640, 62);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 35);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 668);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnMinor);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.pictureBoxChair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPurchase";
            this.Load += new System.EventHandler(this.FormPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxChair;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinor;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Button btnBack;
    }
}