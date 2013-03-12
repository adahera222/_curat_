using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.DAO;
using BoglarChamp.NHibernate.Core.Entity;
using NHibernate;
using log4net;
using System.Reflection;

namespace BoglarChamp.NHibernate.Core
{
    public class ManagerAmbalaj
    {
        public IList<Ambalaj> GetAmbalaje(bool toate)
        {
            BusinessAmbalaj bus = null;
            IList<Ambalaj> ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessAmbalaj();
                ret = bus.GetAmbalaje(toate);
                tx.Commit();
            }
            catch (Exception ex)
            {
                LogMessage.Error(ex);
                if (!nHibernateUtil.GetSession.Transaction.WasCommitted && !nHibernateUtil.GetSession.Transaction.WasRolledBack)
                {
                    nHibernateUtil.GetSession.Transaction.Rollback();
                }
                throw ex;
            }
            finally
            {
                nHibernateUtil.CloseSession();
                bus = null;
            }
            return ret;
        }

        public Ambalaj SaveAmbalaj(Ambalaj a)
        {
            BusinessAmbalaj bus = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();


                bus = new BusinessAmbalaj();
                a = bus.SaveAmbalaj(a);
                tx.Commit();
            }
            catch (Exception ex)
            {
                LogMessage.Error(ex);
                if (!nHibernateUtil.GetSession.Transaction.WasCommitted && !nHibernateUtil.GetSession.Transaction.WasRolledBack)
                {
                    nHibernateUtil.GetSession.Transaction.Rollback();
                }
                throw ex;
            }
            finally
            {
                nHibernateUtil.CloseSession();
                bus = null;
            }
            return a;
        }
    }
}
