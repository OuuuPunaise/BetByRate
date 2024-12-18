namespace BetByRate
{
    partial class frmMatch
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblJoueur1 = new System.Windows.Forms.Label();
            this.lblJoueur2 = new System.Windows.Forms.Label();
            this.lblCote = new System.Windows.Forms.Label();
            this.tbxCoteJoueur1 = new System.Windows.Forms.TextBox();
            this.tbxCoteJoueur2 = new System.Windows.Forms.TextBox();
            this.lblSport = new System.Windows.Forms.Label();
            this.cbxSport = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.grbMatch = new System.Windows.Forms.GroupBox();
            this.cbxJoueur1 = new System.Windows.Forms.ComboBox();
            this.cbxJoueur2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCompetition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbMatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(486, 17);
            this.pnlTop.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(222, 89);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 15);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date du match *";
            // 
            // lblJoueur1
            // 
            this.lblJoueur1.AutoSize = true;
            this.lblJoueur1.Location = new System.Drawing.Point(26, 43);
            this.lblJoueur1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJoueur1.Name = "lblJoueur1";
            this.lblJoueur1.Size = new System.Drawing.Size(59, 15);
            this.lblJoueur1.TabIndex = 8;
            this.lblJoueur1.Text = "Joueur 1 *";
            // 
            // lblJoueur2
            // 
            this.lblJoueur2.AutoSize = true;
            this.lblJoueur2.Location = new System.Drawing.Point(26, 74);
            this.lblJoueur2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJoueur2.Name = "lblJoueur2";
            this.lblJoueur2.Size = new System.Drawing.Size(59, 15);
            this.lblJoueur2.TabIndex = 9;
            this.lblJoueur2.Text = "Joueur 2 *";
            // 
            // lblCote
            // 
            this.lblCote.AutoSize = true;
            this.lblCote.Location = new System.Drawing.Point(282, 16);
            this.lblCote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCote.Name = "lblCote";
            this.lblCote.Size = new System.Drawing.Size(40, 15);
            this.lblCote.TabIndex = 12;
            this.lblCote.Text = "Cote *";
            // 
            // tbxCoteJoueur1
            // 
            this.tbxCoteJoueur1.Enabled = false;
            this.tbxCoteJoueur1.Location = new System.Drawing.Point(248, 39);
            this.tbxCoteJoueur1.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCoteJoueur1.Name = "tbxCoteJoueur1";
            this.tbxCoteJoueur1.Size = new System.Drawing.Size(106, 23);
            this.tbxCoteJoueur1.TabIndex = 6;
            this.tbxCoteJoueur1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCoteJoueur1_KeyPress);
            // 
            // tbxCoteJoueur2
            // 
            this.tbxCoteJoueur2.Enabled = false;
            this.tbxCoteJoueur2.Location = new System.Drawing.Point(248, 74);
            this.tbxCoteJoueur2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCoteJoueur2.Name = "tbxCoteJoueur2";
            this.tbxCoteJoueur2.Size = new System.Drawing.Size(106, 23);
            this.tbxCoteJoueur2.TabIndex = 7;
            this.tbxCoteJoueur2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCoteJoueur2_KeyPress);
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(22, 52);
            this.lblSport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(43, 15);
            this.lblSport.TabIndex = 15;
            this.lblSport.Text = "Sport *";
            // 
            // cbxSport
            // 
            this.cbxSport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSport.FormattingEnabled = true;
            this.cbxSport.Location = new System.Drawing.Point(83, 50);
            this.cbxSport.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSport.Name = "cbxSport";
            this.cbxSport.Size = new System.Drawing.Size(129, 23);
            this.cbxSport.TabIndex = 1;
            this.cbxSport.SelectedIndexChanged += new System.EventHandler(this.cbxSport_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(152, 257);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(78, 35);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(270, 257);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(78, 35);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(66, 28);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(13, 15);
            this.lblMessage.TabIndex = 20;
            this.lblMessage.Text = "x";
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(326, 88);
            this.mtbDate.Margin = new System.Windows.Forms.Padding(2);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(129, 23);
            this.mtbDate.TabIndex = 3;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // grbMatch
            // 
            this.grbMatch.CausesValidation = false;
            this.grbMatch.Controls.Add(this.cbxJoueur1);
            this.grbMatch.Controls.Add(this.cbxJoueur2);
            this.grbMatch.Controls.Add(this.lblJoueur1);
            this.grbMatch.Controls.Add(this.lblJoueur2);
            this.grbMatch.Controls.Add(this.tbxCoteJoueur1);
            this.grbMatch.Controls.Add(this.tbxCoteJoueur2);
            this.grbMatch.Controls.Add(this.lblCote);
            this.grbMatch.Location = new System.Drawing.Point(50, 122);
            this.grbMatch.Margin = new System.Windows.Forms.Padding(2);
            this.grbMatch.Name = "grbMatch";
            this.grbMatch.Padding = new System.Windows.Forms.Padding(2);
            this.grbMatch.Size = new System.Drawing.Size(382, 121);
            this.grbMatch.TabIndex = 19;
            this.grbMatch.TabStop = false;
            this.grbMatch.Text = "Match";
            // 
            // cbxJoueur1
            // 
            this.cbxJoueur1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxJoueur1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxJoueur1.Enabled = false;
            this.cbxJoueur1.FormattingEnabled = true;
            this.cbxJoueur1.Location = new System.Drawing.Point(102, 38);
            this.cbxJoueur1.Margin = new System.Windows.Forms.Padding(2);
            this.cbxJoueur1.Name = "cbxJoueur1";
            this.cbxJoueur1.Size = new System.Drawing.Size(129, 23);
            this.cbxJoueur1.TabIndex = 4;
            // 
            // cbxJoueur2
            // 
            this.cbxJoueur2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxJoueur2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxJoueur2.Enabled = false;
            this.cbxJoueur2.FormattingEnabled = true;
            this.cbxJoueur2.Location = new System.Drawing.Point(102, 73);
            this.cbxJoueur2.Margin = new System.Windows.Forms.Padding(2);
            this.cbxJoueur2.Name = "cbxJoueur2";
            this.cbxJoueur2.Size = new System.Drawing.Size(129, 23);
            this.cbxJoueur2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 23;
            // 
            // cbxCompetition
            // 
            this.cbxCompetition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCompetition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCompetition.Enabled = false;
            this.cbxCompetition.FormattingEnabled = true;
            this.cbxCompetition.Location = new System.Drawing.Point(326, 50);
            this.cbxCompetition.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCompetition.Name = "cbxCompetition";
            this.cbxCompetition.Size = new System.Drawing.Size(129, 23);
            this.cbxCompetition.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Competition *";
            // 
            // frmMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 308);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCompetition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.grbMatch);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbxSport);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMatch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMatch_Load);
            this.grbMatch.ResumeLayout(false);
            this.grbMatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlTop;
        private Label lblDate;
        private Label lblJoueur1;
        private Label lblJoueur2;
        private Label lblCote;
        private TextBox tbxCoteJoueur1;
        private TextBox tbxCoteJoueur2;
        private Label lblSport;
        private ComboBox cbxSport;
        private Button btnAjouter;
        private Button btnFermer;
        private Label lblMessage;
        private MaskedTextBox mtbDate;
        private GroupBox grbMatch;
        private ComboBox cbxJoueur1;
        private ComboBox cbxJoueur2;
        private Label label1;
        private ComboBox cbxCompetition;
        private Label label2;
    }
}