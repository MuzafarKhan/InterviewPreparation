using CommonEntities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CommonEntities.Enums;

namespace CommonEntities.Auth
{
    public class UserInfo : BaseRequest
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserInfoStatus UserInfoStatus { get; set; }
        public string MobileNumber { get; set; }
        public int UserSubjectId { get; set; }
    }
}
