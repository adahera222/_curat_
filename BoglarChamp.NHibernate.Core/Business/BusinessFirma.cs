using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    internal class BusinessFirma:_BusinessBase
    {
        internal IList<Firma> GetFirme(bool anulat)
        {
            IList<Firma> list = null;
            if (!anulat)
            {
                list = dao.ExecuteHql("select f from Firma f " +
                                " where f.Anulat=0 order by f.Denumire", null).Cast<Firma>().ToList();
            }
            else
            {
                list = dao.ExecuteHql("select f from Firma f order by f.Denumire", null).Cast<Firma>().ToList();
            }
            return list;
        }

        internal Firma GetFirmaByDenumire(string firma)
        {
            IList<Firma> list = null;
            Firma ret = null;

            list = dao.ExecuteHql("select f from Firma f where f.Denumire='" + firma + "'", null).Cast<Firma>().ToList();
            if (list.Count != 0)
            {
                ret = list[0];
            }
            return ret;
        }
    }
}
