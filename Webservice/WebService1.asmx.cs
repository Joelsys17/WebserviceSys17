using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;

namespace Webservice
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5C3JSVR;Initial Catalog=Demo Database NAV (5-0);Integrated Security=True;");
        [WebMethod]
        public String GetWebsiteHtml(String url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string result = reader.ReadToEnd();
            stream.Dispose();
            reader.Dispose();
            return result;
        }

        [WebMethod]
        public DataTable webobject()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM sys.objects WHERE schema_id = SCHEMA_ID('dbo')", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dt.TableName = "All objects";
                sda.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        [WebMethod]
    public DataTable sqlstring()
    {
try
{
                SqlCommand cmd = new SqlCommand("SELECT * FROM sys.objects WHERE schema_id = SCHEMA_ID('dbo')", con);
                DataTable dt2 = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dt2.TableName = "All objects 1";
                sda.Fill(dt2);
                return dt2;
            }
            catch (SqlException)
            {
                throw;
            }
    }
        //Hej//
    [WebMethod]
        public void Upload(byte[] contents,  string filenamesave)
        {
            var appData = Server.MapPath("C:/Web");
            var file = Path.Combine(appData, Path.GetFileName(filenamesave));
            File.WriteAllBytes(file, contents);
        }

        [WebMethod]
        public String txtFile(String filename)
        {
            StreamReader sr = File.OpenText(filename);
            {
                String line = sr.ReadToEnd();
                return line;
            }
        }
    }
}


