using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoglarChamp.NHibernate.Core.DAO;

namespace BoglarChamp.NHibernate.Core.Entity
{
    interface IValidator
    {
        void CheckIfUnique(DAO_Base dao);
        void CheckCanDelete(DAO_Base dao);
        void CheckCanSave(DAO_Base dao);
    }
}
