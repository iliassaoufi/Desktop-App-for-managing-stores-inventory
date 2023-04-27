using ProjetGestionStock.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestionStock
{
    public partial class FormControleJour : Form
    {
        public FormControleJour()
        {
            InitializeComponent();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.textBoxNbrVente.Text = "le nombre de ventes";
            this.textBoxGain.Text = "le gain en Dhs";
            this.textBoxPerte.Text = "la perte en dhs";
            this.textBoxNbrDestock.Text = "le nombre de produits en déstockage";
        }

        private void buttonValide_Click(object sender, EventArgs e)
        {
            var r = new StatistiqueController();

            r.setInfoRevrnu(
                this.textBoxNbrVente.Text,
                this.textBoxGain.Text,
                this.textBoxPerte.Text,
                this.textBoxNbrDestock.Text
                );

        }

        private void textBoxNbrVente_Enter(object sender, EventArgs e)
        {
            this.textBoxNbrVente.Text = "";
        }

        private void textBoxGain_Enter(object sender, EventArgs e)
        {
            this.textBoxGain.Text = "";
        }

        private void textBoxPerte_Enter(object sender, EventArgs e)
        {
            this.textBoxPerte.Text = "";
        }

        private void textBoxNbrDestock_Enter(object sender, EventArgs e)
        {
            this.textBoxNbrDestock.Text = "";

        }
    }


}
