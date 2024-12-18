using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetByRate
{
    public partial class frmProtagoniste : Form
    {
        public frmProtagoniste()
        {
            InitializeComponent();
        }


        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Object.Protagoniste oProtagoniste;

            try
            {
                if (this.txbNom.Text != string.Empty && cbxSport.SelectedValue != null)
                {
                    // Charger l'objet
                    oProtagoniste = new Object.Protagoniste();
                    oProtagoniste.Nom = txbNom.Text;
                    oProtagoniste.Prenom = txbPrenom.Text;
                    oProtagoniste.Homme = rdbHomme.Checked;
                    oProtagoniste.Femme = rdbFemme.Checked;
                    oProtagoniste.Actif = true;
                    oProtagoniste.IdSport = Convert.ToInt32(cbxSport.SelectedValue);

                    // Faire l'insert
                    oProtagoniste.Insert();

                    lblMessage.Text = "Le protagoniste " + txbNom.Text + " a été ajouter.";
                    txbNom.Text = "";
                    txbPrenom.Text = "";
                    rdbHomme.Checked = false;
                    rdbFemme.Checked = false;

                }
                else
                {
                    lblMessage.Text = "Information manquante";
                }

            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Probleme : {0}", ex.Source);
                throw;
            }
        }

        private void frmProtagoniste_Load(object sender, EventArgs e)
        {
            try
            {
                // Charger la comboBox Sport
                var dtTableSport = Object.Sport.GetAll();
                cbxSport.DataSource = dtTableSport;
                cbxSport.ValueMember = "IdSport";
                cbxSport.DisplayMember = "Nom";
                cbxSport.SelectedIndex = -1; // Permet d'afficher vide dans la combo
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Probleme : {0}", ex.Source);
                throw;
            }
        }

        private void cbxSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxSport.Text == "Basket" || cbxSport.Text == "Volley")
                {
                    lblPrenom.Text = "Ville";
                }
                else
                {
                    lblPrenom.Text = "Prenom";
                }
                

            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Probleme : {0}", ex.Source);
                throw;
            }
        }
    }
}
