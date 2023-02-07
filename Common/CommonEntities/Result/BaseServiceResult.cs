using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities.Result
{
    public abstract class BaseServiceResult
    { 
        public virtual ServiceErrorCode ErrorCode { get; set; }
        public virtual string MessageString { get; set; }
        public virtual IDictionary<string, string> AdditionalData { get; set; }
        public virtual bool IsError()
        {
            return this.ErrorCode != ServiceErrorCode.NoError;
        }
    }
}
