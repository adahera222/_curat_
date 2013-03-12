using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

namespace BoglarChamp.NHibernate.Core.DAO
{
    [Serializable]
    public class QueryParameterList : IList
    {
        private IList mCol = new ArrayList();

        /// <summary>
        /// ctor
        /// </summary>
        public QueryParameterList() { }

        /// <summary>
        /// adauga un parametru in lista de parametrii
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="paramValue"></param>
        /// <param name="memberName"></param>
        /// <param name="condition"></param>
        /// <param name="joinCondition"></param>
        public void AddParameter(string paramName, object paramValue, string memberName, OperatorType condition, OperatorJoinType joinCondition)
        {
            QueryParameter q = new QueryParameter(paramName, paramValue, memberName, condition, joinCondition);
            mCol.Add(q);
        }

        /// <summary>
        /// adauga un parametru in lista de parametrii
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="paramValue"></param>
        /// <param name="memberName"></param>
        /// <param name="condition"></param>
        public void AddParameter(string paramName, object paramValue, string memberName, OperatorType condition)
        {
            QueryParameter q = new QueryParameter(paramName, paramValue, memberName, condition);
            mCol.Add(q);
        }

        /// <summary>
        /// adauga un parametru in lista de parametrii
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="paramValue"></param>
        public void AddParameter(string paramName, object paramValue)
        {
            QueryParameter q = new QueryParameter(paramName, paramValue);
            mCol.Add(q);
        }

        #region IList Members

        public bool IsReadOnly
        {
            get
            {
                return mCol.IsReadOnly;
            }
        }

        public object this[int index]
        {
            get
            {
                return mCol[index];

            }
            set
            {
                mCol[index] = value;
            }
        }

        public void RemoveAt(int index)
        {
            mCol.RemoveAt(index);
        }

        public void Insert(int index, object value)
        {
            mCol.Insert(index, value);
        }

        public void Remove(object value)
        {
            mCol.Remove(value);
        }

        public bool Contains(object value)
        {
            return mCol.Contains(value);
        }

        public void Clear()
        {
            mCol.Clear();
        }

        public int IndexOf(object value)
        {
            return mCol.IndexOf(value);
        }

        public int Add(object value)
        {
            return mCol.Add(value);
        }

        public bool IsFixedSize
        {
            get
            {
                return mCol.IsFixedSize;
            }
        }

        #endregion

        #region ICollection Members

        public bool IsSynchronized
        {
            get
            {
                return mCol.IsSynchronized;
            }
        }

        public int Count
        {
            get
            {
                return mCol.Count;
            }
        }

        public void CopyTo(Array array, int index)
        {
            mCol.CopyTo(array, index);
        }

        public object SyncRoot
        {
            get
            {
                return mCol.SyncRoot;
            }
        }

        #endregion

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return mCol.GetEnumerator();
        }

