using CommonEntities.QuestionAnswer;

namespace QuestionAnswer.API.Repository
{
    public interface IQuestionAnswerRepository
    {
        Task<IEnumerable<UserSubject>> GetAllUserSubjectByUserId(int userId);
        Task<bool> SaveUserSetting(UserSetting userSetting);
        Task<IEnumerable<UserDomain>> GetAllUserDomainBySubjectId(int subjectId);
        Task<IEnumerable<UserQuestionAnswer>> GetAllUserQuestionAnswerByDomainId(int domainId);
        Task<IEnumerable<UserQuestionAnswer>> GetAllUserQuestionAnswerByUserId(int userId);
        Task<UserQuestionAnswer> GetRandomQuestionAnswerByDomainId(int domainId);
        Task<UserQuestionAnswer> GetUserQuestionAnswerById(int id);
        Task<bool> UpdatePrepairdRatioByQuesionAnswerId(int QuesionAnswerId);
        Task<bool> SaveUserQuestionAnswerById(UserQuestionAnswer userQuestionAnswer);
        Task<bool> SaveUserQuestionAnswer(UserQuestionAnswer userQuestionAnswer);
        Task<bool> SaveUserSubject(UserSubject userSubject);
    }
}
