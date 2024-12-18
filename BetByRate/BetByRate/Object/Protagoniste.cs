using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BetByRate.Object
{
    public class Protagoniste
    {
        #region Attributes
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

        private string? _Prenom;
        public string? Prenom
        {
            get
            {
                return _Prenom;
            }
            set
            {
                _Prenom = value;
            }
        }

        private bool _Homme;
        public bool Homme
        {
            get
            {
                return _Homme;
            }
            set
            {
                _Homme = value;
            }
        }

        private bool _Femme;
        public bool Femme
        {
            get
            {
                return _Femme;
            }
            set
            {
                _Femme = value;
            }
        }

        private bool _Actif;
        public bool Actif
        {
            get
            {
                return _Actif;
            }
            set
            {
                _Actif = value;
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
        public Protagoniste() { }
        public Protagoniste(long lgIdProtagoniste)
        {
            string strSqlQuery = string.Empty;
            try
            {
                strSqlQuery = "SELECT IdProtagoniste, Nom, Prenom, Homme, Femme, Actif, IdSport FROM Protagoniste " +
                    "Where IdProtagoniste = " + lgIdProtagoniste.ToString();

                //Execute the query
                //Configure(strSqlQuery);
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
                strSqlQuery = "INSERT INTO Protagoniste (Nom,Prenom,Homme, Femme, Actif, IdSport) VALUES (" +
                    "@Nom, " +
                    "@Prenom, " +
                    "@Homme, " +
                    "@Femme, " +
                    "@Actif, " +
                    "@IdSport)";

                oSqlCommand = oDb.oSqlConn.CreateCommand();

                // Parameters
                oSqlCommand.Parameters.AddWithValue("@Nom", Nom);
                oSqlCommand.Parameters.AddWithValue("@Prenom", Prenom);
                oSqlCommand.Parameters.AddWithValue("@Homme", Homme);
                oSqlCommand.Parameters.AddWithValue("@Femme", Femme);
                oSqlCommand.Parameters.AddWithValue("@Actif", Actif);
                oSqlCommand.Parameters.AddWithValue("@IdSport", IdSport);

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

                strSqlQuery = "SELECT idProtagoniste, Nom + ', ' + Prenom as Nom FROM Protagoniste " +
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

        #endregion
    }
}
