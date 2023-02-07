using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CommonEntities.Result
{
    public class ServiceResultWithData<TData> : ServiceResult
    {
        public virtual TData Data { get; set; }
    }
}
