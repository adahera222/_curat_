using System.Collections;
using System;
using System.Threading;
using BoglarChamp.NHibernate.Core.DAO;

namespace BoglarChamp.NHibernate.Core.Entity
{
    public partial class Ambalaj:IValidator
    {
        public string Parse()
        {
            string ret = "";
            if (this.Anulat)
            {
                ret = this.Id + "##";
            }
            else
            {
                ret = this.Id + "#" + this.Denumire+"#"+this.Greutate+"kg";
            }
            return ret;
        }
        public string ParseAnulat()
        {
            string ret = "";

            ret = this.Id + "##";

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
                count = dao.ExecuteHql("select a.Id from Ambalaj a " +
                    "where a.Anulat=0 and a.Denumire='" + this.Denumire + "' and a.Id<>" + this.Id, null).Count;
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                CheckCount(count, "Mai aveti un ambalaj cu aceeasi denumire!");
                //throw new Exception("Mai aveti un ambalaj cu aceeasi denumire!");
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
            throw new Exception("Eroare stergere ambalaj!");
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
            
        }

        
    }
}
