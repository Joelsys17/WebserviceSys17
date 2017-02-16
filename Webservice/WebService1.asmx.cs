using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
