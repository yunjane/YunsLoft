namespace YunsLoft
{
    partial class FormCart
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
            this.lBoxOrder = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKeep = new System.Windows.Forms.Button();
            this.lblTPrice = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChekOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Cart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lBoxOrder
            // 
            this.lBoxOrder.FormattingEnabled = true;
            this.lBoxOrder.ItemHeight = 20;
            this.lBoxOrder.Location = new System.Drawing.Point(113, 119);
            this.lBoxOrder.Name = "lBoxOrder";
            this.lBoxOrder.Size = new System.Drawing.Size(1019, 484);
            this.lBoxOrder.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(113, 624);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(306, 65);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove Selected Product";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(447, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKeep
            // 
            this.btnKeep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(81)))));
            this.btnKeep.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeep.ForeColor = System.Drawing.Color.White;
            this.btnKeep.Location = new System.Drawing.Point(830, 692);
            this.btnKeep.Name = "btnKeep";
            this.btnKeep.Size = new System.Drawing.Size(131, 65);
            this.btnKeep.TabIndex = 8;
            this.btnKeep.Text = "Keep Shopping";
            this.btnKeep.UseVisualStyleBackColor = false;
            this.btnKeep.Click += new System.EventHandler(this.btnKeep_Click);
            // 
            // lblTPrice
            // 
            this.lblTPrice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPrice.Location = new System.Drawing.Point(699, 624);
            this.lblTPrice.Name = "lblTPrice";
            this.lblTPrice.Size = new System.Drawing.Size(433, 65);
            this.lblTPrice.TabIndex = 9;
            this.lblTPrice.Text = "Total Price :";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1021, 55);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 35);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChekOut
            // 
            this.btnChekOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(81)))));
            this.btnChekOut.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChekOut.ForeColor = System.Drawing.Color.White;
            this.btnChekOut.Location = new System.Drawing.Point(1010, 692);
            this.btnChekOut.Name = "btnChekOut";
            this.btnChekOut.Size = new System.Drawing.Size(131, 65);
            this.btnChekOut.TabIndex = 11;
            this.btnChekOut.Text = "Check Out";
            this.btnChekOut.UseVisualStyleBackColor = false;
            this.btnChekOut.Click += new System.EventHandler(this.btnChekOut_Click);
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1218, 780);
            this.Controls.Add(this.btnChekOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTPrice);
            this.Controls.Add(this.btnKeep);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lBoxOrder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCart";
            this.Load += new System.EventHandler(this.FormCart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxOrder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnKeep;
        private System.Windows.Forms.Label lblTPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChekOut;
    }
}