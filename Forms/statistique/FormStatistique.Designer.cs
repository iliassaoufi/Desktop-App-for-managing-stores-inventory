namespace ProjetGestionStock
{
    partial class FormStatistique
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAchatJour = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelGainJour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNbrVentJour = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.labelAchatMois = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGainMois = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelVentMois = new System.Windows.Forms.Label();
            this.buttonAnnée = new System.Windows.Forms.Button();
            this.buttonMois = new System.Windows.Forms.Button();
            this.buttonJour = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartStatistique = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.date = new System.Windows.Forms.Label();
            this.buttonImprim = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistique)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(25, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(537, 325);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.date);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.labelAchatJour);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.labelGainJour);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelNbrVentJour);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 321);
            this.panel3.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(40, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(304, 54);
            this.label13.TabIndex = 6;
            this.label13.Text = "Ce Jour";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 67);
            this.label9.TabIndex = 5;
            this.label9.Text = "Le nombre achat :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAchatJour
            // 
            this.labelAchatJour.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchatJour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAchatJour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAchatJour.Location = new System.Drawing.Point(264, 237);
            this.labelAchatJour.Name = "labelAchatJour";
            this.labelAchatJour.Size = new System.Drawing.Size(196, 67);
            this.labelAchatJour.TabIndex = 4;
            this.labelAchatJour.Text = "12";
            this.labelAchatJour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 67);
            this.label7.TabIndex = 3;
            this.label7.Text = "Le gain  :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGainJour
            // 
            this.labelGainJour.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGainJour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelGainJour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGainJour.Location = new System.Drawing.Point(264, 163);
            this.labelGainJour.Name = "labelGainJour";
            this.labelGainJour.Size = new System.Drawing.Size(196, 67);
            this.labelGainJour.TabIndex = 2;
            this.labelGainJour.Text = "12";
            this.labelGainJour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Le nombre des vents :  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNbrVentJour
            // 
            this.labelNbrVentJour.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbrVentJour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNbrVentJour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNbrVentJour.Location = new System.Drawing.Point(264, 88);
            this.labelNbrVentJour.Name = "labelNbrVentJour";
            this.labelNbrVentJour.Size = new System.Drawing.Size(196, 67);
            this.labelNbrVentJour.TabIndex = 0;
            this.labelNbrVentJour.Text = "12";
            this.labelNbrVentJour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(579, 24);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(2);
            this.panel6.Size = new System.Drawing.Size(226, 500);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.labelAchatMois);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.labelGainMois);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.labelVentMois);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(222, 496);
            this.panel7.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 80);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total d\'achat de ce mois";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAchatMois
            // 
            this.labelAchatMois.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAchatMois.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchatMois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAchatMois.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAchatMois.Location = new System.Drawing.Point(10, 320);
            this.labelAchatMois.Name = "labelAchatMois";
            this.labelAchatMois.Size = new System.Drawing.Size(202, 75);
            this.labelAchatMois.TabIndex = 4;
            this.labelAchatMois.Text = "12";
            this.labelAchatMois.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 80);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total de gain de ce mois ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGainMois
            // 
            this.labelGainMois.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGainMois.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGainMois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelGainMois.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelGainMois.Location = new System.Drawing.Point(10, 165);
            this.labelGainMois.Name = "labelGainMois";
            this.labelGainMois.Size = new System.Drawing.Size(202, 75);
            this.labelGainMois.TabIndex = 2;
            this.labelGainMois.Text = "12";
            this.labelGainMois.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 80);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total des vents  de ce mois ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVentMois
            // 
            this.labelVentMois.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVentMois.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentMois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelVentMois.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelVentMois.Location = new System.Drawing.Point(10, 10);
            this.labelVentMois.Name = "labelVentMois";
            this.labelVentMois.Size = new System.Drawing.Size(202, 75);
            this.labelVentMois.TabIndex = 0;
            this.labelVentMois.Text = "12";
            this.labelVentMois.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonAnnée
            // 
            this.buttonAnnée.FlatAppearance.BorderSize = 2;
            this.buttonAnnée.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnée.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.buttonAnnée.Location = new System.Drawing.Point(315, 361);
            this.buttonAnnée.Name = "buttonAnnée";
            this.buttonAnnée.Size = new System.Drawing.Size(100, 39);
            this.buttonAnnée.TabIndex = 6;
            this.buttonAnnée.Text = "Par Année";
            this.buttonAnnée.UseVisualStyleBackColor = true;
            this.buttonAnnée.Click += new System.EventHandler(this.buttonAnnée_Click);
            // 
            // buttonMois
            // 
            this.buttonMois.FlatAppearance.BorderSize = 2;
            this.buttonMois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.buttonMois.Location = new System.Drawing.Point(202, 361);
            this.buttonMois.Name = "buttonMois";
            this.buttonMois.Size = new System.Drawing.Size(107, 39);
            this.buttonMois.TabIndex = 7;
            this.buttonMois.Text = "Par Mois";
            this.buttonMois.UseVisualStyleBackColor = true;
            this.buttonMois.Click += new System.EventHandler(this.buttonMois_Click);
            // 
            // buttonJour
            // 
            this.buttonJour.FlatAppearance.BorderSize = 2;
            this.buttonJour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.buttonJour.Location = new System.Drawing.Point(99, 361);
            this.buttonJour.Name = "buttonJour";
            this.buttonJour.Size = new System.Drawing.Size(97, 39);
            this.buttonJour.TabIndex = 8;
            this.buttonJour.Text = "Par Jour";
            this.buttonJour.UseVisualStyleBackColor = true;
            this.buttonJour.Click += new System.EventHandler(this.buttonJour_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chartStatistique);
            this.panel2.Controls.Add(this.buttonAnnée);
            this.panel2.Controls.Add(this.buttonJour);
            this.panel2.Controls.Add(this.buttonMois);
            this.panel2.Location = new System.Drawing.Point(12, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 422);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "l\'avancement des gains";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartStatistique
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStatistique.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStatistique.Legends.Add(legend2);
            this.chartStatistique.Location = new System.Drawing.Point(3, 14);
            this.chartStatistique.Name = "chartStatistique";
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.BorderWidth = 0;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chartStatistique.Series.Add(series2);
            this.chartStatistique.Size = new System.Drawing.Size(556, 300);
            this.chartStatistique.TabIndex = 9;
            this.chartStatistique.Text = "v";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.date.Location = new System.Drawing.Point(45, 55);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(304, 32);
            this.date.TabIndex = 7;
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonImprim
            // 
            this.buttonImprim.FlatAppearance.BorderSize = 2;
            this.buttonImprim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.buttonImprim.Location = new System.Drawing.Point(579, 559);
            this.buttonImprim.Name = "buttonImprim";
            this.buttonImprim.Size = new System.Drawing.Size(226, 39);
            this.buttonImprim.TabIndex = 10;
            this.buttonImprim.Text = "Imprimer";
            this.buttonImprim.UseVisualStyleBackColor = true;
            this.buttonImprim.Click += new System.EventHandler(this.buttonImprim_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 634);
            this.Controls.Add(this.buttonImprim);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStatistique";
            this.Text = "FormStatistique";
            this.Load += new System.EventHandler(this.FormStatistique_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistique)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNbrVentJour;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelVentMois;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAchatJour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelGainJour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAchatMois;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGainMois;
        private System.Windows.Forms.Button buttonAnnée;
        private System.Windows.Forms.Button buttonMois;
        private System.Windows.Forms.Button buttonJour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button buttonImprim;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}