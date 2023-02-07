using CommonEntities.Base;
using static CommonEntities.Enums;

namespace CommonEntities.QuestionAnswer
{
    public class UserQuestionAnswer : BaseRequest
    {
        public int id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int? DomainId { get; set; }
        public int? UserId { get; set; }
        public QuestionAnswerStatus QuestionAnswerStatus { get; set; }
        public string UseFullLink { get; set; }
        public int? PrepairedRatio { get; set; }
        public int? SystemQuestionAnswerId { get; set; }
    }
}
