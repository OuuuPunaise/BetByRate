namespace BetByRate
{
    partial class frmCompetition
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblCompetition = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblSurface = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.cbxSurface = new System.Windows.Forms.ComboBox();
            this.cbxCategorie = new System.Windows.Forms.ComboBox();
            this.lblSport = new System.Windows.Forms.Label();
            this.cbxSport = new System.Windows.Forms.ComboBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.lblCompetition);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(352, 17);
            this.pnlTop.TabIndex = 0;
            // 
            // lblCompetition
            // 
            this.lblCompetition.AutoSize = true;
            this.lblCompetition.ForeColor = System.Drawing.Color.White;
            this.lblCompetition.Location = new System.Drawing.Point(2, 1);
            this.lblCompetition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompetition.Name = "lblCompetition";
            this.lblCompetition.Size = new System.Drawing.Size(84, 15);
            this.lblCompetition.TabIndex = 3;
            this.lblCompetition.Text = "COMPETITION";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(40, 52);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom *";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSurface
            // 
            this.lblSurface.AutoSize = true;
            this.lblSurface.Location = new System.Drawing.Point(40, 115);
            this.lblSurface.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurface.Name = "lblSurface";
            this.lblSurface.Size = new System.Drawing.Size(46, 15);
            this.lblSurface.TabIndex = 0;
            this.lblSurface.Text = "Surface";
            this.lblSurface.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(40, 149);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(58, 15);
            this.lblCategorie.TabIndex = 0;
            this.lblCategorie.Text = "Categorie";
            this.lblCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(77, 204);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(77, 31);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(153, 51);
            this.txbNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(154, 23);
            this.txbNom.TabIndex = 1;
            // 
            // cbxSurface
            // 
            this.cbxSurface.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSurface.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSurface.Enabled = false;
            this.cbxSurface.FormattingEnabled = true;
            this.cbxSurface.Location = new System.Drawing.Point(153, 113);
            this.cbxSurface.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSurface.Name = "cbxSurface";
            this.cbxSurface.Size = new System.Drawing.Size(154, 23);
            this.cbxSurface.TabIndex = 3;
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCategorie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCategorie.Enabled = false;
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Location = new System.Drawing.Point(153, 149);
            this.cbxCategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(154, 23);
            this.cbxCategorie.TabIndex = 4;
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(39, 83);
            this.lblSport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(43, 15);
            this.lblSport.TabIndex = 5;
            this.lblSport.Text = "Sport *";
            this.lblSport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxSport
            // 
            this.cbxSport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSport.FormattingEnabled = true;
            this.cbxSport.Location = new System.Drawing.Point(153, 82);
            this.cbxSport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSport.Name = "cbxSport";
            this.cbxSport.Size = new System.Drawing.Size(154, 23);
            this.cbxSport.TabIndex = 2;
            this.cbxSport.SelectedIndexChanged += new System.EventHandler(this.cbxSport_SelectedIndexChanged);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(190, 204);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(78, 31);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(39, 26);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(13, 15);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "x";
            // 
            // frmCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 265);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.cbxSport);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.cbxCategorie);
            this.Controls.Add(this.cbxSurface);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblSurface);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCompetition";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCompetition_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlTop;
        private Label lblCompetition;
        private Label lblNom;
        private Label lblSurface;
        private Label lblCategorie;
        private Button btnAjouter;
        private TextBox txbNom;
        private ComboBox cbxSurface;
        private ComboBox cbxCategorie;
        private Label lblSport;
        private ComboBox cbxSport;
        private Button btnFermer;
        private Label lblMessage;
    }
}