        #endregion
    }
    /// <summary>
    /// Tip operator de jonctiune intre doua conditii
    /// </summary>
    [Serializable]
    public enum OperatorJoinType
    {
        OR,
        AND
    }

    /// <summary>
    /// Tip Operator
    /// </summary>
    [Serializable]
    public enum OperatorType
    {
        Equals,
        NotEquals,
        Greather,
        GreatherOrEquals,
        Less,
        LessOrEquals,
        Like,
        NotLike,
        In
    }

    public class QueryParameter
    {
        private string paramName;
        private object paramValue;
        private string memberName;
        private OperatorType condition;
        private OperatorJoinType andOrCondition;
        private string conditionToString;

        /// <summary>
        /// parametru folosit in constructia HqlObject
        /// </summary>
        /// <example>memberName condition: paramName</example>
        /// <param name="paramName">numele parametrului folosit</param>
        /// <param name="paramValue">valoarea parametrului ce va fi inlocuit</param>
        /// <param name="memberName">membrul din query ce va fi comparat</param>
        /// <param name="condition">conditia de comparatie ('=', 'Like', etc)</param>
        /// <param name="andOrCondition">conditia de concatenare in cazul mai multor parametrii (AND sau OR)</param>
        public QueryParameter(string paramName, object paramValue, string memberName, OperatorType condition, OperatorJoinType andOrCondition)
        {
            this.paramName = paramName;
            this.paramValue = paramValue;
            this.memberName = memberName;
            this.condition = condition;
            this.andOrCondition = andOrCondition;
        }

        /// <summary>
        /// parametru folosit in constructia HqlObject
        /// </summary>
        /// <example>memberName condition: paramName</example>
        /// <param name="paramName">numele parametrului folosit</param>
        /// <param name="paramValue">valoarea parametrului ce va fi inlocuit</param>
        /// <param name="memberName">membrul din query ce va fi comparat</param>
        /// <param name="condition">conditia de comparatie ('=', 'Like', etc)</param>
        public QueryParameter(string paramName, object paramValue, string memberName, OperatorType condition)
        {
            this.paramName = paramName;
            this.paramValue = paramValue;
            this.memberName = memberName;
            this.condition = condition;
        }

        public QueryParameter(string paramName, object paramValue)
        {
            this.paramName = paramName;
            this.paramValue = paramValue;
        }

        /// <summary>
        /// creaza stringul pentru query (memberName conditie: paramName)
        /// </summary>
        /// <returns></returns>
        public string GetQuery()
        {
            string query = "";
            if (memberName == "")
            {
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.LipsaMembru);
                throw new Exception("LipsaMembru");
            }
            if (paramName == null)
            {
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.LipsaNumeParametru);
                throw new Exception("LipsaNumeParametru");
            }
            if (paramValue == null)
            {
                //Resources.Core.Culture = Thread.CurrentThread.CurrentCulture;
                //throw new Exception(Resources.Core.LipsaValoareParametru);
                throw new Exception("LipsaValoareParametru");
            }
            query = GetQueryBasedConditionType(memberName, condition, paramName);
            return query;
        }

        /// <summary>
        /// in functie de tipul conditiei adauga :
        /// </summary>
        /// <param name="memberName"></param>
        /// <param name="condition"></param>
        /// <param name="paramName"></param>
        /// <returns></returns>
        private string GetQueryBasedConditionType(string memberName, OperatorType condition, string paramName)
        {
            string query = "";
            switch (condition)
            {
                case OperatorType.In:
                    query = memberName + " " + ConvertConditionToString(condition) + "(:" + paramName + ")";
                    break;
                case OperatorType.Like:
                    query = memberName + " " + ConvertConditionToString(condition) + ":" + paramName;
                    break;
                case OperatorType.NotLike:
                    query = memberName + " " + ConvertConditionToString(condition) + ":" + paramName;
                    break;
                default:
                    query = memberName + " " + ConvertConditionToString(condition) + ":" + paramName;
                    break;
            }
            return query;
        }

        /// <summary>
        /// returneaza valoarea ca si string a conditiei
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        private string ConvertConditionToString(OperatorType condition)
        {
            string name = "";
            switch (condition)
            {
                case OperatorType.Equals:
                    name = "=";
                    break;
                case OperatorType.Greather:
                    name = ">";
                    break;
                case OperatorType.GreatherOrEquals:
                    name = ">=";
                    break;
                case OperatorType.Less:
                    name = "<";
                    break;
                case OperatorType.LessOrEquals:
                    name = "<=";
                    break;
                case OperatorType.Like:
                    name = " Like ";
                    break;
                case OperatorType.NotEquals:
                    name = "<>";
                    break;
                case OperatorType.NotLike:
                    name = " NOT Like ";
                    break;
                case OperatorType.In:
                    name = " in ";
                    break;
            }
            return name;
        }

        public string ConditionToString
        {
            get
            {
                conditionToString = ConvertConditionToString(condition);
                return conditionToString;
            }
        }

        /// <summary>
        /// numele parametrului
        /// </summary>
        public string ParamName
        {
            get { return paramName; }
            set { paramName = value; }
        }

        /// <summary>
        /// valoarea parametrului
        /// </summary>
        public object ParamValue
        {
            get { return paramValue; }
            set { paramValue = value; }
        }

        /// <summary>
        /// numele membrului testat
        /// </summary>
        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }

        /// <summary>
        /// conditia testata: memberName ? paramName
        /// </summary>
        public OperatorType Condition
        {
            get { return condition; }
            set { condition = value; }
        }


        /// <summary>
        /// conditia de inlantuire AND sau OR
        /// </summary>
        public OperatorJoinType AndOrCondition
        {
            get { return andOrCondition; }
            set { andOrCondition = value; }
        }

        public string JunctionConditionToString()
        {
            string condition = "";
            if (andOrCondition == OperatorJoinType.AND)
            {
                condition = " AND ";
            }
            else
            {
                condition = " OR ";
            }
            return condition;
        }
    }

}
