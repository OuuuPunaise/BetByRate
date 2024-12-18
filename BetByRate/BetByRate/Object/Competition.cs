using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BetByRate.Object
{
    public class Competition
    {
        #region Attributes
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

        private string? _Nom;
        public string? Nom
        {
            get
            {
                return _Nom;
            }
            set
            {
                _Nom = value;
            }
        }

        private int _IdSurface;
        public int IdSurface
        {
            get
            {
                return _IdSurface;
            }
            set
            {
                _IdSurface = value;
            }
        }

        private int _IdCategorie;
        public int IdCategorie
        {
            get
            {
                return _IdCategorie;
            }
            set
            {
                _IdCategorie = value;
            }
        }

        private int _IdSport;
        public int IdSport
        {
            get
            {
                return _IdSport;
            }
            set
            {
                _IdSport = value;
            }
        }

        #endregion

        #region Methode

        //Constructeur
        public Competition() { }
        public Competition(long lgIdCompetition)
        {
            string strSqlQuery = string.Empty;
            try
            {
                strSqlQuery = "SELECT IdCompetition, Nom FROM Competition " +
                    "Where IdCompetition = " + lgIdCompetition.ToString();
            }
            finally
            {
            }
        }

        public static DataTable GetBySport(int intIdSport)
        {
            Db oDb = null;
            SqlCommand oSqlCommand = null;
            string strSqlQuery = null;
            SqlDataReader oSqlDataReader = null;
            //List<Surface> oList = null;
            var dataTable = new DataTable();

            try
            {
                // Open connection
                oDb = new Db();

                strSqlQuery = "SELECT idCOmpetition, Nom FROM Competition " +
                    "WHERE IdSport = " + intIdSport.ToString();

                //Execute the request
                oSqlCommand = new SqlCommand(strSqlQuery, oDb.oSqlConn);
                oSqlDataReader = oSqlCommand.ExecuteReader();

                // Get result
                dataTable.Load(oSqlDataReader);

            }
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
            return dataTable;
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
                strSqlQuery = "INSERT INTO Competition (Nom,IdSurface,IdCategorie, IdSport) VALUES (" +
                    "@Nom, " +
                    "@IdSurface, " +
                    "@IdCategorie, " +
                    "@IdSport) ";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@Nom", Nom);
                oSqlCommand.Parameters.AddWithValue("@IdSport", IdSport);

                if (IdSurface == 0)
                    oSqlCommand.Parameters.AddWithValue("@IdSurface", DBNull.Value);         
                else
                    oSqlCommand.Parameters.AddWithValue("@IdSurface", IdSurface);
                
                if (IdCategorie ==0)
                    oSqlCommand.Parameters.AddWithValue("@IdCategorie", DBNull.Value);
                else
                    oSqlCommand.Parameters.AddWithValue("@IdCategorie", IdCategorie);
                

                //Execute the request
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

        #endregion
    }
}
