namespace BetByRate
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCompetition_Click(object sender, EventArgs e)
        {
            try
            {

                frmCompetition comp = new frmCompetition();
                comp.TopLevel = false;
                pnlContent.Controls.Add(comp);
                comp.BringToFront();
                comp.Show();
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Probleme : {0}", ex.Source);
                throw;
            }
        }

        private void btnProtagoniste_Click(object sender, EventArgs e)
        {
            try
            {

                frmProtagoniste prot = new frmProtagoniste();
                prot.TopLevel = false;
                pnlContent.Controls.Add(prot);
                prot.BringToFront();
                prot.Show();
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

        private void btnMatch_Click(object sender, EventArgs e)
        {
            try
            {
                // Fermet le Board
                pnlContent.Controls.Clear();


                //Ouvrir le formulaire Match
                frmMatch match = new frmMatch();
                match.TopLevel = false;
                pnlContent.Controls.Add(match);
                match.BringToFront();
                match.Show();

                
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Probleme : {0}", ex.Source);
                throw;
            }
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            try
            {
                frmBoard Spo = new frmBoard();
                Spo.TopLevel = false;
                pnlContent.Controls.Add(Spo);
                Spo.BringToFront();
                Spo.Show();
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Probleme : {0}", ex.Source);
                throw;
            }
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            try
            {
                frmUtilisateur Util = new frmUtilisateur();
                Util.TopLevel = false;
                pnlContent.Controls.Add(Util);
                Util.BringToFront();
                Util.Show();
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Probleme : {0}", ex.Source);
                throw;
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            try
            {
                frmBoard Spo = new frmBoard();
                Spo.TopLevel = false;
                pnlContent.Controls.Add(Spo);
                Spo.BringToFront();
                Spo.Show();
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Probleme : {0}", ex.Source);
                throw;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //pnlContent.Controls.Clear();

        }
    }

}