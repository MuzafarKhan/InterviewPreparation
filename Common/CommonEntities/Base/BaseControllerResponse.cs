using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities.Base
{
    public class BaseControllerResponse <TPayload>
    {
        public TPayload Payload { get; set; }
    }
}
