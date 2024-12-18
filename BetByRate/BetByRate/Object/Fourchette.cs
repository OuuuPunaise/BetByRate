using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BetByRate.Object
{
    public class Fourchette
    {
        #region Attributes
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

        private string? _Libelle;
        public string? Libelle
        {
            get
            {
                return _Libelle;
            }
            set
            {
                _Libelle = value;
            }
        }

        #endregion

        #region Methode
        //Constructeur
        public Fourchette() { }
        public Fourchette(long lgIdFourchette)
        {
            string strSqlQuery = string.Empty;
            try
            {
                strSqlQuery = "SELECT IdFourchette, Libelle FROM Fourchette " +
                    "Where IdFourchette = " + lgIdFourchette.ToString();
            }

            //Execute the query
            //Configure(strSqlQuery);

            finally
            {
            }
        }

        public static DataTable GetAll()
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

                strSqlQuery = "SELECT idFourchette, Libelle FROM Fourchette";

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
