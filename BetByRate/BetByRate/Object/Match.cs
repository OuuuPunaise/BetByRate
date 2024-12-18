using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BetByRate.Object
{
    public class Match
    {
        #region Attributes
        private int _IdMatch;
        public int IdMatch
        {
            get
            {
                return _IdMatch;
            }
            set
            {
                _IdMatch = value;
            }
        }

        private DateTime _DateMatch;
        public DateTime DateMatch
        {
            get
            {
                return _DateMatch;
            }
            set
            {
                _DateMatch = value;
            }
        }

        private int _IdFavori;
        public int IdFavori
        {
            get
            {
                return _IdFavori;
            }
            set
            {
                _IdFavori = value;
            }
        }

        private int _IdChallenger;
        public int IdChallenger
        {
            get
            {
                return _IdChallenger;
            }
            set
            {
                _IdChallenger = value;
            }
        }

        private int _IdCompetition;
        public int IdCompetition
        {
            get
            {
                return _IdCompetition;
            }
            set
            {
                _IdCompetition = value;
            }
        }

        private int _IdFourchette;
        public int IdFourchette
        {
            get
            {
                return _IdFourchette;
            }
            set
            {
                _IdFourchette = value;
            }
        }

        private int _IdUtilisateur;
        public int IdUtilisateur
        {
            get
            {
                return _IdUtilisateur;
            }
            set
            {
                _IdUtilisateur = value;
            }
        }

        #endregion

        #region Methode
        //Constructeur
        public Match() { }
        public Match(int intIdMatch)
        {
            string strSqlQuery = string.Empty;
            try
            {
                strSqlQuery = "SELECT IdMatch, DateMatch, IdFavori, IdChallenger, IdCompetition, IdFourchette, IdUtilisateur FROM Match " +
                    "Where IdMatch = " + intIdMatch.ToString();

                //Execute the query
                Configure(strSqlQuery);

            }
            finally
            {
            }
        }

        public void Insert()
        {
            Db oDb = null;
            SqlCommand oSqlCommand = null;
            string strSqlQuery = null;

            try
            {
                // Open connection
                oDb = new Db();

                // Update request
                strSqlQuery = "INSERT INTO Match (DateMatch,IdFavori,IdChallenger, IdCompetition, IdFourchette, IdUtilisateur) VALUES (" +
                    "@DateMatch, " +
                    "@IdFavori, " +
                    "@IdChallenger, " +
                    "@IdCompetition, " +
                    "@IdFourchette, " +
                    "@IdUtilisateur)";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@DateMatch", DateMatch);
                oSqlCommand.Parameters.AddWithValue("@IdFavori", IdFavori);
                oSqlCommand.Parameters.AddWithValue("@IdChallenger", IdChallenger);
                oSqlCommand.Parameters.AddWithValue("@IdCompetition", IdCompetition);
                oSqlCommand.Parameters.AddWithValue("@IdFourchette", IdFourchette);
                oSqlCommand.Parameters.AddWithValue("@IdUtilisateur", IdUtilisateur);

                //Execute the request
                oSqlCommand.CommandText = strSqlQuery;
                oSqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (oSqlCommand != null)
                {
                    oSqlCommand.Dispose();
                    oSqlCommand = null;
                }
                if (oDb != null)
                {
                    oDb.Close();
                    oDb = null;
                }
            }
        }

        public void Delete()
        {
            Db oDb = null;
            SqlCommand oSqlCommand = null;
            string strSqlQuery = null;

            try
            {
                // Open connection
                oDb = new Db();

                // Delete query
                strSqlQuery = "DELETE FROM Match " +
                    "WHERE IdMatch = @IdMatch";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@IdMatch", IdMatch);

                //Execute the query
                oSqlCommand.CommandText = strSqlQuery;
                oSqlCommand.ExecuteNonQuery();
            }
            // Not catch to interrupt all the process in case of an error
            finally
            {
                if (oSqlCommand != null)
                {
                    oSqlCommand.Dispose();
                    oSqlCommand = null;
                }
                if (oDb != null)
                {
                    oDb.Close();
                    oDb = null;
                }
            }
        }

        protected void Configure(string strSqlQuery)
        {
            Db oDb = null;
            SqlCommand oSqlCommand = null;
            SqlDataReader oSqlDataReader = null;

            try
            {
                // Open connection
                oDb = new Db();

                //Execute the query
                oSqlCommand = new SqlCommand(strSqlQuery, oDb.oSqlConn);
                oSqlDataReader = oSqlCommand.ExecuteReader();

                // Read result
                while (oSqlDataReader.Read())
                {
                    this.IdMatch = (int)oSqlDataReader[0];
                    this.DateMatch = (DateTime)oSqlDataReader[1];
                    this.IdFavori = (int)oSqlDataReader[2];
                    this.IdChallenger = (int)oSqlDataReader[3];
                    this.IdCompetition = (int)oSqlDataReader[4];
                    this.IdFourchette = (int)oSqlDataReader[5];
                    this.IdUtilisateur = (int)oSqlDataReader[6];

                }
            }
            // Not catch to interrupt all the process in case of an error
            finally
            {
                if (oSqlCommand != null)
                {
                    oSqlCommand.Dispose();
                    oSqlCommand = null;
                }
                if (oSqlDataReader != null)
                {
                    oSqlDataReader.Close();
                    oSqlDataReader = null;
                }
                if (oDb != null)
                {
                    oDb.Close();
                    oDb = null;
                }
            }
        }




        #endregion
    }
}
