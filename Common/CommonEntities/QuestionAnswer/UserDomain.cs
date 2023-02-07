using CommonEntities.Base;
using static CommonEntities.Enums;

namespace CommonEntities.QuestionAnswer
{
    public class UserDomain : BaseRequest
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Name { get; set; }
        public DomainStatus DomainStatus { get; set; }
        public int? SubjectId { get; set; }
        public int? SystemDomainId { get; set; }
        public int QuestionAnswerCount { get; set; }
    }
}
