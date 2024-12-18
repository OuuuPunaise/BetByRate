using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BetByRate
{
    internal class Db
    {
        #region Connection
        private SqlConnection _oSqlConn;
        public SqlConnection oSqlConn
        {
            get { return _oSqlConn; }
            set { _oSqlConn = value; } 
        }

		//Constructeur
		public Db(string strConnectionStringName = "TrainingConnectionString")
		{
			//string strConnectionString = String.Empty;
			//string strConnectionString = "server=LAPTOP-AV3R6EJN\\SQLEXPRESS;database=BetByRate;UID=BetByRateAdmin;password=BetByRateAdmin";
			//string strConnectionString = "server=frcivttas30;database=Training;UID=TrainingAdmin;password=TrainingAdmin";

			try
			{
				if (oSqlConn == null)
				{
					//string strConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["appConnectionString"].ConnectionString;
					string strConnectionString = "server=frcivttas30;database=Training;UID=TrainingAdmin;password=TrainingAdmin";

					// Get the ConnectionString in the app.config file
					oSqlConn = new SqlConnection(strConnectionString);
					oSqlConn.Open();
				}
			}
			catch (Exception ex)
			{
				if (ex.Source != null)
					Console.WriteLine("Probleme : {0}", ex.Source);
				throw;
			}
		}

		//Close the SQL Connection
		public void Close()
		{
			try
			{
				if (oSqlConn != null)
				{
					oSqlConn.Dispose();
					oSqlConn.Close();
				}
			}
			catch (Exception ex)
			{
				if (ex.Source != null)
					Console.WriteLine("Probleme : {0}", ex.Source);
				throw;
			}
		}

		#endregion
	}
}
