using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ApiBetByRate.Models;
//using System.Web;

namespace ApiBetByRate.Controllers
{
    public class SportController : ApiController
    {
        //[Route("api/Sport/Get")]
        //Http : Site

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TrainingAppDB"].ConnectionString);

        public HttpResponseMessage Get()
        {
            /*
            // Cette requete est a faire dans SQL serveur 28:41
            string query = @"
                            Select IdSport, Nom 
                            From dbo.Sport";

            DataTable table = new DataTable();

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["TrainingAppDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);*/

            con.Open();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("AllSports", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            con.Close();

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        //Http : Site\Sports
        public HttpResponseMessage Sports()
        {
            // Le nom sports ce retrouve dans la partie routing d'angular
            con.Open();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("AllSports", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            con.Close();

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        //Http : Site\Categorie
        public HttpResponseMessage Categories(int IdSport)
        {
            // Le nom sports ce retrouve dans la partie routing d'angular
            con.Open();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("CategorieBySport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            con.Close();

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        //Http : Site\Competition
        public HttpResponseMessage Competitions(int IdSport)
        {
            // Le nom sports ce retrouve dans la partie routing d'angular
            con.Open();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("CompetitionsBySport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            con.Close();

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

    }
}
