using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.DAO;

namespace BoglarChamp.NHibernate.Core
{
    internal class _BusinessBase
    {
        internal DAO_Base dao = null;

        internal _BusinessBase()
        {
            dao = new DAO_Base();
        }
        ~_BusinessBase()
        {
            dao = null;
        }
    }
}
