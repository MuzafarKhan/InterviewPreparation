using CommonEntities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities.Auth
{
    public class CreateTokenResponse
    {
        public UserInfo UserInfo { get; set; }
        public string Token { get; set; }
    }
}
