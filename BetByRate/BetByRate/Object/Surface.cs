using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BetByRate.Object
{
    public class Surface
    {

        #region Attributes

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

        #region Methods
        public Surface() { }

        //Constructeur
        public Surface(long lgIdSurface)
        {
            string strSqlQuery = string.Empty;
            try
            {
                strSqlQuery = "SELECT IdSurface, Libelle FROM Suraface " +
                    "Where IdSurface = " + lgIdSurface.ToString();
            }
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

                strSqlQuery = "SELECT idSurface, Libelle FROM Surface";

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
