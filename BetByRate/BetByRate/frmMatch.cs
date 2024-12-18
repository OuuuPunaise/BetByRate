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
    public partial class frmMatch : Form
    {
        public frmMatch()
        {
            InitializeComponent();
        }

        private void frmMatch_Load(object sender, EventArgs e)
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

        private void btnFermer_Click(object sender, EventArgs e)
        {
            // Ouvrir la partie board
            frmBoard oBoard = new frmBoard();
            oBoard.TopLevel = false;
            //pnlContent.Controls.Add(match);
            this.Parent.Controls.Add(oBoard);
            oBoard.BringToFront();
            oBoard.Show();

            //Fermer la partie Match
            this.Close();

        }

        private void cbxSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intIdSport;
            try
            {
                if (cbxSport.Focused == true)
                {
                    // On rend accessible la partie match
                    cbxJoueur1.Enabled = true;
                    cbxJoueur2.Enabled = true;
                    tbxCoteJoueur1.Enabled = true;
                    tbxCoteJoueur2.Enabled = true;
                    cbxCompetition.Enabled = true;

                    // On charge les combo des joueurs/protagonistes
                    intIdSport = Convert.ToInt32(cbxSport.SelectedValue);
                    var dtTableProtagoniste = Object.Protagoniste.GetBySport(intIdSport);
                    cbxJoueur1.DataSource = dtTableProtagoniste;
                    cbxJoueur1.ValueMember = "IdProtagoniste";
                    cbxJoueur1.DisplayMember = "Nom";
                    cbxJoueur1.SelectedIndex = -1; // Permet d'afficher vide dans la combo

                    cbxJoueur2.BindingContext = new BindingContext(); // Pour ne pas que les combo box ce copie l'une l'autre
                    cbxJoueur2.DataSource = dtTableProtagoniste;
                    cbxJoueur2.ValueMember = "IdProtagoniste";
                    cbxJoueur2.DisplayMember = "Nom";
                    cbxJoueur2.SelectedIndex = -1; // Permet d'afficher vide dans la combo

                    // On charge la combo des competitions
                    var dtTableCompetition = Object.Competition.GetBySport(intIdSport);
                    cbxCompetition.DataSource = dtTableCompetition;
                    cbxCompetition.ValueMember = "IdCompetition";
                    cbxCompetition.DisplayMember = "Nom";
                    cbxCompetition.SelectedIndex = -1; // Permet d'afficher vide dans la combo

                }
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
            Object.Match oMatch;
            Object.Favori oFavori;
            Object.Challenger oChallenger;
            //Object.Fourchette oFourchette;
            double dblCoteJoeur1;
            double dblCoteJoeur2;
            //double dblCoteFavori;
            //double dblCoteChallenger;
            double dblCoteFourchette;

            decimal decCoteFavori;
            decimal decCoteChallenger;

            string? strLibelleFourchette;
            int intIdFavori = 0;
            int intIdChallenger = 0;
            int intIdProtagonisteFavori = 0;
            int intIdProtagonisteChallenger = 0;

            try
            {

                //Vérifier que tous les champs sont rempli
                if (cbxSport.Text != "" && mtbDate != null && cbxJoueur1.Text != "" &&
                    cbxJoueur2.Text != "" && tbxCoteJoueur1.Text != "" && tbxCoteJoueur2.Text != "")
                {

                    dblCoteJoeur1 = Convert.ToDouble(tbxCoteJoueur1.Text);
                    dblCoteJoeur2 = Convert.ToDouble(tbxCoteJoueur2.Text);

                    if (dblCoteJoeur1 > 1.39 || dblCoteJoeur1 > 1.39)
                    {
                        //Charger l'objet match
                        oMatch = new Object.Match();
                        oMatch.DateMatch = Convert.ToDateTime(mtbDate.Text);
                        oMatch.IdCompetition = Convert.ToInt32(cbxCompetition.SelectedValue);
                        oMatch.IdUtilisateur = 1;

                        // Trouver le Favori et le Challenger
                        if (dblCoteJoeur1 > dblCoteJoeur2)
                        {
                            intIdProtagonisteFavori = Convert.ToInt32(cbxJoueur2.SelectedValue);
                            intIdProtagonisteChallenger = Convert.ToInt32(cbxJoueur1.SelectedValue);
                            dblCoteFourchette = Convert.ToDouble(tbxCoteJoueur2.Text);
                            //dblCoteFavori = Convert.ToDouble(tbxCoteJoueur2.Text);
                            decCoteFavori = Convert.ToDecimal(tbxCoteJoueur2.Text);
                            //dblCoteChallenger = Convert.ToDouble(tbxCoteJoueur1.Text);
                            decCoteChallenger = Convert.ToDecimal(tbxCoteJoueur1.Text);
                        }
                        else
                        {
                            intIdProtagonisteFavori = Convert.ToInt32(cbxJoueur1.SelectedValue);
                            intIdProtagonisteChallenger = Convert.ToInt32(cbxJoueur2.SelectedValue);
                            dblCoteFourchette = Convert.ToDouble(tbxCoteJoueur1.Text);
                            //dblCoteFavori = Convert.ToDouble(tbxCoteJoueur1.Text);
                            decCoteFavori = Convert.ToDecimal(tbxCoteJoueur1.Text);
                            //dblCoteChallenger = Convert.ToDouble(tbxCoteJoueur2.Text);
                            decCoteChallenger = Convert.ToDecimal(tbxCoteJoueur2.Text);
                        }

                        // Trouver la Fourchette
                        // Récupérer les Fourchettes
                        DataTable dtTableFourchette = Object.Fourchette.GetAll();

                        foreach (DataRow myRow in dtTableFourchette.Rows)
                        {
                            strLibelleFourchette = myRow["Libelle"].ToString();

                            //Récupérer les 3 premières valeur
                            strLibelleFourchette = strLibelleFourchette.Substring(8, 4);

                            if (dblCoteFourchette <= Convert.ToDouble(strLibelleFourchette))
                            {
                                oMatch.IdFourchette = Convert.ToInt32(myRow["idFourchette"].ToString());
                                break;
                            }
                        }

                        // Charger l'objet Favori
                        oFavori = new Object.Favori();
                        //oFavori.CoteExacte = dblCoteFavori;
                        oFavori.CoteExacte = decCoteFavori;
                        oFavori.Vainqueur = null; //DBNull.Value;
                        oFavori.IdProtagoniste = intIdProtagonisteFavori;

                        // Charger l'objet Challenger
                        oChallenger = new Object.Challenger();
                        //oChallenger.CoteExacte = dblCoteChallenger;
                        oChallenger.CoteExacte = decCoteChallenger;
                        oChallenger.Vainqueur = null;
                        oChallenger.IdProtagoniste = intIdProtagonisteChallenger;

                        // Insertion du favori et du challenger avec récupération des ID
                        intIdFavori = oFavori.Insert();
                        intIdChallenger = oChallenger.Insert();

                        // Finir de charger l'objet match avec le favorie et le challenger
                        oMatch.IdFavori = intIdFavori;
                        oMatch.IdChallenger = intIdChallenger;

                        // Insertion du match
                        oMatch.Insert();

                        lblMessage.Text = "Le match " + cbxJoueur1.Text + " - " + cbxJoueur2.Text + " est enregistrer";
                    }
                    else
                    {
                        lblMessage.Text = "Les cotes doivent être suppérieur à 1.39";
                    }
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

        private void tbxCoteJoueur1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                //e.KeyChar = ',';
                e.KeyChar = e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
        }

        private void tbxCoteJoueur2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                //e.KeyChar = ',';
                e.KeyChar = e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
        }

    }
}
