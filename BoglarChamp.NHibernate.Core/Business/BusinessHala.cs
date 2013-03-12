using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;


namespace BoglarChamp.NHibernate.Core
{
    internal class BusinessHala:_BusinessBase
    {

        internal string GetHale()
        {
            string ret="";
            IList<Hala> hale = null;

            hale=GetHale(false);
            foreach (Hala h in hale)
            {
                ret += h.Parse() + "@";
            }
            if (ret.Length != 0) ret = ret.Remove(ret.Length - 1);

            return ret;
        }

        internal IList<Hala> GetHale(bool anulat)
        {
            IList<Hala> list = null;
            if (!anulat)
            {
                list = dao.ExecuteHql("select h from Hala h " +
                                " where h.Anulat=0 order by h.Denumire", null).Cast<Hala>().ToList();
            }
            else
            {
                list = dao.ExecuteHql("select h from Hala h order by h.Denumire", null).Cast<Hala>().ToList();
            }
            return list;
        }

        internal List<HalaIMO> GetHaleIMO(bool toate)
        {
            List<HalaIMO> ret = null;
            string where = null;
            if (!toate)
            {
                where=" where anulat=0 ";
            }
                else
                {
                    where = "";
                }
            

            ret = dao.ExecuteHql("select new HalaIMO(h) from Hala h" +
                 where + " order by h.Denumire", null).Cast<HalaIMO>().ToList();

            return ret;
        }

        internal Hala SaveHala(Hala h)
        {
            Hala hala = null;

            h.CheckCanSave(dao);

            if (h.Id == 0)
            {
                hala = new Hala();
            }
            else
            {
                hala = GetHala(h.Id);
            }
            hala.Denumire = h.Denumire;
            hala.Anulat = h.Anulat;

            hala = dao.Save(hala) as Hala;
            
            return hala;
        }

        private Hala GetHala(int halaId)
        {
            Hala ret = null;
            ret = dao.GetById(halaId, typeof(Hala)) as Hala;
            return ret;
        }

        internal Hala GetHalaByDenumire(string hala)
        {
            IList<Hala> list = null;
            Hala ret = null;
            
            list = dao.ExecuteHql("select h from Hala h " +
                                " where h.Denumire='"+hala+"'", null).Cast<Hala>().ToList();
            if (list.Count != 0)
            {
                ret = list[0];
            }
            return ret;
        }
    }
}
