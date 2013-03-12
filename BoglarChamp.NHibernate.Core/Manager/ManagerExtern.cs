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
    public class ManagerExtern
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public string GetHale()
        {
            BusinessHala bus = new BusinessHala();
            string ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessHala();
                ret = bus.GetHale();
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

        public string GetCelule()
        {
            BusinessCelula bus = new BusinessCelula();
            string ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessCelula();
                ret = bus.GetCelule();
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

        public string GetAmbalaje()
        {
            BusinessAmbalaj bus = new BusinessAmbalaj();
            string ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessAmbalaj();
                ret = bus.GetAmbalaje();
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

        public string Reinitializare(string cod)
        {
            BusinessReinitializare bus = new BusinessReinitializare();
            string ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessReinitializare();
                ret = bus.Reinitializare(cod);
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


        public string Scanare(string scanare)
        {
            BusinessScanare bus = new BusinessScanare();
            string ret = null;
            ITransaction tx = null;

            try
            {
                log.Error("Scanare: "+scanare);

                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessScanare();
                ret = bus.Scanare(scanare);
                tx.Commit();
            }
            catch (Exception ex)
            {
                LogMessage.Error(ex);
                if (!nHibernateUtil.GetSession.Transaction.WasCommitted && !nHibernateUtil.GetSession.Transaction.WasRolledBack)
                {
                    nHibernateUtil.GetSession.Transaction.Rollback();
                }
                //throw ex;
                ret = "Error!";
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
