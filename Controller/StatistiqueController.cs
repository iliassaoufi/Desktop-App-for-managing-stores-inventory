using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetGestionStock.Model_Gestion_Stock;

namespace ProjetGestionStock.Controller
{
    class StatistiqueController
    {
        public StatistiqueController() { }

        public string jour_NbrVent(DateTime date)
        {
            using (var db = new Model_Gestion_Stock())
            {
                try
                {
                    var nbrVente = from r in db.Revenus
                                   where r.date_jour.Year == date.Year &&
                                         r.date_jour.Month == date.Month &&
                                         r.date_jour.Day == date.Day
                                   select r;
                    if (nbrVente != null)
                        return nbrVente.Sum(n => n.Nbr_ventes).ToString();
                }
                catch (Exception e)
                {

                }
                return "0";
            }

        }
        public string jour_Gain(DateTime date)
        {
            using (var db = new Model_Gestion_Stock())
            {
                try
                {
                    var nbrVente = from r in db.Revenus
                                   where r.date_jour.Year == date.Year &&
                                         r.date_jour.Month == date.Month &&
                                         r.date_jour.Day == date.Day
                                   select r;
                    if (nbrVente != null)
                        return nbrVente.Sum(n => n.Gain_jour).ToString();
                }
                catch (Exception e)
                {

                }

                return "0,00";
            }

        }
        public string mois_NbrVent(DateTime date)
        {
            using (var db = new Model_Gestion_Stock())
            {
                try
                {
                    var nbrVente = from r in db.Revenus
                                   where r.date_jour.Year == date.Year &&
                                         r.date_jour.Month == date.Month
                                   select r;
                    if (nbrVente != null)
                        return nbrVente.Sum(n => n.Nbr_ventes).ToString();
                }
                catch (Exception e)
                {

                }

                return "0";
            }

        }
        public string mois_Gain(DateTime date)
        {
            using (var db = new Model_Gestion_Stock())
            {
                try
                {
                    var nbrVente = from r in db.Revenus
                                   where r.date_jour.Year == date.Year &&
                                         r.date_jour.Month == date.Month
                                   select r;
                    if (nbrVente != null)
                        return nbrVente.Sum(n => n.Gain_jour).ToString();
                }
                catch (Exception e)
                {

                }

                return "0";
            }

        }
        public string annee_Gain(DateTime date)
        {
            using (var db = new Model_Gestion_Stock())
            {
                try
                {
                    var nbrVente = from r in db.Revenus
                                   where r.date_jour.Year == date.Year
                                   select r;
                    if (nbrVente != null)
                        return nbrVente.Sum(n => n.Gain_jour).ToString();
                }
                catch (Exception e)
                {

                }

                return "0";
            }

        }


        public void setInfoRevrnu(string nbrVente, string gain, string perte, string nbrDestock, string date = " ")
        {
            using (var db = new Model_Gestion_Stock())
            {
                bool b = false;

                try
                {
                    if (date == " ")
                        date = DateTime.Now.ToString();

                    Revenu rr = new Revenu
                    {
                        date_jour = Convert.ToDateTime(date),
                        Nbr_ventes = Convert.ToInt32(nbrVente),
                        Gain_jour = Convert.ToDecimal(gain),
                        Perte_jour = Convert.ToDecimal(perte)
                    };

                    db.Revenus.Add(rr);
                    db.SaveChanges();
                    b = true;
                }
                catch (Exception e)
                {
                }

                if (b)
                    MessageBox.Show("les info de jour est ajouté !");
                else
                    MessageBox.Show("les info de jour n'est pas ajouté !");
            }
        }

    }
}
