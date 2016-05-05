using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data.SqlClient;

namespace CS4BoykoSurlev1
{
    /// <summary>
    /// Summary description for ArchersService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ArchersService : System.Web.Services.WebService
    {

        [WebMethod]
        public ArchersResponse returnNameAndPrices(String realName)
        {
            ArchersResponse sr;
            string name;
            string price;
            try
            {
                SqlConnection conn = new SqlConnection(@"data source = .\sqlbobkoodb; integrated security = true; database = ArchersDB");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT ap.* FROM Archers a JOIN ArchersPrices ap ON a.alias = ap.alias WHERE a.realName = '" + realName + "'";
                // cmd.CommandText = @"select * from ArchersPrices where alias = '" + alias + "'";
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                // rdr.Read() returns a boolean : true if data was found, else false
                // e.g. use while(rdr.Read())
                name = rdr["alias"].ToString();
                price = rdr["price"].ToString();
                conn.Close();
            }
            catch (SqlException exp)
            {
                // Log what you need from here.
                throw new InvalidOperationException("Data could not be read", exp);
            }
            sr = new ArchersResponse(name, price);
            return sr;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
