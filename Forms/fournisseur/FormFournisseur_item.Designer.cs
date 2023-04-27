namespace ProjetGestionStock
{
    partial class FormFournisseur_item
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonVoirPlus = new System.Windows.Forms.Button();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(350, 200);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonVoirPlus);
            this.panel2.Controls.Add(this.labelAdresse);
            this.panel2.Controls.Add(this.labelContact);
            this.panel2.Controls.Add(this.labelNom);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 196);
            this.panel2.TabIndex = 0;
            // 
            // buttonVoirPlus
            // 
            this.buttonVoirPlus.FlatAppearance.BorderSize = 2;
            this.buttonVoirPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoirPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonVoirPlus.Location = new System.Drawing.Point(221, 141);
            this.buttonVoirPlus.Name = "buttonVoirPlus";
            this.buttonVoirPlus.Size = new System.Drawing.Size(104, 31);
            this.buttonVoirPlus.TabIndex = 2;
            this.buttonVoirPlus.Text = "+ Plus";
            this.buttonVoirPlus.UseVisualStyleBackColor = true;
            this.buttonVoirPlus.Click += new System.EventHandler(this.buttonVoirPlus_Click);
            // 
            // labelAdresse
            // 
            this.labelAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelAdresse.Location = new System.Drawing.Point(155, 67);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(181, 17);
            this.labelAdresse.TabIndex = 1;
            this.labelAdresse.Text = "fes , zohour , rue Paris 23";
            // 
            // labelContact
            // 
            this.labelContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelContact.Location = new System.Drawing.Point(155, 93);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(183, 17);
            this.labelContact.TabIndex = 1;
            this.labelContact.Text = "0623972198";
            // 
            // labelNom
            // 
            this.labelNom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.labelNom.Location = new System.Drawing.Point(153, 27);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(183, 25);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "EL AOUFI Iliass";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::ProjetGestionStock.Properties.Resources.user_3_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(137, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormFournisseur_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFournisseur_item";
            this.Text = "FormFournisseur_item";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Button buttonVoirPlus;
        private System.Windows.Forms.Label labelAdresse;
    }
}