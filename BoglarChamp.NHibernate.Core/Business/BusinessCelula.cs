using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    internal class BusinessCelula:_BusinessBase
    {
        internal string GetCelule()
        {
            string ret = "";
            IList<Celula> celule = null;

            celule = GetCelule(false);
            foreach (Celula c in celule)
            {
                ret += c.Parse() + "@";
            }
            if (ret.Length != 0) ret = ret.Remove(ret.Length - 1);

            return ret;
        }

        internal IList<Celula> GetCelule(bool anulat)
        {
            IList<Celula> list = null;
            if (!anulat)
            {
                list = dao.ExecuteHql("select c from Celula c " +
                                " where c.Anulat=0 order by c.Denumire", null).Cast<Celula>().ToList();
            }
            else
            {
                list = dao.ExecuteHql("select c from Celula c order by c.Denumire", null).Cast<Celula>().ToList();
            }
            return list;
        }


        internal Celula SaveCelula(Celula c)
        {
            Celula celula = null;

            c.CheckCanSave(dao);

            if (c.Id == 0)
            {
                celula = new Celula();
            }
            else
            {
                celula = GetCelula(c.Id);
            }
            celula.Denumire = c.Denumire;
            celula.Anulat = c.Anulat;
            celula.Hala = c.Hala;

            celula = dao.Save(celula) as Celula;

            return celula;
        }

        private Celula GetCelula(int celulaId)
        {
            Celula ret = null;
            ret = dao.GetById(celulaId, typeof(Celula)) as Celula;
            return ret;
        }

        internal IList<CelulaIMO> GetCeluleIMO(bool anulat)
        {
            IList<CelulaIMO> list = null;
            if (!anulat)
            {
                list = dao.ExecuteHql("select new CelulaIMO(c) from Celula c " +
                                " where c.Anulat=0 order by c.Denumire", null).Cast<CelulaIMO>().ToList();
            }
            else
            {
                list = dao.ExecuteHql("select new CelulaIMO(c) from Celula c order by c.Denumire", null).Cast<CelulaIMO>().ToList();
            }
            return list;
        }
    }
}
