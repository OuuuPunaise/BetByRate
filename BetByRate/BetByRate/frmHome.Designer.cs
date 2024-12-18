namespace BetByRate
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnUtilisateur = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnProtagoniste = new System.Windows.Forms.Button();
            this.btnCompetition = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlLeft.Controls.Add(this.btnTest);
            this.pnlLeft.Controls.Add(this.btnUtilisateur);
            this.pnlLeft.Controls.Add(this.btnFermer);
            this.pnlLeft.Controls.Add(this.btnProtagoniste);
            this.pnlLeft.Controls.Add(this.btnCompetition);
            this.pnlLeft.Controls.Add(this.btnMatch);
            this.pnlLeft.Controls.Add(this.ptbLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(105, 464);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnUtilisateur.Location = new System.Drawing.Point(3, 210);
            this.btnUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Size = new System.Drawing.Size(95, 26);
            this.btnUtilisateur.TabIndex = 4;
            this.btnUtilisateur.Text = "Utilisateur";
            this.btnUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilisateur.UseVisualStyleBackColor = true;
            this.btnUtilisateur.Click += new System.EventHandler(this.btnUtilisateur_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(11, 427);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(78, 26);
            this.btnFermer.TabIndex = 0;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnProtagoniste
            // 
            this.btnProtagoniste.FlatAppearance.BorderSize = 0;
            this.btnProtagoniste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProtagoniste.ForeColor = System.Drawing.Color.White;
            this.btnProtagoniste.Location = new System.Drawing.Point(2, 143);
            this.btnProtagoniste.Margin = new System.Windows.Forms.Padding(2);
            this.btnProtagoniste.Name = "btnProtagoniste";
            this.btnProtagoniste.Size = new System.Drawing.Size(95, 26);
            this.btnProtagoniste.TabIndex = 3;
            this.btnProtagoniste.Text = "Protagoniste";
            this.btnProtagoniste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProtagoniste.UseVisualStyleBackColor = true;
            this.btnProtagoniste.Click += new System.EventHandler(this.btnProtagoniste_Click);
            // 
            // btnCompetition
            // 
            this.btnCompetition.FlatAppearance.BorderSize = 0;
            this.btnCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetition.ForeColor = System.Drawing.Color.White;
            this.btnCompetition.Location = new System.Drawing.Point(3, 113);
            this.btnCompetition.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompetition.Name = "btnCompetition";
            this.btnCompetition.Size = new System.Drawing.Size(95, 26);
            this.btnCompetition.TabIndex = 2;
            this.btnCompetition.Text = "Competition";
            this.btnCompetition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetition.UseVisualStyleBackColor = true;
            this.btnCompetition.Click += new System.EventHandler(this.btnCompetition_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.FlatAppearance.BorderSize = 0;
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.ForeColor = System.Drawing.Color.White;
            this.btnMatch.Location = new System.Drawing.Point(2, 83);
            this.btnMatch.Margin = new System.Windows.Forms.Padding(2);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(95, 26);
            this.btnMatch.TabIndex = 0;
            this.btnMatch.Text = "Match";
            this.btnMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(3, 2);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(95, 61);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 2;
            this.ptbLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.IndianRed;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(105, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(838, 13);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(105, 13);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(838, 451);
            this.pnlContent.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(2, 291);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(95, 26);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 464);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLeft;
        private Button btnCompetition;
        private Panel pnlTop;
        private Button btnProtagoniste;
        private PictureBox ptbLogo;
        private Panel pnlContent;
        private Button btnFermer;
        private Button btnMatch;
        private Button btnUtilisateur;
        private Button btnTest;
    }
}