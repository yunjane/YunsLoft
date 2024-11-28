namespace YunsLoft
{
    partial class FormProductsEdit
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
            this.listViewEdit = new System.Windows.Forms.ListView();
            this.imageListProducts = new System.Windows.Forms.ImageList(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "YuNS Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewEdit
            // 
            this.listViewEdit.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewEdit.HideSelection = false;
            this.listViewEdit.Location = new System.Drawing.Point(61, 130);
            this.listViewEdit.Name = "listViewEdit";
            this.listViewEdit.Size = new System.Drawing.Size(684, 551);
            this.listViewEdit.TabIndex = 2;
            this.listViewEdit.UseCompatibleStateImageBehavior = false;
            this.listViewEdit.ItemActivate += new System.EventHandler(this.listViewEdit_ItemActivate);
            // 
            // imageListProducts
            // 
            this.imageListProducts.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageListProducts.ImageSize = new System.Drawing.Size(60, 60);
            this.imageListProducts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.IndianRed;
            this.btnEdit.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(763, 130);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(262, 47);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Add Product";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(763, 197);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(262, 47);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1012, 50);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 38);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormProductsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1196, 724);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductsEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductsEdit";
            this.Activated += new System.EventHandler(this.FormProductsEdit_Activated);
            this.Load += new System.EventHandler(this.FormProductsEdit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewEdit;
        private System.Windows.Forms.ImageList imageListProducts;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
    }
}