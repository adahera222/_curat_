using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BoglarChamp.WebS
{
    /// <summary>
    /// Summary description for TestAndi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TestAndi : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloAndi()
        {

            return "Hello Andi";
        }

        private static string nodVariabil;

        [WebMethod]
        public string GetNodVariabil()
        {
            if (string.IsNullOrEmpty(nodVariabil))
            {
                return "WebService ERROR";
            }
            return nodVariabil;
        }


        [WebMethod]
        public void SetNodVariabil(string str)
        {
            nodVariabil = str;
        }

        [WebMethod]
        public string GetNod(int nodID)
        {
            switch (nodID)
            {
                case 1:
                    return "LABEL^Nodul 1@LIST^listaTest#itemA#itemB@LABEL^Zilele saptamanii@SPINNER^Luni#Marti#Miercuri#Joi#Vineri#Sambata#Duminica@BUTTON^Ws Nod 3#3@BUTTON^Ws Nod 4#4";
                case 2:
                    return "LABEL^Nodul 2@LABEL^Acesta@LABEL^este@LABEL^nodul 2@LABEL^Zilele saptamanii@SPINNER^Luni#Marti#Miercuri#Joi#Vineri#Sambata#Duminica@LIST^listaTest#itemA#itemB@BUTTON^Ws Nod 4#4";
                case 3:
                    return "LABEL^Nodul 3@LABEL^Ati@LABEL^ajuns@LABEL^la nodul 3@LABEL^Culori@SPINNER^rosu#verde#albastru@LIST^Lista 20 elemente #item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10@LABEL^De aici nu se poate merge la alt nod@LABEL^EOF";
                case 4:
                    return "LABEL^Nodul 4@LABEL^Bine@LABEL^ati@LABEL^ajuns@LABEL^la nodul 4@LABEL^Ce are ana?@SPINNER^Mere#Pere@LIST^Lista 100 elemente#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10@LABEL^De aici nu se poate merge doar la nodul 5@BUTTON^Ws Nod 5#5";
                case 5:
                    return "LABEL^Nodul 5@LABEL^Saluti@LABEL^acesta@LABEL^este@LABEL^ultimul@LABEL^nod din ramura@LABEL^Spinner 100 elemente@SPINNER^item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10@LIST^Lista 40 elemente #item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10#item 1#item 2#item 3#item 4#item 5#item 6#item 7#item 8#item 9#item 10@LABEL^Gata";
                default:
                    return "WebService ERROR";
            }
        }
    }
}
