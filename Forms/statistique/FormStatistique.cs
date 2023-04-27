using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static ProjetGestionStock.Model_Gestion_Stock;
using ProjetGestionStock.Controller;

namespace ProjetGestionStock
{
    public partial class FormStatistique : Form
    {
        private Bitmap btm;
        StatistiqueController s = new StatistiqueController();
        FournisseurController f = new FournisseurController();
        DateTime dt = DateTime.Now.Date;

        public FormStatistique()
        {
            InitializeComponent();
            //----------------
            this.date.Text = this.dt.ToString("MM/dd/yyyy ");



        }
        private void FormStatistique_Load(object sender, EventArgs e)
        {

            implementJour();


            implementMois();

            chartJour();
        }

        private void buttonJour_Click(object sender, EventArgs e)
        {
            chartJour();
        }

        private void buttonMois_Click(object sender, EventArgs e)
        {
            chartMois();
        }

        private void buttonAnnée_Click(object sender, EventArgs e)
        {
            chartAnnée();
        }
        private void implementJour()
        {

            this.labelNbrVentJour.Text = s.jour_NbrVent(this.dt);
            this.labelGainJour.Text = s.jour_Gain(this.dt);
            this.labelAchatJour.Text = f.jour_NbrCommande(this.dt);
        }
        private void implementMois()
        {

            this.labelVentMois.Text = s.mois_NbrVent(this.dt);

            this.labelGainMois.Text = s.mois_Gain(this.dt);

            this.labelAchatMois.Text = f.mois_NbrCommande(this.dt);
        }
        private void chartJour()
        {
            var chart = this.chartStatistique.Series["Series1"];
            chart.LegendText = "Jours";
            chart.Points.Clear();


            for (int i = 1; i < 8; i++)
            {
                chart.Points.AddXY(this.dt.Day - 7 + i, Convert.ToDecimal(s.jour_Gain(this.dt.AddDays(-7 + i))));
            }

        }
        private void chartMois()
        {
            var chart = this.chartStatistique.Series["Series1"];
            chart.LegendText = "Mois";
            chart.Points.Clear();

            for (int i = 1; i < 13; i++)
            {
                chart.Points.AddXY(this.dt.Month - 12 + i, Convert.ToDecimal(s.mois_Gain(this.dt.AddMonths(-12 + i))));
            }
        }
        private void chartAnnée()
        {
            var chart = this.chartStatistique.Series["Series1"];
            chart.LegendText = "Années";
            chart.Points.Clear();
            for (int i = 1; i < 6; i++)
            {
                chart.Points.AddXY(this.dt.Year - 5 + i, Convert.ToDecimal(s.annee_Gain(this.dt.AddYears(-5 + i))));
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(btm, 0, 0);
        }

        private void buttonImprim_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            btm = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(btm);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            this.printDialog1.ShowDialog();
        }
    }
}
