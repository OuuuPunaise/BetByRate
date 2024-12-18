using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BetByRate.Object
{
    public class Challenger
    {
        #region Attributes
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

        private bool? _Vainqueur;
        public bool? Vainqueur
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
        public Challenger() { }
        public Challenger(int intIdChallenger)
        {
            string strSqlQuery = string.Empty;
            try
            {
                strSqlQuery = "SELECT IdChallenger, CoteExacte, Vainqueur, IdProtagoniste FROM Challenger " +
                    "Where IdChallenger = " + intIdChallenger.ToString();

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
                strSqlQuery = "INSERT INTO Challenger (CoteExacte,Vainqueur,IdProtagoniste) VALUES (" +
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

                oSqlCommand.Parameters.Add("@ID", SqlDbType.BigInt).Direction = ParameterDirection.Output;

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
                strSqlQuery = "DELETE FROM Challenger " +
                    "WHERE IdChallenger = @IdChallenger";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@IdChallenger", IdChallenger);

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
                strSqlQuery = "UPDATE Challenger Set Vainqueur = 1 " +
                    "WHERE IdChallenger = @IdChallenger";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@IdChallenger", IdChallenger);

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
                strSqlQuery = "UPDATE Challenger Set Vainqueur = 0 " +
                    "WHERE IdChallenger = @IdChallenger";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@IdChallenger", IdChallenger);

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
                    IdChallenger = (int)oSqlDataReader[0];
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
