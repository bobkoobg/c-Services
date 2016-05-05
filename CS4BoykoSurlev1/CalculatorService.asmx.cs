using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data.SqlClient;

namespace CS4BoykoSurlev1
{
    /// <summary>
    /// Summary description for CalculatorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorService : System.Web.Services.WebService
    {

        [WebMethod]
        public CalculatorResponse returnAveragePoints(String alias)
        {
            CalculatorResponse sr;
            string aliasS;
            string seq;
            int average;
            try
            {
                SqlConnection conn = new SqlConnection(@"data source = .\sqlbobkoodb; integrated security = true; database = ArchersDB");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                //cmd.CommandText = @"select * from ArchersPrices where alias = " + alias;
                cmd.CommandText = @"select * from ArchersPrices where alias = '" + alias + "'";
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                // rdr.Read() returns a boolean : true if data was found, else false
                // e.g. use while(rdr.Read())
                aliasS = rdr["alias"].ToString();
                seq = rdr["points"].ToString();
                string[] words = rdr["points"].ToString().Split(',');
                average = 0;
                foreach (string word in words)
                {
                    average = average + Convert.ToInt32(word);
                }
                average = (average / words.Length);
                rdr.Close();
                conn.Close();
            }
            catch (SqlException exp)
            {
                // Log what you need from here.
                throw new InvalidOperationException("Data could not be read", exp);
            }
            sr = new CalculatorResponse(aliasS, seq, average);
            return sr;
        }

        [WebMethod]
        public CalculatorResponse returnTotalPoints(String alias)
        {
            CalculatorResponse sr;
            string aliasS;
            string pts;
            int total;
            try
            {
                SqlConnection conn = new SqlConnection(@"data source = .\sqlbobkoodb; integrated security = true; database = ArchersDB");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                //cmd.CommandText = @"select * from ArchersPrices where alias = " + alias;
                cmd.CommandText = @"select * from ArchersPrices where alias = '" + alias + "'";
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                // rdr.Read() returns a boolean : true if data was found, else false
                // e.g. use while(rdr.Read())
                aliasS = rdr["alias"].ToString();
                pts = rdr["points"].ToString();
                string[] words = rdr["points"].ToString().Split(',');
                total = 0;
                foreach (string word in words)
                {
                    total = total + Convert.ToInt32(word);
                }
                rdr.Close();
                conn.Close();
            }
            catch (SqlException exp)
            {
                // Log what you need from here.
                throw new InvalidOperationException("Data could not be read", exp);
            }
            sr = new CalculatorResponse(aliasS, pts, total);
            return sr;
        }

        [WebMethod]
        public CalculatorResponse getAllNumberSorted(String alias)
        {
            CalculatorResponse sr;
            string nameAlias;
            int[] points;
            try
            {
                SqlConnection conn = new SqlConnection(@"data source = .\sqlbobkoodb; integrated security = true; database = ArchersDB");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                //cmd.CommandText = @"select * from ArchersPrices where alias = " + alias;
                cmd.CommandText = @"select * from ArchersPrices where alias = '" + alias + "'";
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                // rdr.Read() returns a boolean : true if data was found, else false
                // e.g. use while(rdr.Read())
                nameAlias = rdr["alias"].ToString();
                string[] pointString = rdr["points"].ToString().Split(',');
                points = new int[pointString.Length];
                for (int i = 0; i < pointString.Length; i++)
                {
                    points[i] = Convert.ToInt32(pointString[i]);
                }
                Array.Sort(points);
                rdr.Close();
                conn.Close();
            }
            catch (SqlException exp)
            {
                // Log what you need from here.
                throw new InvalidOperationException("Data could not be read", exp);
            }
            sr = new CalculatorResponse(nameAlias, points);
            return sr;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
