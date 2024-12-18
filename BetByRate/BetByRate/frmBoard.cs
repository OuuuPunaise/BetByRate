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
    public partial class frmBoard : Form
    {
        public frmBoard()
        {
            InitializeComponent();
        }

        private void dtgBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int intIdMatch;
            int intColIdMatch;
            int intIdFavori;
            int intColIdFavori;
            int intIdChallenger;
            int intColIdChallenger;

            // Récuperer l'id du Match
            //intIdMatch = Convert.ToInt32(dtgBoard.Rows[e.RowIndex].Cells[6].Value);
            intColIdMatch = dtgBoard.Columns["idMatchDataGridViewTextBoxColumn"].Index;
            intIdMatch = Convert.ToInt32(dtgBoard.Rows[e.RowIndex].Cells[intColIdMatch].Value);

            // Récupérer l'id du Favori
            intColIdFavori = dtgBoard.Columns["idFavoriDataGridViewTextBoxColumn"].Index;
            intIdFavori = Convert.ToInt32(dtgBoard.Rows[e.RowIndex].Cells[intColIdMatch].Value);

            // Récupérer l'id du Challenger
            intColIdChallenger = dtgBoard.Columns["idChallengerDataGridViewTextBoxColumn"].Index;
            intIdChallenger = Convert.ToInt32(dtgBoard.Rows[e.RowIndex].Cells[intColIdMatch].Value);

            // Chargement des objets Match Favori et Challenger
            Object.Match oMatch = new Object.Match(intIdMatch);
            Object.Favori oFavori = new Object.Favori(intIdFavori);
            Object.Challenger oChallenger = new Object.Challenger(intIdChallenger);

            switch (dtgBoard.Columns[e.ColumnIndex].Name)
            {
                case "btnDelete":
                    // Supprimer le Match
                    oMatch.Delete();

                    // Supprimer le Favori
                    oFavori.Delete();

                    // Supprimer le Challenger
                    oChallenger.Delete();
                    break;

                case "btnFavoriWin":
                    oFavori.Win();
                    oChallenger.Loose();
                    break;

                case "btnChallengerWin":
                    oChallenger.Win();
                    oFavori.Loose();
                    break;
            }

            // Faire une mise à jour du tableau
            dtgBoard.DataSource = Object.Board.GetAll();


        }

        private void frmBoard_Load(object sender, EventArgs e)
        {
            try
            {
                //Chargement de la datagrid
                dtgBoard.DataSource = Object.Board.GetAll();
            }
            finally
            {

            }
            
        }
    }
}
