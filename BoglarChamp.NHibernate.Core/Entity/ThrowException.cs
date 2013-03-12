using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoglarChamp.NHibernate.Core.Entity
{
    public static class ThrowException
    {
        public static void Set(string mesaj)
        {
            throw new Exception(mesaj);
        }
    }
}
