using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BetByRate.Object
{
    public class Utilisateur
    {
        #region Attributes
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

        private string? _eMail;
        public string? eMail
        {
            get
            {
                return _eMail;
            }
            set
            {
                _eMail = value;
            }
        }

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

        private DateTime _DateCreation;
        public DateTime DateCreation
        {
            get
            {
                return _DateCreation;
            }
            set
            {
                _DateCreation = value;
            }
        }
        #endregion

        #region Methode
        //Constructeur
        public Utilisateur() { }
        public Utilisateur(long lgIdUtilisateur)
        {
            string strSqlQuery = string.Empty;
            try
            {
                strSqlQuery = "SELECT IdUtilisateur, Nom, Prenom, eMail, IdDroit, DateCreation FROM Utilisateur " +
                    "Where IdUtilisateur = " + lgIdUtilisateur.ToString();
            }
            finally
            {
            }
        }
        #endregion
    }
}
