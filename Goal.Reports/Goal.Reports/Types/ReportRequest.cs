using Goal.Reports.Types.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal.Reports.Types
{
    internal class ReportRequest
    {

        private Dictionary<string, object> TablesDic;
        private Dictionary<string, Type> TypeDic;

        public ReportRequest()
        {
            this.TablesDic = new Dictionary<string, object>();
            this.TypeDic = new Dictionary<string, Type>();
        }

        internal void AddData(string name, Type t, IEnumerable data)
        {
            TypeDic.Add(name, t);
            TablesDic.Add(name, data);
        }

        internal T getData<T>(string name)
        {
            return (T)Convert.ChangeType(TablesDic[name], typeof(T));
        }

        internal Type getType(string name)
        {
            return TypeDic[name];
        }

    }
}
