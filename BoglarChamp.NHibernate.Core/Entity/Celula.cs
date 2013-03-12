﻿using System.Collections;
using System;
using System.Threading;
using BoglarChamp.NHibernate.Core.DAO;

namespace BoglarChamp.NHibernate.Core.Entity
{
    public partial class Celula:IValidator
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
                ret = this.Id + "#" + this.Denumire+"#"+this.Hala.Id.ToString();
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
                count = dao.ExecuteHql("select c.Id from Celula c " +
                    "where c.Anulat=0 and c.Denumire='" + this.Denumire + "' and c.Id<>" + this.Id, null).Count;
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                CheckCount(count, "Mai aveti o celula cu aceeasi denumire!");
                //throw new Exception("Mai aveti o celula cu aceeasi denumire!");
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
            throw new Exception("Eroare stergere celula!");
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
            //if (Anulat)
            //{
            //    CheckIfContainCelula(dao);
            //}
        }

        //private void CheckIfContainCelula(DAO_Base dao)
        //{
        //    IList list = null;
        //    try
        //    {
        //        list = dao.ExecuteHql("select c from Celula c inner join c.Hala h " +
        //        " where h.Id=" + Id + " and c.Anulat=0", null);
        //        if (list.Count != 0)
        //        {
        //            Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
        //            throw new Exception(string.Format(Resources.Core.EroareAnulareGrupa, list.Count.ToString()));
        //        }
        //    }
        //    finally
        //    {
        //        list = null;
        //    }
        //}
    }
}
