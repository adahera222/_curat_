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
    public class ManagerFunctie
    {
        public IList<Functie> GetFunctii(bool toate)
        {
            BusinessFunctie bus = null;
            IList<Functie> ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessFunctie();
                ret = bus.GetFunctii(toate);
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

        public Functie GetFunctieByDenumire(string functie)
        {
            BusinessFunctie bus = null;
            Functie ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessFunctie();
                ret = bus.GetFunctieByDenumire(functie);
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
    }
}
