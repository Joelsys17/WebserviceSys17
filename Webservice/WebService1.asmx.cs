﻿using System;
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
        private SqlConnection con = new SqlConnection(@"Data Source=GEDDA;Initial Catalog=Cronus;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
                SqlCommand cmd = new SqlCommand("select name, type_desc from sys.objects WHERE type in ('C', 'D', 'F', 'L', 'P', 'PK', 'RF', 'TR', 'UQ', 'V', 'X')unionselect name, type_desc from sys.indexesorder by name", con);
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
    public void sqlstring()
    {
            SqlCommand cmd = new SqlCommand("select name, type_desc from sys.objects WHERE type in ('C', 'D', 'F', 'L', 'P', 'PK', 'RF', 'TR', 'UQ', 'V', 'X')unionselect name, type_desc from sys.indexesorder by name = @Parameter");
string variable;
try
{
    cmd.Parameters.AddWithValue("@Parameter", 20);
    con.Open();
    variable = (string)cmd.ExecuteScalar();
}
            catch (SqlException)
            {
                throw;
            }
    }

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


