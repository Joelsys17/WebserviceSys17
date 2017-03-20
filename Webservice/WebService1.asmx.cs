using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;

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
        public ArrayList objects()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM sys.objects WHERE schema_id = SCHEMA_ID('dbo')", con);
                DataTable list = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                list.TableName = "All objects";
                sda.Fill(list);
                ArrayList rows = new ArrayList();
                foreach (DataRow dataRow in list.Rows)
                    rows.Add(string.Join(";", dataRow.ItemArray.Select(item => item.ToString())));
                return rows;

            }
            catch (SqlException)
            {
                throw;
            }
        }

        [WebMethod]
        public List<String>[] javaobjects()
        {
            try
            {
                ArrayList array = new ArrayList();
                ArrayList listColumns = new ArrayList();
                var columnNames = getObjects().Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
                var stringArr = getObjects().

                List<String> list1 = columnNames.OfType<String>().ToList();
                List<String> list2 = stringArr.OfType<String>().ToList();
                

                List<String>[] arr = new List<String>[2];
                arr[0] = list1;
                arr[1] = list2;
                return arr;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public List<Object> ToArray()
        {
            var ret = Array.CreateInstance(typeof(object), getObjects().Rows.Count, getObjects().Columns.Count) as object[,];
            for (var i = 0; i < getObjects().Rows.Count - 1; i++)
                for (var j = 0; j < getObjects().Columns.Count - 1; j++)
                    ret[i, j] = getObjects().Rows[i][j];
            List<object> list = ret.OfType<Object>().ToList();
            return list;
        }
        public DataTable getObjects()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT name, object_id, schema_id, parent_object_id, type, type_desc, create_date, modify_date, is_ms_shipped, is_published, is_schema_published FROM sys.objects WHERE schema_id = SCHEMA_ID('dbo')", con);
                DataTable list = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                list.TableName = "All objects";
                sda.Fill(list);
                return list;
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


