using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoglarChamp.NHibernate.Core.Entity
{
    [Serializable]
    public class _ItemBase
    {
        int id = 0;
        public virtual int Id { get { return id; } set { id = value; } }
    }
}
