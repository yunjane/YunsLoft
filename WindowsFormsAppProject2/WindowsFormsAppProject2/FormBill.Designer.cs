namespace YunsLoft
{
    partial class FormBill
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lBoxBillInfo = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfo.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(97, 35);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(257, 51);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Purchase Info :";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPayNow
            // 
            this.btnPayNow.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(941, 606);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(174, 62);
            this.btnPayNow.TabIndex = 3;
            this.btnPayNow.Text = "Pay now";
            this.btnPayNow.UseVisualStyleBackColor = false;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(732, 606);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 62);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(375, 206);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(592, 35);
            this.txtEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 47);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(104, 339);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(592, 39);
            this.txtAddress.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 47);
            this.label3.TabIndex = 10;
            this.label3.Text = "Card No.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCard
            // 
            this.txtCard.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Location = new System.Drawing.Point(104, 475);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(592, 35);
            this.txtCard.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 47);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(104, 206);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 35);
            this.txtName.TabIndex = 11;
            // 
            // lBoxBillInfo
            // 
            this.lBoxBillInfo.FormattingEnabled = true;
            this.lBoxBillInfo.ItemHeight = 20;
            this.lBoxBillInfo.Location = new System.Drawing.Point(103, 584);
            this.lBoxBillInfo.Name = "lBoxBillInfo";
            this.lBoxBillInfo.Size = new System.Drawing.Size(499, 84);
            this.lBoxBillInfo.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(214, 153);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(45, 29);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id :";
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1196, 724);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lBoxBillInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayNow);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lBoxBillInfo;
        private System.Windows.Forms.Label lblId;
    }
}