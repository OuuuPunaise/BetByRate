namespace BetByRate
{
    partial class frmBoard
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblCompetition = new System.Windows.Forms.Label();
            this.dtgBoard = new System.Windows.Forms.DataGridView();
            this.boardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateMatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournoisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFavoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomChallengerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coteFavoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coteChallengerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFavoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idChallengerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFavoriWin = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnChallengerWin = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.lblCompetition);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(836, 17);
            this.pnlTop.TabIndex = 3;
            // 
            // lblCompetition
            // 
            this.lblCompetition.AutoSize = true;
            this.lblCompetition.ForeColor = System.Drawing.Color.White;
            this.lblCompetition.Location = new System.Drawing.Point(2, 1);
            this.lblCompetition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompetition.Name = "lblCompetition";
            this.lblCompetition.Size = new System.Drawing.Size(46, 15);
            this.lblCompetition.TabIndex = 3;
            this.lblCompetition.Text = "BOARD";
            // 
            // dtgBoard
            // 
            this.dtgBoard.AutoGenerateColumns = false;
            this.dtgBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateMatchDataGridViewTextBoxColumn,
            this.tournoisDataGridViewTextBoxColumn,
            this.nomFavoriDataGridViewTextBoxColumn,
            this.nomChallengerDataGridViewTextBoxColumn,
            this.coteFavoriDataGridViewTextBoxColumn,
            this.coteChallengerDataGridViewTextBoxColumn,
            this.idMatchDataGridViewTextBoxColumn,
            this.idFavoriDataGridViewTextBoxColumn,
            this.idChallengerDataGridViewTextBoxColumn,
            this.btnFavoriWin,
            this.btnChallengerWin,
            this.btnDelete});
            this.dtgBoard.DataSource = this.boardBindingSource;
            this.dtgBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgBoard.Location = new System.Drawing.Point(0, 17);
            this.dtgBoard.Margin = new System.Windows.Forms.Padding(2);
            this.dtgBoard.Name = "dtgBoard";
            this.dtgBoard.RowHeadersWidth = 62;
            this.dtgBoard.RowTemplate.Height = 33;
            this.dtgBoard.Size = new System.Drawing.Size(836, 253);
            this.dtgBoard.TabIndex = 4;
            this.dtgBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBoard_CellContentClick);
            // 
            // boardBindingSource
            // 
            this.boardBindingSource.DataSource = typeof(BetByRate.Object.Board);
            // 
            // boardBindingSource1
            // 
            this.boardBindingSource1.DataSource = typeof(BetByRate.Object.Board);
            // 
            // dateMatchDataGridViewTextBoxColumn
            // 
            this.dateMatchDataGridViewTextBoxColumn.DataPropertyName = "DateMatch";
            this.dateMatchDataGridViewTextBoxColumn.HeaderText = "DateMatch";
            this.dateMatchDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateMatchDataGridViewTextBoxColumn.Name = "dateMatchDataGridViewTextBoxColumn";
            this.dateMatchDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateMatchDataGridViewTextBoxColumn.Width = 70;
            // 
            // tournoisDataGridViewTextBoxColumn
            // 
            this.tournoisDataGridViewTextBoxColumn.DataPropertyName = "Tournois";
            this.tournoisDataGridViewTextBoxColumn.HeaderText = "Tournois";
            this.tournoisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tournoisDataGridViewTextBoxColumn.Name = "tournoisDataGridViewTextBoxColumn";
            this.tournoisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomFavoriDataGridViewTextBoxColumn
            // 
            this.nomFavoriDataGridViewTextBoxColumn.DataPropertyName = "NomFavori";
            this.nomFavoriDataGridViewTextBoxColumn.HeaderText = "NomFavori";
            this.nomFavoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomFavoriDataGridViewTextBoxColumn.Name = "nomFavoriDataGridViewTextBoxColumn";
            this.nomFavoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomFavoriDataGridViewTextBoxColumn.Width = 110;
            // 
            // nomChallengerDataGridViewTextBoxColumn
            // 
            this.nomChallengerDataGridViewTextBoxColumn.DataPropertyName = "NomChallenger";
            this.nomChallengerDataGridViewTextBoxColumn.HeaderText = "NomChallenger";
            this.nomChallengerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomChallengerDataGridViewTextBoxColumn.Name = "nomChallengerDataGridViewTextBoxColumn";
            this.nomChallengerDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomChallengerDataGridViewTextBoxColumn.Width = 110;
            // 
            // coteFavoriDataGridViewTextBoxColumn
            // 
            this.coteFavoriDataGridViewTextBoxColumn.DataPropertyName = "CoteFavori";
            this.coteFavoriDataGridViewTextBoxColumn.HeaderText = "CoteFavori";
            this.coteFavoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coteFavoriDataGridViewTextBoxColumn.Name = "coteFavoriDataGridViewTextBoxColumn";
            this.coteFavoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.coteFavoriDataGridViewTextBoxColumn.Width = 95;
            // 
            // coteChallengerDataGridViewTextBoxColumn
            // 
            this.coteChallengerDataGridViewTextBoxColumn.DataPropertyName = "CoteChallenger";
            this.coteChallengerDataGridViewTextBoxColumn.HeaderText = "CoteChallenger";
            this.coteChallengerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coteChallengerDataGridViewTextBoxColumn.Name = "coteChallengerDataGridViewTextBoxColumn";
            this.coteChallengerDataGridViewTextBoxColumn.ReadOnly = true;
            this.coteChallengerDataGridViewTextBoxColumn.Width = 95;
            // 
            // idMatchDataGridViewTextBoxColumn
            // 
            this.idMatchDataGridViewTextBoxColumn.DataPropertyName = "IdMatch";
            this.idMatchDataGridViewTextBoxColumn.HeaderText = "IdMatch";
            this.idMatchDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idMatchDataGridViewTextBoxColumn.Name = "idMatchDataGridViewTextBoxColumn";
            this.idMatchDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMatchDataGridViewTextBoxColumn.Visible = false;
            this.idMatchDataGridViewTextBoxColumn.Width = 150;
            // 
            // idFavoriDataGridViewTextBoxColumn
            // 
            this.idFavoriDataGridViewTextBoxColumn.DataPropertyName = "IdFavori";
            this.idFavoriDataGridViewTextBoxColumn.HeaderText = "IdFavori";
            this.idFavoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idFavoriDataGridViewTextBoxColumn.Name = "idFavoriDataGridViewTextBoxColumn";
            this.idFavoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFavoriDataGridViewTextBoxColumn.Visible = false;
            this.idFavoriDataGridViewTextBoxColumn.Width = 140;
            // 
            // idChallengerDataGridViewTextBoxColumn
            // 
            this.idChallengerDataGridViewTextBoxColumn.DataPropertyName = "IdChallenger";
            this.idChallengerDataGridViewTextBoxColumn.HeaderText = "IdChallenger";
            this.idChallengerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idChallengerDataGridViewTextBoxColumn.Name = "idChallengerDataGridViewTextBoxColumn";
            this.idChallengerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idChallengerDataGridViewTextBoxColumn.Visible = false;
            this.idChallengerDataGridViewTextBoxColumn.Width = 120;
            // 
            // btnFavoriWin
            // 
            this.btnFavoriWin.HeaderText = "FavWin";
            this.btnFavoriWin.MinimumWidth = 8;
            this.btnFavoriWin.Name = "btnFavoriWin";
            this.btnFavoriWin.Text = "FavWin";
            this.btnFavoriWin.UseColumnTextForButtonValue = true;
            this.btnFavoriWin.Width = 60;
            // 
            // btnChallengerWin
            // 
            this.btnChallengerWin.HeaderText = "ChalWin";
            this.btnChallengerWin.MinimumWidth = 8;
            this.btnChallengerWin.Name = "btnChallengerWin";
            this.btnChallengerWin.Text = "ChalWin";
            this.btnChallengerWin.UseColumnTextForButtonValue = true;
            this.btnChallengerWin.Width = 60;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.MinimumWidth = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 60;
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 270);
            this.ControlBox = false;
            this.Controls.Add(this.dtgBoard);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBoard_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTop;
        private Label lblCompetition;
        private DataGridView dtgBoard;
        private BindingSource boardBindingSource;
        private BindingSource boardBindingSource1;
        private DataGridViewTextBoxColumn dateMatchDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tournoisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomFavoriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomChallengerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coteFavoriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coteChallengerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idMatchDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idFavoriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idChallengerDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn btnFavoriWin;
        private DataGridViewButtonColumn btnChallengerWin;
        private DataGridViewButtonColumn btnDelete;
    }
}