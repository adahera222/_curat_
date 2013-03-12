using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NHibernate.Tool.hbm2ddl;
using BoglarChamp.NHibernate.Core.DAO;
using log4net;

namespace BoglarChamp.NHibernate.Core
{
    static class Program

    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();

            //GenerateDDL();
            //DateTime date = JavaTimeStampToDateTime(1320931401540);
            //double dd = DateTimeToJavaTimeStamp(date);
            //date = JavaTimeStampToDateTime(dd);

            //DAL_SqlLite dal = new DAL_SqlLite();
            //dal.CreazaBazaDate("TEST", "c:\\");
            //		Ticks	634565354020000000	long

            log.Error("test");
            //Tests t = new Tests();
            //t.ComputeBlockedCustomers();
            //t.setStoc();
            //t.TestGetUrmarireAgentDetalii();
            // t.TestGetClienti();
            //t.TestGetFirma();
            //t.TestComanda();
            // t.testInWork();
            //t.testDeserialize();

            //DAO_Base dao = new DAO_Base();
            //IList xx= dao.ExecuteHql("select u from Utilizator u", null);
            //System.Console.WriteLine("done!");
            //System.Console.ReadLine();

        }
        public static DateTime JavaTimeStampToDateTime(double javaTimeStamp)
        {
            // Java timestamp is millisecods past epoch     
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddMilliseconds(Math.Round(javaTimeStamp)).ToLocalTime();
            return dtDateTime;
        }
        public static double DateTimeToJavaTimeStamp(DateTime date)
        {
            // Java timestamp is millisecods past epoch     
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            return (date - dtDateTime).TotalMilliseconds;
            //dtDateTime = dtDateTime.AddSeconds(-Math.Round(javaTimeStamp / 1000)).ToLocalTime();
            //return dtDateTime.Millisecond;
        }
        public static void GenerateDDL()
        {
            try
            {
                SchemaExport sch = new SchemaExport(nHibernateUtil.nhibernateConfiguration);
                string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                sch.SetOutputFile(path + @"\schema.sql");

                sch.Execute(true, true, false, true);
                System.Console.WriteLine("Generare cu success!");
                log.Debug("Creare fisier DDL: " + path + @"\schema.sql");
            }
            catch (Exception e)
            {
                log.Error(e);
            }
        }
    }
}
