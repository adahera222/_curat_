using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.Reflection;
using System.Collections;
using NHibernate;
using BoglarChamp.NHibernate.Core.Entity;


namespace BoglarChamp.NHibernate.Core.DAO
{
    public class DAO_BaseMaster
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public DAO_BaseMaster() { }

        /// <summary>
        /// citeste un obiect dupa Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public virtual _ItemBase GetById(int Id, Type tip)
        {
            _ItemBase item = null;
            try
            {
                item = (_ItemBase)nHibernateUtilMaster.GetSession.Load(tip, Id);
            }
            catch (ObjectNotFoundException e)
            {
                log.Error(e.Message, e);
                throw new Exception(e.Message, e);
            }
            return item;
        }

        /// <summary>
        /// salveaza un obiect in baza de date
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public virtual _ItemBase Save(_ItemBase item)
        {
            //IValidator validator = Validation.ValidatorFactory.GetValidator(item);

            if (item.Id != 0)
            {
                AtachObjectToSession(item);
            }
            //if (!validator.IsValidToSave(item)) { return item; }

            try
            {
                nHibernateUtilMaster.GetSession.SaveOrUpdate(item);
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
                throw new Exception(e.Message, e);
            }
            finally
            {
                //validator = null;
            }

            return item;
        }


        /// <summary>
        /// sterge un item 
        /// </summary>
        /// <param name="item"></param>
        public virtual bool Delete(_ItemBase item)
        {
            //IValidator validator = Validation.ValidatorFactory.GetValidator(item);
            try
            {
                //validator.IsValidToDelete(item);
                {
                    try
                    {
                        nHibernateUtilMaster.GetSession.Delete(item);
                    }
                    catch (Exception e)
                    {
                        log.Error(e.Message, e);
                        throw new Exception(e.Message, e);
                    }
                }
            }
            finally
            {
                //validator = null;
            }
            return true;
        }
        /// <summary>
        /// sterge tot ce returneaza hql-ul
        /// </summary>
        /// <param name="hql"></param>
        /// <returns></returns>
        public virtual bool Delete(string hql)
        {
            try
            {
                nHibernateUtilMaster.GetSession.Delete(hql);
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
                throw new Exception(e.Message, e);
            }
            return true;
        }
        public virtual bool Delete(string tipItem, int itemId)
        {
            string hql = "from " + tipItem + " d where d.Id=" + itemId.ToString();
            try
            {
                nHibernateUtilMaster.GetSession.Delete(hql);
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
                throw new Exception(e.Message, e);
            }
            return true;
        }

        /// <summary>
        /// ataseaza un obiect la sesiune
        /// </summary>
        /// <param name="item"></param>
        public virtual void AtachObjectToSession(_ItemBase item)
        {
            try
            {
                nHibernateUtilMaster.GetSession.Update(item);

            }
            catch (Exception e)
            {
                log.Error(e);
                throw new Exception(e.Message, e);
            }
        }
        /// <summary>
        /// executa un hqlQuery si returneaza o lista
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual IList ExecuteHql(string query, IList parameters)
        {
            IQuery q = nHibernateUtilMaster.GetSession.CreateQuery(query);
            HqlObjectMaster hql = null;

            hql = new HqlObjectMaster(query);
            if (parameters != null)
            {
                foreach (QueryParameter p in parameters)
                {
                    hql.AddParameter(p);
                }
            }
            return hql.List();
        }
        public virtual IList ExecuteHql(string query, IList parameters, int maxResults)
        {
            IQuery q = nHibernateUtilMaster.GetSession.CreateQuery(query);
            HqlObjectMaster hql = null;

            hql = new HqlObjectMaster(query);
            if (parameters != null)
            {
                foreach (QueryParameter p in parameters)
                {
                    hql.AddParameter(p);
                }
            }
            return hql.ListMaxResults(maxResults);
        }
        /// <summary>
        /// sterge toate obiectele returnate de query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual int DeleteHql(string query, IList parameters)
        {
            HqlObjectMaster hql = null;
            hql = new HqlObjectMaster(query);
            if (parameters != null)
            {
                foreach (QueryParameter p in parameters)
                {
                    hql.AddParameter(p);
                }
            }
            return hql.Delete();
        }
    }

}
