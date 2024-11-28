namespace YunsLoft
{
    partial class FormChair
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
            this.components = new System.ComponentModel.Container();
            this.listViewChair = new System.Windows.Forms.ListView();
            this.imageListProducts = new System.Windows.Forms.ImageList(this.components);
            this.lblBack = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewChair
            // 
            this.listViewChair.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewChair.HideSelection = false;
            this.listViewChair.Location = new System.Drawing.Point(70, 172);
            this.listViewChair.Name = "listViewChair";
            this.listViewChair.Size = new System.Drawing.Size(1085, 551);
            this.listViewChair.TabIndex = 0;
            this.listViewChair.UseCompatibleStateImageBehavior = false;
            this.listViewChair.ItemActivate += new System.EventHandler(this.listViewChair_ItemActivate);
            // 
            // imageListProducts
            // 
            this.imageListProducts.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageListProducts.ImageSize = new System.Drawing.Size(60, 60);
            this.imageListProducts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.White;
            this.lblBack.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(484, 83);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(257, 51);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "YuNs Chair.";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(974, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormChair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 780);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.listViewChair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChair";
            this.Load += new System.EventHandler(this.FormChair_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewChair;
        private System.Windows.Forms.ImageList imageListProducts;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button button1;
    }
}