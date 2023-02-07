using CommonEntities.Base;
using static CommonEntities.Enums;

namespace CommonEntities.QuestionAnswer
{
    public class UserSubject : BaseRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public SubjectStatus SubjectStatus { get; set; }
        public int UserId { get; set; }
        public int? SystemSubjectId { get; set; }
        public int? DomainCount { get; set; }
    }
}
