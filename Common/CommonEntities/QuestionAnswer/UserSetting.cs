using CommonEntities.Base;
using static CommonEntities.Enums;

namespace CommonEntities.QuestionAnswer
{
    public class UserSetting : BaseRequest
    {
        public int Id { get; set; }
        public int? SubjectId { get; set; }
        public int? UserId { get; set; }
    }
}
