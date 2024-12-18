using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BetByRate.Object
{
    public class Droit
    {
        #region Attributes
        private int _IdDroit;
        public int IdDroit
        {
            get
            {
                return _IdDroit;
            }
            set
            {
                _IdDroit = value;
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
        public Droit() {}

        //Constructeur
        public Droit(int lgIdDroit)
        {
            string strSqlQuery = string.Empty;
            try
            {
                strSqlQuery = "SELECT IdDroit, Libelle FROM Surface " +
                    "Where IdDroit = " + lgIdDroit.ToString();
            }
            finally 
            { 
            }
        }

       

        #endregion
    }
}
