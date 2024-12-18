namespace BetByRate
{
    partial class frmProtagoniste
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rdbHomme = new System.Windows.Forms.RadioButton();
            this.rdbFemme = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSport = new System.Windows.Forms.Label();
            this.cbxSport = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(399, 17);
            this.pnlTop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROTAGONISTE";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(87, 91);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 15);
            this.lblNom.TabIndex = 24;
            this.lblNom.Text = "Nom *";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(87, 124);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 15);
            this.lblPrenom.TabIndex = 25;
            this.lblPrenom.Text = "Prenom";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(179, 89);
            this.txbNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(136, 23);
            this.txbNom.TabIndex = 2;
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(179, 122);
            this.txbPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(136, 23);
            this.txbPrenom.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(108, 209);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(78, 26);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(212, 209);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(78, 26);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(40, 25);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(13, 15);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "x";
            // 
            // rdbHomme
            // 
            this.rdbHomme.AutoSize = true;
            this.rdbHomme.Location = new System.Drawing.Point(28, 13);
            this.rdbHomme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbHomme.Name = "rdbHomme";
            this.rdbHomme.Size = new System.Drawing.Size(69, 19);
            this.rdbHomme.TabIndex = 7;
            this.rdbHomme.TabStop = true;
            this.rdbHomme.Text = "Homme";
            this.rdbHomme.UseVisualStyleBackColor = true;
            // 
            // rdbFemme
            // 
            this.rdbFemme.AutoSize = true;
            this.rdbFemme.Location = new System.Drawing.Point(135, 13);
            this.rdbFemme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFemme.Name = "rdbFemme";
            this.rdbFemme.Size = new System.Drawing.Size(65, 19);
            this.rdbFemme.TabIndex = 8;
            this.rdbFemme.TabStop = true;
            this.rdbFemme.Text = "Femme";
            this.rdbFemme.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbFemme);
            this.panel1.Controls.Add(this.rdbHomme);
            this.panel1.Location = new System.Drawing.Point(87, 151);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 45);
            this.panel1.TabIndex = 27;
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(87, 59);
            this.lblSport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(35, 15);
            this.lblSport.TabIndex = 16;
            this.lblSport.Text = "Sport";
            // 
            // cbxSport
            // 
            this.cbxSport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSport.FormattingEnabled = true;
            this.cbxSport.Location = new System.Drawing.Point(179, 58);
            this.cbxSport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSport.Name = "cbxSport";
            this.cbxSport.Size = new System.Drawing.Size(136, 23);
            this.cbxSport.TabIndex = 1;
            this.cbxSport.SelectedIndexChanged += new System.EventHandler(this.cbxSport_SelectedIndexChanged);
            // 
            // frmProtagoniste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 269);
            this.ControlBox = false;
            this.Controls.Add(this.cbxSport);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txbPrenom);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProtagoniste";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProtagoniste_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlTop;
        private Label label1;
        private Label lblNom;
        private Label lblPrenom;
        private TextBox txbNom;
        private TextBox txbPrenom;
        private Button btnAjouter;
        private Button btnFermer;
        private Label lblMessage;
        private RadioButton rdbHomme;
        private RadioButton rdbFemme;
        private Panel panel1;
        private Label lblSport;
        private ComboBox cbxSport;
    }
}