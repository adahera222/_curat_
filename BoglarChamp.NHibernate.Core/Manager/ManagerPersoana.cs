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
    public class ManagerPersoana
    {
        public IList<PersoanaIMO> GetPersoaneIMO(string nume, string prenume, string functie,string firma,
            bool siAnulati, bool ordoneazaNume)
        {
            BusinessPersoana bus = null;
            IList<PersoanaIMO> ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessPersoana();
                ret = bus.GetPersoaneIMO(nume,prenume,functie,firma,siAnulati,ordoneazaNume);
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

        public bool VerificaUnicitateCod(string cod, int persoanaId)
        {
            BusinessPersoana bus = null;
            bool ret = true;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessPersoana();
                ret = bus.VerificaUnicitateCod(cod,persoanaId);
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

        public Persoana SavePersoana(Persoana p)
        {
            BusinessPersoana bus = null;
            //Persoana ret = null;
            ITransaction tx = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessPersoana();
                p = bus.SavePersoana(p);
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
            return p;
        }

        
    }
}
