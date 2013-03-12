using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    internal class BusinessReinitializare:_BusinessBase
    {
        internal string Reinitializare(string cod)
        {
            string ret = null;
            Persoana muncitor = null;

            muncitor = GetPersoanaByCod(cod);
            if (muncitor != null)
            {
                ret = muncitor.Id + "#" + muncitor.Nume + "#" + muncitor.Prenume + "#BOGLAR CHAMP";
            }
            else
            {
                ret = "Codul nu este asociat unui sef echipa!";
            }
            return ret;

        }

        private Persoana GetPersoanaByCod(string cod)
        {
            IList<Persoana> list = null;
            Persoana ret = null;

            list = dao.ExecuteHql("select p from Persoana p inner join p.Functie f "+
            " where f.Denumire like 'sefechipa' and p.Cod='" + cod + "'", null).Cast<Persoana>().ToList<Persoana>().AsReadOnly();

            if (list.Count != 0)
            {
                ret = list[0];
            }
            return ret;
        }
    }
}
