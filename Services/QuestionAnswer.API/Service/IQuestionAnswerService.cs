using CommonEntities.QuestionAnswer;
using CommonEntities.Result;

namespace QuestionAnswer.API.Service
{
    public interface IQuestionAnswerService
    {
        Task<ServiceResultWithData<IEnumerable<UserSubject>>> GetAllUserSubjectByUserId(int userId);
        Task<ServiceResultWithData<bool>> SaveUserSetting(UserSetting userSetting);
        Task<ServiceResultWithData<IEnumerable<UserDomain>>> GetAllUserDomainBySubjectId(int subjectId);
        Task<ServiceResultWithData<IEnumerable<UserQuestionAnswer>>> GetAllUserQuestionAnswerByDomainId(int domainId);
        Task<ServiceResultWithData<IEnumerable<UserQuestionAnswer>>> GetAllUserQuestionAnswerByUserId(int userId);
        Task<ServiceResultWithData<UserQuestionAnswer>> GetRandomQuestionAnswerByDomainId(int domainId);
        Task<ServiceResultWithData<UserQuestionAnswer>> GetUserQuestionAnswerById(int id);
        Task<ServiceResultWithData<bool>> UpdatePrepairdRatioByQuesionAnswerId(int QuesionAnswerId);
        Task<ServiceResultWithData<bool>> SaveUserQuestionAnswerById(UserQuestionAnswer userQuestionAnswer);
        Task<ServiceResultWithData<bool>> SaveUserQuestionAnswer(UserQuestionAnswer userQuestionAnswer);
        Task<ServiceResultWithData<bool>> SaveUserSubject(UserSubject userSubject);
    }
}
