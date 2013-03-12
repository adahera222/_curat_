using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using NHibernate;
using System.Threading;

namespace BoglarChamp.NHibernate.Core.DAO
{
    public class HqlObjectMaster
    {
        private string sqlBase = "";
        private IList queryParameters = new ArrayList();


        /// <summary>
        /// ctor (stringul HQL de baza)
        /// </summary>
        /// <param name="sqlBase"></param>
        public HqlObjectMaster(string sqlBase)
        {
            this.sqlBase = sqlBase;
        }

        /// <summary>
        /// stringul de baza
        /// </summary>
        public string SqlBase
        {
            get { return sqlBase; }
            set { sqlBase = value; }
        }

        /// <summary>
        /// lista de parametrii
        /// </summary>
        public IList QueryParameters
        {
            get { return queryParameters; }
        }

        /// <summary>
        /// adauga un parametru
        /// </summary>
        /// <param name="parameter"></param>
        public void AddParameter(QueryParameter parameter)
        {
            //verifica daca este ok
            if (TestParameter(parameter))
            {
                queryParameters.Add(parameter);
            }
        }

        //verifica daca parametrul are specificati toti membrii
        private bool TestParameter(QueryParameter parameter)
        {
            if (parameter.ParamName == "")
            {
                throw new Exception("Nu ati specificat numele parametrului");
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.LipsaNumeParametru);

            }
            if (parameter.MemberName == "")
            {
                throw new Exception("Nu ati specificat numele mebrului testat");
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.LipsaMembru);

            }
            if (parameter.ParamValue == null)
            {
                throw new Exception("Nu ati specificat valoarea parametrului");
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.LipsaValoareParametru);

            }
            //verifica daca membrul specificat exista in query
            TestIfMemberNotExist(parameter.MemberName);

            return true;
        }

        private bool TestIfMemberNotExist(string memberName)
        {
            if (sqlBase.IndexOf(memberName) == 0)
            {
                throw new Exception("Membrul specificat (" + memberName + ") nu exista!");
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(string.Format(Resources.Core.LipsaMembru1,memberName));

            }
            return true;
        }

        /// <summary>
        /// creaza query combinand toti parametrii
        /// </summary>
        /// <returns></returns>
        public string GetFullQuery()
        {
            string query = "";
            foreach (QueryParameter parameter in queryParameters)
            {
                if (query == "")
                {
                    query = parameter.GetQuery();
                }
                else
                {
                    query = query + parameter.JunctionConditionToString() + parameter.GetQuery();
                }
            }
            if (query == "")
            {
                query = sqlBase;
            }
            else
            {
                query = sqlBase + " where " + query;
            }
            return query;
        }
        private string GetFullQuery(IList parameters)
        {
            string ret = sqlBase;
            if (parameters != null)
            {
                if (parameters.Count > 0) { ret = ret + " where "; }
                foreach (QueryParameter o in parameters)
                {
                    if (ret.IndexOf(";") == -1)
                    {
                        ret = ret + " " + o.MemberName + o.ConditionToString + o.ParamValue + ";";
                    }
                    else
                    {
                        ret = ret.Replace(";", "");
                        ret = ret + " " + o.JunctionConditionToString() + " " + o.MemberName + o.ConditionToString + o.ParamValue + ";";
                    }
                }
            }
            ret = ret.Replace(";", "");
            //			ret=ret.Replace("_Equals_","=");
            return ret;
        }
        /// <summary>
        /// returneaza o lista de obiecte, paramterii transformati in hqlString
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IList List(IList parameters)
        {
            IList ret;
            IQuery q;
            try
            {
                queryParameters = parameters;
                q = nHibernateUtilMaster.GetSession.CreateQuery(GetFullQuery(parameters));
                ret = q.List();
            }
            finally
            {
                q = null;
            }
            return ret;
        }
        /// <summary>
        /// returneaza o lista de obiecte specifice
        /// </summary>
        /// <returns></returns>
        public IList List()
        {
            IList ret;
            IQuery q;
            try
            {
                q = nHibernateUtilMaster.GetSession.CreateQuery(GetFullQuery());

                //parametrii pentru status
                if (queryParameters != null)
                {
                    foreach (QueryParameter parameter in queryParameters)
                    {
                        q.SetParameter(parameter.ParamName, parameter.ParamValue);
                    }
                }
                ret = q.List();
            }
            finally
            {
                q = null;
            }
            return ret;
        }
        /// <summary>
        /// returneaza o lista de obiecte specifice
        /// </summary>
        /// <returns></returns>
        public IList ListMaxResults(int maxResults)
        {
            IList ret;
            IQuery q;
            try
            {
                q = nHibernateUtilMaster.GetSession.CreateQuery(GetFullQuery()).SetFirstResult(0).SetMaxResults(maxResults);

                //parametrii pentru status
                if (queryParameters != null)
                {
                    foreach (QueryParameter parameter in queryParameters)
                    {
                        q.SetParameter(parameter.ParamName, parameter.ParamValue);
                    }
                }
                
                ret = q.List();
            }
            finally
            {
                q = null;
            }
            return ret;
        }
        public IList ListSimple()
        {
            IList ret;
            IQuery q;
            try
            {
                q = nHibernateUtilMaster.GetSession.CreateQuery(sqlBase);

                //parametrii pentru status
                if (queryParameters != null)
                {
                    foreach (QueryParameter parameter in queryParameters)
                    {
                        q.SetParameter(parameter.ParamName, parameter.ParamValue);
                    }
                }
                ret = q.List();
            }
            finally
            {
                q = null;
            }
            return ret;
        }

        public int Delete()
        {
            int ret = 0;
            ret = nHibernateUtilMaster.GetSession.Delete(GetFullQuery());
            return ret;
        }
    }

}
