using System.Collections;
using System;
using System.Threading;
using BoglarChamp.NHibernate.Core.DAO;

namespace BoglarChamp.NHibernate.Core.Entity
{
    public partial class Functie:IValidator
    {
        public string Parse()
        {
            string ret = "";
            if (this.Anulat)
            {
                ret = this.Id + "#";
            }
            else
            {
                ret = this.Id + "#" + this.Denumire;
            }
            return ret;
        }
        public string ParseAnulat()
        {
            string ret = "";

            ret = this.Id + "#";

            return ret;
        }
        public void CheckIfUnique(DAO_Base dao)
        {
            if (!this.Anulat)
            {
                CheckDenumire(dao);
            }
        }
        private void CheckDenumire(DAO_Base dao)
        {
            int count = 0;

            if (this.Denumire != "")
            {
                count = dao.ExecuteHql("select f.Id from Functie f " +
                    "where f.Anulat=0 and f.Denumire='" + this.Denumire + "' and f.Id<>" + this.Id, null).Count;
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                CheckCount(count, "Mai aveti o functie cu aceeasi denumire!");
            }
        }

        private void CheckCount(int count, string eroare)
        {
            if (count != 0)
            {
                throw new Exception(eroare);
            }
        }

        public void CheckCanDelete(DAO_Base dao)
        {
            //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
            //throw new Exception(Resources.Core.EroareStergereGrupa);
            throw new Exception("Eroare stergere functie!");
        }

        public void CheckCanSave(DAO_Base dao)
        {
            if (this.Denumire == "")
            {
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.LipsaDenumireGrupa);
                throw new Exception("Denumirea nu poate fi goala!");
            }

            CheckIfUnique(dao);
            if (Anulat)
            {
                CheckIfContainPersoana(dao);
            }
        }

        private void CheckIfContainPersoana(DAO_Base dao)
        {
            IList list = null;
            try
            {
                list = dao.ExecuteHql("select p from Persoana p inner join p.Functie f " +
                " where f.Id=" + Id + " and p.Anulat=0", null);
                if (list.Count != 0)
                {
                    //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                    //throw new Exception(string.Format(Resources.Core.EroareAnulareGrupa, list.Count.ToString()));
                    throw new Exception(string.Format("Nu puteti anula functia! Aveti {0} persoane alocate!", list.Count.ToString()));
                }
            }
            finally
            {
                list = null;
            }
        }
    }
}
