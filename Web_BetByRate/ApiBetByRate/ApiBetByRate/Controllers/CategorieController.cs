using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using ApiBetByRate.Models;

namespace ApiBetByRate.Controllers
{
    public class CategorieController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"select IdCategorie, Libelle from dbo.Categorie";
            DataTable table = new DataTable();

            using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["TrainingAppDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        /*
        [Route("api/XXX/XX")]
        [HttpGet]
        public HttpResponseMessage GetAllCategorie()
        {
        https://www.youtube.com/watch?v=4a9VxZjnT7E à 43:20
        }*/

    }
}
