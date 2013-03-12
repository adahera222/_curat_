using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    internal class BusinessFunctie:_BusinessBase
    {
        internal IList<Functie> GetFunctii(bool anulat)
        {
            IList<Functie> list = null;
            if (!anulat)
            {
                list = dao.ExecuteHql("select f from Functie f " +
                                " where f.Anulat=0 order by f.Denumire", null).Cast<Functie>().ToList();
            }
            else
            {
                list = dao.ExecuteHql("select f from Functie f order by f.Denumire", null).Cast<Functie>().ToList();
            }
            return list;
        }

        internal Functie GetFunctieByDenumire(string functie)
        {
            IList<Functie> list = null;
            Functie ret = null;
            
                list = dao.ExecuteHql("select f from Functie f where f.Denumire='"+functie+"'", null).Cast<Functie>().ToList();
                if (list.Count != 0)
                {
                    ret = list[0];
                }
            return ret;
        }
    }
}
