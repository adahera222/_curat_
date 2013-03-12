using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.Entity;

namespace BoglarChamp.NHibernate.Core
{
    internal class BusinessPersoana:_BusinessBase
    {
        internal Persoana GetMuncitorFromCod(string cod)
        {
            IList<Persoana> list = null;
            Persoana ret = null;

            list = dao.ExecuteHql("select p from Persoana p where p.Cod='" + cod + "'", null).Cast<Persoana>().ToList<Persoana>();
            if (list.Count != 0)
            {
                ret = list[0];
            }

            return ret;

        }

        internal IList<PersoanaIMO> GetPersoaneIMO(string nume, string prenume, string functie,string firma,
            bool siAnulati, bool ordoneazaNume)
        {
            IList<PersoanaIMO> list = null;
            string where = "";

            if (!siAnulati)
            {
                where = " p.Anulat=0 ";
            }

            if (nume != "")
            {
                where += (where == "" ? "" : " and ") + " p.Nume like '%" + nume + "%' ";
            }
            if (prenume != "")
            {
                where += (where == "" ? "" : " and ") + " p.Prenume like '%" + prenume + "%' ";
            }
            if (functie != "" && functie!="ALL")
            {
                where += (where == "" ? "" : " and ") + " f.Denumire like '%" + functie + "%' ";
            }
            if (firma != "" && firma != "ALL")
            {
                where += (where == "" ? "" : " and ") + " g.Denumire like '%" + firma + "%' ";
            }
            if (where != "")
            {
                where = " where " + where;
            }
            if (ordoneazaNume)
            {
                list = dao.ExecuteHql("select new PersoanaIMO(p) from Persoana p inner join p.Functie f " +
            " inner join p.Firma g "+where +
                    " order by p.Nume", null).Cast<PersoanaIMO>().ToList();
            }
            else
            {
                list = dao.ExecuteHql("select new PersoanaIMO(p) from Persoana p inner join p.Functie f " +
            " inner join p.Firma g " + where +
                    " order by p.Numar", null).Cast<PersoanaIMO>().ToList();
            }
            
            return list;
        }

        internal bool VerificaUnicitateCod(string cod, int persoanaId)
        {
            IList<Persoana> list = null;
            bool ret = true;

            list = dao.ExecuteHql("select p from Persoana p where p.Cod='" + cod + "' and p.Id<>"+persoanaId, null).Cast<Persoana>().ToList<Persoana>();
            if (list.Count != 0)
            {
                ret = false;
            }

            return ret;
        }

        internal Persoana SavePersoana(Persoana p)
        {
            Persoana persoana = null;

            p.CheckCanSave(dao);

            if (p.Id == 0)
            {
                persoana = new Persoana();
            }
            else
            {
                persoana = GetPersoana(p.Id);
            }
            persoana.Nume = p.Nume;
            persoana.Prenume = p.Prenume;
            persoana.Anulat = p.Anulat;
            persoana.Cod = p.Cod;
            persoana.Functie = p.Functie;
            persoana.Numar = p.Numar;
            persoana.Firma = p.Firma;
            persoana = dao.Save(persoana) as Persoana;

            return persoana;
        }

        private Persoana GetPersoana(int persoanaId)
        {
            Persoana ret = null;
            ret = dao.GetById(persoanaId, typeof(Persoana)) as Persoana;
            return ret;
        }
    }
}
