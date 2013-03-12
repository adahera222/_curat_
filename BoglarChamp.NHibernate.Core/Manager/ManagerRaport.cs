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
    public class ManagerRaport
    {


        public IList<ScanareIMO> GetScanari(string nume, string prenume, string firma,int sefId,
            DateTime dataStart, DateTime dataEnd)
        {
            BusinessScanare bus = null;
            ITransaction tx = null;
            IList<ScanareIMO> ret = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessScanare();
                ret = bus.GetScanari(nume, prenume, firma, sefId, dataStart, dataEnd);
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
                bus = null;
                nHibernateUtil.CloseSession();
                tx = null;
            }
            return ret;
        }

        public IList<RaportMuncitorIMO> RaportMuncitori(string nume, string prenume, DateTime dataStart, DateTime dataEnd)
        {
            BusinessScanare bus = null;
            ITransaction tx = null;
            IList<RaportMuncitorIMO> ret = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessScanare();
                ret = bus.GetRaportMuncitori(nume, prenume, dataStart, dataEnd);
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
                bus = null;
                nHibernateUtil.CloseSession();
                tx = null;
            }
            return ret;
        }

        public IList<RaportMuncitorIMO> RaportTotalMuncitori(DateTime dataStart, DateTime dataEnd)
        {
            BusinessScanare bus = null;
            ITransaction tx = null;
            IList<RaportMuncitorIMO> ret = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessScanare();
                ret = bus.GetRaportTotalMuncitori(dataStart, dataEnd);
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
                bus = null;
                nHibernateUtil.CloseSession();
                tx = null;
            }
            return ret;
        }

        public IList<ScanareIMO> GetScanariAmbalaje(string firma,string ambalaj, DateTime dataStart, DateTime dataEnd)
        {
            BusinessScanare bus = null;
            ITransaction tx = null;
            IList<ScanareIMO> ret = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessScanare();
                ret = bus.GetScanariAmbalaje(firma,ambalaj, dataStart, dataEnd);
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
                bus = null;
                nHibernateUtil.CloseSession();
                tx = null;
            }
            return ret;
        }



        public IList<RaportCumulatMuncitorIMO> RaportSefEchipa(int firmaId,int sefId, DateTime dataStart, DateTime dataEnd)
        {
            BusinessScanare bus = null;
            ITransaction tx = null;
            IList<RaportCumulatMuncitorIMO> ret = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessScanare();
                ret = bus.GetRaportSefEchipa(firmaId,sefId, dataStart, dataEnd);
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
                bus = null;
                nHibernateUtil.CloseSession();
                tx = null;
            }
            return ret;
        }

        public IList<RaportCumulatMuncitorIMO> RaportSefiEchipa(int firmaId, int sefId, DateTime dataStart, DateTime dataEnd)
        {
            BusinessScanare bus = null;
            ITransaction tx = null;
            IList<RaportCumulatMuncitorIMO> ret = null;

            try
            {
                tx = nHibernateUtil.BeginTransaction();

                bus = new BusinessScanare();
                ret = bus.GetRaportSefiEchipa(firmaId, sefId, dataStart, dataEnd);
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
                bus = null;
                nHibernateUtil.CloseSession();
                tx = null;
            }
            return ret;
        }
    }
}
