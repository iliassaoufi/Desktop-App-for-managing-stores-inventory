namespace ProjetGestionStock
{
    partial class FormOneProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelProductDate = new System.Windows.Forms.Label();
            this.labelProductQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDisponible = new System.Windows.Forms.Label();
            this.labelProductTitle = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBoxProductImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 364);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxProductImage.Image = global::ProjetGestionStock.Properties.Resources.img1;
            this.pictureBoxProductImage.Location = new System.Drawing.Point(51, 44);
            this.pictureBoxProductImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(222, 269);
            this.pictureBoxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProductImage.TabIndex = 0;
            this.pictureBoxProductImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.labelProductDate);
            this.panel2.Controls.Add(this.labelProductQuantity);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelProductPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelDisponible);
            this.panel2.Controls.Add(this.labelProductTitle);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(326, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 364);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // labelProductDate
            // 
            this.labelProductDate.AutoSize = true;
            this.labelProductDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductDate.ForeColor = System.Drawing.Color.White;
            this.labelProductDate.Location = new System.Drawing.Point(241, 199);
            this.labelProductDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductDate.Name = "labelProductDate";
            this.labelProductDate.Size = new System.Drawing.Size(123, 22);
            this.labelProductDate.TabIndex = 1;
            this.labelProductDate.Text = "3 / 12 / 2020";
            // 
            // labelProductQuantity
            // 
            this.labelProductQuantity.AutoSize = true;
            this.labelProductQuantity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductQuantity.ForeColor = System.Drawing.Color.White;
            this.labelProductQuantity.Location = new System.Drawing.Point(152, 157);
            this.labelProductQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductQuantity.Name = "labelProductQuantity";
            this.labelProductQuantity.Size = new System.Drawing.Size(21, 22);
            this.labelProductQuantity.TabIndex = 1;
            this.labelProductQuantity.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "date d’expiration : ";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductPrice.ForeColor = System.Drawing.Color.White;
            this.labelProductPrice.Location = new System.Drawing.Point(113, 120);
            this.labelProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(54, 22);
            this.labelProductPrice.TabIndex = 1;
            this.labelProductPrice.Text = "1200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "quantité :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix : ";
            // 
            // labelDisponible
            // 
            this.labelDisponible.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDisponible.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(111)))), ((int)(((byte)(61)))));
            this.labelDisponible.Location = new System.Drawing.Point(0, 270);
            this.labelDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDisponible.Name = "labelDisponible";
            this.labelDisponible.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.labelDisponible.Size = new System.Drawing.Size(507, 43);
            this.labelDisponible.TabIndex = 1;
            this.labelDisponible.Text = "Disponible";
            // 
            // labelProductTitle
            // 
            this.labelProductTitle.AutoSize = true;
            this.labelProductTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductTitle.ForeColor = System.Drawing.Color.White;
            this.labelProductTitle.Location = new System.Drawing.Point(45, 44);
            this.labelProductTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductTitle.Name = "labelProductTitle";
            this.labelProductTitle.Size = new System.Drawing.Size(222, 36);
            this.labelProductTitle.TabIndex = 1;
            this.labelProductTitle.Text = "Lawrance Polo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::ProjetGestionStock.Properties.Resources.moins_2_;
            this.pictureBox3.Location = new System.Drawing.Point(444, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::ProjetGestionStock.Properties.Resources.erreur;
            this.pictureBox2.Location = new System.Drawing.Point(474, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormOneProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOneProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOneProduct";
            this.Load += new System.EventHandler(this.FormOneProduct_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxProductImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelProductTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProductQuantity;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProductDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDisponible;
    }
}