using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BetByRate.Object
{
    public class Board
    {
        #region Attributes


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

        private string? _Tournois;
        public string? Tournois
        {
            get
            {
                return _Tournois;
            }
            set
            {
                _Tournois = value;
            }
        }

        private string? _NomFavori;
        public string? NomFavori
        {
            get
            {
                return _NomFavori;
            }
            set
            {
                _NomFavori = value;
            }
        }

        private string? _NomChallenger;
        public string? NomChallenger
        {
            get
            {
                return _NomChallenger;
            }
            set
            {
                _NomChallenger = value;
            }
        }

        private decimal _CoteFavori;
        public decimal CoteFavori
        {
            get
            {
                return _CoteFavori;
            }
            set
            {
                _CoteFavori = value;
            }
        }

        private decimal _CoteChallenger;
        public decimal CoteChallenger
        {
            get
            {
                return _CoteChallenger;
            }
            set
            {
                _CoteChallenger = value;
            }
        }

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
        #endregion

        #region Methode

        //Constructeur
        public Board()
        {
        }

        public static List<Board> GetAll()
        {
            Db oDb = null;
            SqlCommand oSqlCommand = null;
            string strSqlQuery = null;
            SqlDataReader oSqlDataReader = null;
            List<Board> oList = null;
            string strStatus = null;

            try
            {
                // Open connection
                oDb = new Db();

                strSqlQuery = "SELECT mat.DateMatch , com.nom Tournois, " +
                "proFav.nom + ', ' + proFav.prenom Favori, " +
                "proCha.nom + ', ' + proCha.Prenom Challenger, " +
                "fav.CoteExacte CoteFavori, " +
                "cha.CoteExacte CoteChallenger, " +
                "Mat.idmatch, " +
                "Cha.idChallenger, " +
                "Fav.idFavori " +
                "FROM match mat " +
                "inner join Competition com on com.idcompetition = mat.idcompetition " +
                "inner join favori fav on fav.idfavori = mat.idfavori " +
                "inner join challenger cha on cha.idchallenger = mat.idchallenger " +
                "inner join protagoniste proFav on proFav.IdProtagoniste = fav.idProtagoniste " +
                "inner join protagoniste proCha on proCha.IdProtagoniste = cha.idProtagoniste " +
                "WHERE cha.Vainqueur is null and fav.Vainqueur is null " +
                "Order by mat.DateMatch";

                //Execute the request
                oSqlCommand = new SqlCommand(strSqlQuery, oDb.oSqlConn);
                oSqlDataReader = oSqlCommand.ExecuteReader();

                // Get result
                oList = ConfigureList(oSqlDataReader);
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
            return oList;
        }

        protected static List<Board> ConfigureList(SqlDataReader oSqlDataReader)
        {
            List<Board> oList = null;

            try
            {
                oList = new List<Board>();

                // Read result
                while (oSqlDataReader.Read())
                {
                    Board oBoard = new Board();
                    oBoard.DateMatch = (DateTime)oSqlDataReader[0];
                    oBoard.Tournois = (string)oSqlDataReader[1];
                    oBoard.NomFavori = (string)oSqlDataReader[2];
                    oBoard.NomChallenger = (string)oSqlDataReader[3];
                    oBoard.CoteFavori = (decimal)oSqlDataReader[4];
                    oBoard.CoteChallenger = (decimal)oSqlDataReader[5];
                    oBoard.IdMatch = (int)oSqlDataReader[6];
                    oBoard.IdFavori = (int)oSqlDataReader[7];
                    oBoard.IdChallenger = (int)oSqlDataReader[8];

                    oList.Add(oBoard);
                }
            }
            // Not catch to interrupt all the process in case of an error
            finally
            {
            }
            return oList;
        }

        
        #endregion

    }
}
