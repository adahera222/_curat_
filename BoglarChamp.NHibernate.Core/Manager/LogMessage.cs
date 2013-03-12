using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using NHibernate;
using log4net;
using System.Reflection;

namespace BoglarChamp.NHibernate.Core
{
    public class LogMessage
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static LogMessage()
        {
            log4net.Config.XmlConfigurator.Configure();

        }
        internal static void Error(Exception ex)
        {
            log.Error("BoglarChamp.Manager", ex);
        }
    }
}
