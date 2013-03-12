using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BoglarChamp.NHibernate.Core;

namespace BoglarChamp.WebS
{
    /// <summary>
    /// Summary description for PreluareDate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PreluareDate : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetHale()
        {
            ManagerExtern m = null;
            string ret = "";

            m = new ManagerExtern();
            ret = m.GetHale();

            return ret;

        }

        [WebMethod]
        public string GetAmbalaje()
        {
            ManagerExtern m = null;
            string ret = "";

            m = new ManagerExtern();
            ret = m.GetAmbalaje();

            return ret;
        }

        [WebMethod]
        public string GetCelule()
        {
            ManagerExtern m = null;
            string ret = "";

            m = new ManagerExtern();
            ret = m.GetCelule();

            return ret;
        }

        [WebMethod]
        public string Initializare(string cod)
        {
            string ret = "";
            ManagerExtern m = null;

            m = new ManagerExtern();
            ret = m.Reinitializare(cod);

            return ret;
        }

        [WebMethod]
        public string Scanare(string scanare)
        {
            string ret = "";
            ManagerExtern m = null;

            m = new ManagerExtern();
            ret = m.Scanare(scanare);

            return ret;
        }
    }
}
