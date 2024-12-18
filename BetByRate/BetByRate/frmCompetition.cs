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
    public partial class frmCompetition : Form
    {
        public frmCompetition()
        {
            InitializeComponent();
        }

        private void frmCompetition_Load(object sender, EventArgs e)
        {

            try
            {
                // Charger la comboBox Sport
                var dtTableSport = Object.Sport.GetAll();
                cbxSport.DataSource = dtTableSport;
                cbxSport.ValueMember = "IdSport";
                cbxSport.DisplayMember = "Nom";
                cbxSport.SelectedIndex = -1; // Permet d'afficher vide dans la combo

                // Charger la comboBox Surface
                var dtTableSurface = Object.Surface.GetAll();
                cbxSurface.DataSource = dtTableSurface;
                cbxSurface.ValueMember = "IdSurface";
                cbxSurface.DisplayMember = "Libelle";
                cbxSurface.SelectedIndex = -1; // Permet d'afficher vide dans la combo

                // Charger la comboBox Categorie
                var dtTableCategorie = Object.Categorie.GetAll();
                cbxCategorie.DataSource = dtTableCategorie;
                cbxCategorie.ValueMember = "IdCategorie";
                cbxCategorie.DisplayMember = "Libelle";
                cbxCategorie.SelectedIndex = -1; // Permet d'afficher vide dans la combo

            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Probleme : {0}", ex.Source);
                throw;
            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            Object.Competition oCompetition;
            int intIdSport;

            try
            {
                // Récupérer la valeur de Sport pour pouvoir vérifier qu'il n'est pas vide
                intIdSport = Convert.ToInt32(this.cbxSport.SelectedValue);

                if (this.txbNom.Text != String.Empty && intIdSport != 0)
                {
                    // Charger l'objet
                    oCompetition = new Object.Competition();
                    oCompetition.Nom = txbNom.Text;
                    oCompetition.IdSurface = Convert.ToInt32(this.cbxSurface.SelectedValue);
                    oCompetition.IdCategorie = Convert.ToInt32(this.cbxCategorie.SelectedValue);
                    oCompetition.IdSport = intIdSport;

                    // Faire l'insert
                    oCompetition.Insert();

                    lblMessage.Text = "La compétition " + txbNom.Text + " a été ajouter.";
                    txbNom.Text = "";
                    this.cbxSurface.SelectedValue = 0;
                    this.cbxCategorie.SelectedValue = 0;
                    this.cbxSport.SelectedValue = 0;

                }
                else
                {
                    lblMessage.Text = "Une information est manquante";
                    //MessageBox.Show("Une information est manquante");
                }
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Probleme : {0}", ex.Source);
                throw;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cbxSport.Text == "Tennis")
                {
                    this.cbxCategorie.Enabled = true;
                    this.cbxSurface.Enabled = true;
                }
                else
                {
                    this.cbxSurface.SelectedValue = 0;
                    this.cbxCategorie.SelectedValue = 0;
                    this.cbxCategorie.Enabled = false;
                    this.cbxSurface.Enabled = false;
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
