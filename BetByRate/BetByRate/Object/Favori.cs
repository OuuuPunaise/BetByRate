using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BetByRate.Object
{
    public class Favori
    {
        #region Attributes
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

        private decimal _CoteExacte;
        public decimal CoteExacte
        {
            get
            {
                return _CoteExacte;
            }
            set
            {
                _CoteExacte = value;
            }
        }

        private int _IdProtagoniste;
        public int IdProtagoniste
        {
            get
            {
                return _IdProtagoniste;
            }
            set
            {
                _IdProtagoniste = value;
            }
        }

        private Nullable<bool> _Vainqueur;
        public Nullable<bool> Vainqueur
        {
            get
            {
                return _Vainqueur;
            }
            set
            {
                _Vainqueur = value;
            }
        }
        #endregion

        #region Methode
        //Constructeur
        public Favori() { }
        public Favori(int intIdFavori)
        {
            string strSqlQuery = string.Empty;
            try
            {
                strSqlQuery = "SELECT IdFavori, CoteExacte, Vainqueur, IdProtagoniste FROM Favori " +
                    "Where IdFavori = " + intIdFavori.ToString();

                //Execute the query
                Configure(strSqlQuery);
            }
            finally
            {
            }
        }

        public int Insert()
        {
            Db oDb = null;
            SqlCommand oSqlCommand = null;
            string strSqlQuery = null;
            int intNewId = 0;

            try
            {
                // Open connection
                oDb = new Db();

                // Update request
                strSqlQuery = "INSERT INTO Favori (CoteExacte,Vainqueur,IdProtagoniste) VALUES (" +
                    "@CoteExacte, " +
                    "@Vainqueur, " +
                    "@IdProtagoniste) SET @ID = SCOPE_IDENTITY()";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@CoteExacte", CoteExacte);
                oSqlCommand.Parameters.AddWithValue("@IdProtagoniste", IdProtagoniste);

                if (Vainqueur == null)
                    oSqlCommand.Parameters.AddWithValue("@Vainqueur", DBNull.Value);
                else
                    oSqlCommand.Parameters.AddWithValue("@Vainqueur", Vainqueur);

                oSqlCommand.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;

                //Execute the request
                oSqlCommand.CommandText = strSqlQuery;
                oSqlCommand.ExecuteNonQuery();

                // Recupération de l'ID
                intNewId = Convert.ToInt32(oSqlCommand.Parameters["@ID"].Value);
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
            return intNewId;
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
                strSqlQuery = "DELETE FROM Favori " +
                    "WHERE IdFavori = @IdFavori";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@IdFavori", IdFavori);

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
        public void Win()
        {
            Db oDb = null;
            SqlCommand oSqlCommand = null;
            string strSqlQuery = null;

            try
            {
                // Open connection
                oDb = new Db();

                // Delete query
                strSqlQuery = "UPDATE Favori Set Vainqueur = 1 " +
                    "WHERE IdFavori = @IdFavori";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@IdFavori", IdFavori);

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
        public void Loose()
        {
            Db oDb = null;
            SqlCommand oSqlCommand = null;
            string strSqlQuery = null;

            try
            {
                // Open connection
                oDb = new Db();

                // Delete query
                strSqlQuery = "UPDATE Favori Set Vainqueur = 0 " +
                    "WHERE IdFavori = @IdFavori";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@IdFavori", IdFavori);

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
                    IdFavori = (int)oSqlDataReader[0];
                    CoteExacte = (decimal)oSqlDataReader[1];

                    if (oSqlDataReader[2] == DBNull.Value)
                        Vainqueur = null;
                    else
                        Vainqueur = (bool)oSqlDataReader[2];

                    IdProtagoniste = (int)oSqlDataReader[3];
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
