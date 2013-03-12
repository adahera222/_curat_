using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    internal class BusinessAmbalaj:_BusinessBase
    {
        internal string GetAmbalaje()
        {
            string ret = "";
            IList<Ambalaj> ambalaje = null;

            ambalaje = GetAmbalaje(false);
            foreach (Ambalaj a in ambalaje)
            {
                ret += a.Parse() + "@";
            }
            if (ret.Length != 0) ret = ret.Remove(ret.Length - 1);

            return ret;
        }


        internal IList<Ambalaj> GetAmbalaje(bool anulat)
        {
            IList<Ambalaj> list = null;
            if (!anulat)
            {
                list = dao.ExecuteHql("select a from Ambalaj a " +
                                " where a.Anulat=0 order by a.Denumire", null).Cast<Ambalaj>().ToList();
            }
            else
            {
                list = dao.ExecuteHql("select a from Ambalaj a order by a.Denumire", null).Cast<Ambalaj>().ToList();
            }
            return list;
        }

        internal Ambalaj SaveAmbalaj(Ambalaj a)
        {
            Ambalaj ambalaj = null;

            a.CheckCanSave(dao);

            if (a.Id == 0)
            {
                ambalaj = new Ambalaj();
            }
            else
            {
                ambalaj = GetAmbalaj(a.Id);
            }
            ambalaj.Denumire = a.Denumire;
            ambalaj.Anulat = a.Anulat;
            ambalaj.Greutate = a.Greutate;

            ambalaj = dao.Save(ambalaj) as Ambalaj;

            return ambalaj;
        }

        private Ambalaj GetAmbalaj(int ambalajId)
        {
            Ambalaj ret = null;
            ret = dao.GetById(ambalajId, typeof(Ambalaj)) as Ambalaj;
            return ret;
        }
    }
}
