using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using NHibernate;
using NHibernate.Cfg;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Diagnostics;

namespace BoglarChamp.NHibernate.Core.DAO
{
    public class nHibernateUtil
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static bool isDebugEnabled = log.IsDebugEnabled;

        [ThreadStatic]
        private static ISession threadSes;

        [ThreadStatic]
        private static ITransaction threadTr;

        private static nHibernateUtil _sessionFactory = new nHibernateUtil();
        private static Configuration _nhibernateConfiguration;
        private static ISessionFactory _nhibernateFactory;

        public static Configuration nhibernateConfiguration
        {
            get { return _nhibernateConfiguration; }
            set { _nhibernateConfiguration = value; }
        }


        /// <summary>
        /// creaza o noua sesiune
        /// </summary>
        public static ISession GetSession
        {
            get
            {

                ISession s = threadSes;
                try
                {
                    if (s == null)
                    {
                        s = _nhibernateFactory.OpenSession();
                        threadSes = s;
                        if (isDebugEnabled)
                        {
                            log.Debug("getSession - new session");
                        }
                    }
                    else
                    {
                        if (!s.IsConnected)
                        {
                            s.Reconnect();
                        }
                        if (!s.IsOpen)
                        {
                            s = _nhibernateFactory.OpenSession();
                        }
                        if (isDebugEnabled)
                        {
                            log.Debug("getSession - existing session");
                        }
                        threadSes = s;
                    }
                }
                catch (Exception e)
                {
                    log.Debug("Error - " + e.ToString(), e);
                    //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                    //throw new Exception(Resources.Core.EroareNecunoscuta);
                    throw new Exception("Eroare Necunoscuta");

                }
                return s;
            }
        }
             /// <summary>
        /// creaza o noua sesiune
        /// </summary>
        public static ISession SetDbToSession(string database)
        {
            ISession s = threadSes;
            try
            {
                if (s == null)
                {
                    IDbConnection dbConn = _nhibernateFactory.OpenSession().Connection;
                    log.Debug ("CURRENT DB: " + dbConn.Database);
                    dbConn.ChangeDatabase(database);
                    log.Debug("NEW CURRENT DB: " + dbConn.Database);

                    s = _nhibernateFactory.OpenSession(dbConn);
                    threadSes = s;
                    if (isDebugEnabled)
                    {
                        log.Debug("getSession - new session");
                    }
                }
                else
                {
                    if (!s.IsConnected)
                    {
                        s.Reconnect();
                    }
                    if (!s.IsOpen)
                    {
                        s = _nhibernateFactory.OpenSession();
                    }
                    if (isDebugEnabled)
                    {
                        log.Debug("getSession - existing session");
                    }
                    threadSes = s;
                }
            }
            catch (Exception e)
            {
                log.Debug("Error - " + e.ToString(), e);
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.EroareNecunoscuta);
                throw new Exception("Eroare Necunoscuta");
            }
            return s;
        }


        /// <summary>
        /// close session
        /// </summary>
        public static void CloseSession()
        {
            try
            {
                ISession s = threadSes;
                ITransaction tx = threadTr;
                if (tx != null)
                {
                    tx = null;
                    threadTr = null;
                    if (isDebugEnabled)
                    {
                        log.Debug("closeSession - existent transaction; transaction set to null");
                    }
                }
                else
                {
                    if (isDebugEnabled)
                    {
                        log.Debug("closeSession - inexistent transaction; nothing to set");
                    }
                }

                threadSes = null;
                if (s != null && s.IsOpen)
                {
                    //					s.Flush();
                    //					if (isDebugEnabled)
                    //					{
                    //						log.Debug("closeSession - flush session");
                    //					}
                    s.Close();
                    if (isDebugEnabled)
                    {
                        log.Debug("closeSession - close session");
                    }

                }
            }
            catch (Exception e)
            {
                log.Debug("Error - " + e.ToString(), e);
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.EroareNecunoscuta);
                throw new Exception("Eroare Necunoscuta");
            }
        }


        /// <summary>
        /// creaza o noua tranzactie 
        /// </summary>
        public static ITransaction BeginTransaction()
        {
            ITransaction tx = threadTr;
            try
            {
                if (tx == null)
                {
                    tx = GetSession.BeginTransaction();
                    threadTr = tx;
                    if (isDebugEnabled)
                    {
                        log.Debug("beginTransaction - transaction inexist; new transaction");
                    }
                }
                else
                {
                    if (isDebugEnabled)
                    {
                        log.Debug("beginTransaction - transaction exist; reusing transaction ");
                    }
                }
            }
            catch (Exception e)
            {
                log.Error("Error - " + e.Message, e);
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.EroareNecunoscuta);
                throw new Exception("Eroare Necunoscuta");
            }
            return threadTr;
        }
        public static string nHibernateConnectionString()
        {
            string ret = GetSession.Connection.ConnectionString + ";password=wy7c1kqt*()_+;";
            return ret;
        }
        public static string nHibernateConnectionString(string dataBase)
        {
            //local
            //            string ret = getSession.Connection.ConnectionString + ";password=12345;";
            //pangram
            string ret = GetSession.Connection.ConnectionString + ";password=wy7c1kqt*()_+;";
            ret = ret.Replace(GetSession.Connection.Database, dataBase);
            return ret;
            //			return "packet size=4096;user id=sa;data source=(local);persist security info=True;initial catalog=pangram_dbo;password=12345";
        }
        public static void SetnHibernateConnectionString(string dataBase)
        {
            GetSession.Connection.ChangeDatabase(dataBase);
            
        }
        /// <summary>
        /// comite tranzactia
        /// </summary>
        //public static void commitTransaction()
        //{
        //    ITransaction tx = threadTr;
        //    try
        //    {
        //        if (tx != null && !tx.WasCommitted && !tx.WasRolledBack)
        //        {
        //            tx.Commit();
        //            threadTr = null;
        //            if (isDebugEnabled)
        //            {
        //                log.Debug("commitTransaction - transaction exist; commiting transaction ");
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        log.Debug("Error - " + e.Message, e);
        //        throw new Exception(e.Message, e);
        //    }
        //}


        /// <summary>
        /// reseteaza tranzactia in curs
        /// </summary>
        //public static void rollbackTransaction()
        //{
        //    ITransaction tx = threadTr;
        //    try
        //    {
        //        if (tx != null && !tx.WasCommitted && !tx.WasRolledBack)
        //        {
        //            //					tx.Rollback();
        //            threadSes.Transaction.Rollback();
        //            if (isDebugEnabled)
        //            {
        //                log.Debug("rollbackTransaction - transaction exist; rollbacking transaction ");
        //            }
        //            tx = null;
        //            threadTr = null;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        log.Debug("Error - " + e.Message, e);
        //        throw new Exception(e.Message, e);
        //    }
        //    finally
        //    {
        //        closeSession();
        //    }
        //}


        /// <summary>
        /// inchide sesiunea deschisa de hibernate (pentru initializare "curata")
        /// </summary>
        public static void NewApplicationTx()
        {
            CloseSession();
            if (isDebugEnabled)
            {
                log.Debug("newApplicationTx - closing session ");
            }
        }


        /// <summary>
        /// deconecteaza sesiunea
        /// </summary>
        /// <returns></returns>
        public static ISession DisconectSession()
        {
            ISession session = GetSession;
            try
            {
                ITransaction tx = threadTr;
                if (tx != null)
                {
                    if (tx != null && !tx.WasCommitted && !tx.WasRolledBack)
                    {
                        tx.Rollback();
                        tx = null;
                        threadTr = null;
                    }
                    else
                    {
                        tx = null;
                        threadTr = null;
                    }
                }
                threadSes = null;
                if (session.IsConnected && session.IsOpen)
                {
                    session.Disconnect();
                    if (isDebugEnabled)
                    {
                        log.Debug("disconnetcSession - session exit; disconnect session");
                    }
                }
            }
            catch (Exception e)
            {
                log.Debug("Error - " + e.Message, e);
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.EroareNecunoscuta);
                throw new Exception("Eroare Necunoscuta");
            }
            return session;
        }


        /// <summary>
        /// reconecteaza sesiunea
        /// </summary>
        /// <param name="session"></param>
        public static void Reconnect(ISession session)
        {
            try
            {
                session.Reconnect();
                threadSes = session;
                if (isDebugEnabled)
                {
                    log.Debug("reconnect - reconnect to existing session");
                }
            }
            catch (HibernateException e)
            {
                log.Debug("Error - " + e.Message, e);
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.EroareNecunoscuta);
                throw new Exception("Eroare Necunoscuta");
            }
            catch (Exception e)
            {
                log.Debug("Error - " + e.Message, e);
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.EroareNecunoscuta);
                throw new Exception("Eroare Necunoscuta");
            }
        }


        /// <summary>
        /// Default constructor.
        /// </summary>
        protected nHibernateUtil()
        {
            LoadMappingFile();
            BuildSessionFactory();
        }


        /// <summary>
        /// Incarca fisierele de mapare
        /// </summary>
        private void LoadMappingFile()
        {
            try
            {
                // Debugger.Break();
                Configuration config = new Configuration();
                string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                _nhibernateConfiguration = config.Configure(path + @"\hibernate.cfg.xml");
                //_nhibernateConfiguration = config.Configure();
                if (isDebugEnabled) { log.Debug("LoadMappingFile: Mapp file load OK!"); };

            }
            catch (MappingException e)
            {
                log.Debug("Error - " + e.ToString());
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.EroareNecunoscuta);
                throw new Exception("Futere de utere!!!");
            }
            catch (Exception e)
            {
                log.Debug("Error - " + e.ToString());
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.EroareNecunoscuta);
                throw new Exception(e.ToString());
            }
        }


        /// <summary>
        /// construieste SessionFactory
        /// </summary>
        private void BuildSessionFactory()
        {
            try
            {
                log4net.Config.XmlConfigurator.Configure();
                nHibernateUtil._nhibernateFactory = _nhibernateConfiguration.BuildSessionFactory();
                if (isDebugEnabled) { log.Debug("RegisterCoreClasses/BuildSessionFactory"); };
            }
            catch (HibernateException e)
            {
                log.Debug("Error - " + e);
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.EroareNecunoscuta);
                throw e;
            }
            catch (Exception e)
            {
                log.Debug("Error - " + e.Message, e);
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.EroareNecunoscuta);
                throw e;
            }
        }


        /// <summary>
        /// GetNHibernateFactory returns the current NHibernate ISessionFactory.
        /// </summary>
        public static ISessionFactory getNHibernateFactory
        {
            get { return nHibernateUtil._nhibernateFactory; }
        }

    }

}
