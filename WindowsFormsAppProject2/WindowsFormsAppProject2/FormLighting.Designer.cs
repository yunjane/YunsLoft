namespace YunsLoft
{
    partial class FormLighting
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewLighting = new System.Windows.Forms.ListView();
            this.imageListProducts = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "YuNs Lighting.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewLighting
            // 
            this.listViewLighting.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewLighting.HideSelection = false;
            this.listViewLighting.Location = new System.Drawing.Point(70, 172);
            this.listViewLighting.Name = "listViewLighting";
            this.listViewLighting.Size = new System.Drawing.Size(1085, 551);
            this.listViewLighting.TabIndex = 2;
            this.listViewLighting.UseCompatibleStateImageBehavior = false;
            this.listViewLighting.ItemActivate += new System.EventHandler(this.listViewLighting_ItemActivate);
            // 
            // imageListProducts
            // 
            this.imageListProducts.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageListProducts.ImageSize = new System.Drawing.Size(60, 60);
            this.imageListProducts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(991, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLighting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 780);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewLighting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLighting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLighting";
            this.Load += new System.EventHandler(this.FormLighting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewLighting;
        private System.Windows.Forms.ImageList imageListProducts;
        private System.Windows.Forms.Button button1;
    }
}