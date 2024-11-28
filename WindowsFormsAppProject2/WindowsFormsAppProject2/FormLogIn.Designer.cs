namespace YunsLoft
{
    partial class FormLogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnCus = new System.Windows.Forms.RadioButton();
            this.radioBtnStaff = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(217)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 65);
            this.label1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnClose.Location = new System.Drawing.Point(544, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(142, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(142, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(299, 192);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(211, 32);
            this.txtId.TabIndex = 4;
            // 
            // txtPassw
            // 
            this.txtPassw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassw.Location = new System.Drawing.Point(299, 241);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.PasswordChar = '⚫';
            this.txtPassw.Size = new System.Drawing.Size(211, 32);
            this.txtPassw.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(97, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(97, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(218, 428);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(149, 42);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnStaff);
            this.groupBox1.Controls.Add(this.radioBtnCus);
            this.groupBox1.Location = new System.Drawing.Point(147, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 66);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radioBtnCus
            // 
            this.radioBtnCus.AutoSize = true;
            this.radioBtnCus.Location = new System.Drawing.Point(25, 26);
            this.radioBtnCus.Name = "radioBtnCus";
            this.radioBtnCus.Size = new System.Drawing.Size(103, 24);
            this.radioBtnCus.TabIndex = 0;
            this.radioBtnCus.TabStop = true;
            this.radioBtnCus.Text = "Customer";
            this.radioBtnCus.UseVisualStyleBackColor = true;
            this.radioBtnCus.CheckedChanged += new System.EventHandler(this.radioBtnCus_CheckedChanged);
            // 
            // radioBtnStaff
            // 
            this.radioBtnStaff.AutoSize = true;
            this.radioBtnStaff.Location = new System.Drawing.Point(188, 25);
            this.radioBtnStaff.Name = "radioBtnStaff";
            this.radioBtnStaff.Size = new System.Drawing.Size(69, 24);
            this.radioBtnStaff.TabIndex = 1;
            this.radioBtnStaff.TabStop = true;
            this.radioBtnStaff.Text = "Staff";
            this.radioBtnStaff.UseVisualStyleBackColor = true;
            this.radioBtnStaff.CheckedChanged += new System.EventHandler(this.radioBtnStaff_CheckedChanged);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogIn_FormClosing);
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnStaff;
        private System.Windows.Forms.RadioButton radioBtnCus;
    }
}