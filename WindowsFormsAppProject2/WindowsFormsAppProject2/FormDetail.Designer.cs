namespace YunsLoft
{
    partial class FormDetail
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
            this.pBoxProduct = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.btnChangePic = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxProduct
            // 
            this.pBoxProduct.Location = new System.Drawing.Point(80, 87);
            this.pBoxProduct.Name = "pBoxProduct";
            this.pBoxProduct.Size = new System.Drawing.Size(305, 296);
            this.pBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxProduct.TabIndex = 0;
            this.pBoxProduct.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(642, 87);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(195, 44);
            this.txtID.TabIndex = 4;
            // 
            // txtPname
            // 
            this.txtPname.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPname.Location = new System.Drawing.Point(642, 147);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(340, 44);
            this.txtPname.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(642, 212);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(340, 44);
            this.txtPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(642, 338);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(340, 44);
            this.txtStatus.TabIndex = 8;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdit.Location = new System.Drawing.Point(750, 453);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(232, 43);
            this.btnSaveEdit.TabIndex = 9;
            this.btnSaveEdit.Text = "Save Edit";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(750, 520);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 43);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPic.Location = new System.Drawing.Point(80, 411);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(232, 43);
            this.btnUploadPic.TabIndex = 11;
            this.btnUploadPic.Text = "Upload Picture";
            this.btnUploadPic.UseVisualStyleBackColor = true;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(828, 572);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 43);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAdd.Location = new System.Drawing.Point(80, 475);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(232, 43);
            this.btnEditAdd.TabIndex = 13;
            this.btnEditAdd.Text = "Save Edit";
            this.btnEditAdd.UseVisualStyleBackColor = true;
            this.btnEditAdd.Click += new System.EventHandler(this.btnEditAdd_Click);
            // 
            // btnChangePic
            // 
            this.btnChangePic.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePic.Location = new System.Drawing.Point(80, 38);
            this.btnChangePic.Name = "btnChangePic";
            this.btnChangePic.Size = new System.Drawing.Size(232, 43);
            this.btnChangePic.TabIndex = 14;
            this.btnChangePic.Text = "Change Picture";
            this.btnChangePic.UseVisualStyleBackColor = true;
            this.btnChangePic.Click += new System.EventHandler(this.btnChangePic_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(438, 286);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(109, 25);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(642, 276);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(340, 44);
            this.txtCategory.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "1 In stock / 0 Out of stock / 2 Shut-down ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1010, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 35);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 668);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnChangePic);
            this.Controls.Add(this.btnEditAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUploadPic);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBoxProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetail";
            this.Load += new System.EventHandler(this.FormDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.Button btnChangePic;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
    }
}