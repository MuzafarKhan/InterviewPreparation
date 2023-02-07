using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities.Base
{
    public class ErrorResponse : BaseResponse
    {
        public virtual ApiErrorCode ApiErrorCode { get; set; }
        public virtual string ApiErrorString { get; set; }
        public virtual IDictionary<string, string> AdditionalData { get; set; }
    }
}
