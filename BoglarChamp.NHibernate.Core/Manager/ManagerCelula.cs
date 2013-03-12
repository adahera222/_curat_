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
    public class ManagerCelula
    {
        public IList<Celula> GetCelule(bool toate)
        {
            BusinessCelula bus = null;
            IList<Celula> ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessCelula();
                ret = bus.GetCelule(toate);
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

        public Celula SaveCelula(Celula c)
        {
            BusinessCelula bus = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();


                bus = new BusinessCelula();
                c = bus.SaveCelula(c);
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
            return c;
        }

        public IList<CelulaIMO> GetCeluleIMO(bool toate)
        {
            BusinessCelula bus = null;
            IList<CelulaIMO> ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessCelula();
                ret = bus.GetCeluleIMO(toate);
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
