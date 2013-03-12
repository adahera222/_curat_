using System.Collections;
using System;
using System.Threading;
using BoglarChamp.NHibernate.Core.DAO;

namespace BoglarChamp.NHibernate.Core.Entity
{
    public partial class Persoana:IValidator
    {
        public string Parse()
        {
            string ret = "";
            if (this.Anulat)
            {
                ret = this.Id + "#####";
            }
            else
            {
                ret = this.Id + "#" + this.Nume + "#" + this.Prenume+ "#"+this.Cod+"#" +this.Functie.Id.ToString()+"#"+this.Firma.Id.ToString();
            }
            return ret;
        }
        public string ParseAnulat()
        {
            string ret = "";

            ret = this.Id + "#####";

            return ret;
        }
        public void CheckIfUnique(DAO_Base dao)
        {
            if (!this.Anulat)
            {
                CheckNumar(dao);
            }
        }

        private void CheckNumar(DAO_Base dao)
        {
            int count = 0;

            if (this.Numar != 0)
            {
                count = dao.ExecuteHql("select p.Id from Persoana p " +
                    "where p.Numar=" + this.Numar + " and p.Anulat=0 and p.Id<>" + this.Id, null).Count;
                CheckCount(count, "Numarul "+this.Numar+" este deja alocat altei persoane!");
            }
        }
        private void CheckDenumire(DAO_Base dao)
        {
            
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
            throw new Exception("Eroare stergere persoana!");
        }

        public void CheckCanSave(DAO_Base dao)
        {
            if (this.Nume == "")
            {
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.LipsaDenumireGrupa);
                throw new Exception("Numele nu poate fi gol!");
            }

            CheckIfUnique(dao);
           
        }

        
    }
}
