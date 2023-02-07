using CommonEntities.Auth;
using CommonEntities.QuestionAnswer;
using CommonEntities.Result;
using QuestionAnswer.API.Repository;
using System.Collections.Generic;

namespace QuestionAnswer.API.Service
{
    public class QuestionAnswerService : IQuestionAnswerService
    {
        public IQuestionAnswerRepository _questionAnswerRepository;
        public QuestionAnswerService(IQuestionAnswerRepository questionAnswerRepository)
        {
            _questionAnswerRepository = questionAnswerRepository;
        }
        public async Task<ServiceResultWithData<IEnumerable<UserDomain>>> GetAllUserDomainBySubjectId(int subjectId)
        {
            var result = new ServiceResultWithData<IEnumerable<UserDomain>>();
            result.Data = await _questionAnswerRepository.GetAllUserDomainBySubjectId(subjectId);
            return result;
        }

        public async Task<ServiceResultWithData<IEnumerable<UserQuestionAnswer>>> GetAllUserQuestionAnswerByDomainId(int domainId)
        {
            var result = new ServiceResultWithData<IEnumerable<UserQuestionAnswer>>();
            result.Data = await _questionAnswerRepository.GetAllUserQuestionAnswerByDomainId(domainId);
            return result;
        }

        public async Task<ServiceResultWithData<IEnumerable<UserQuestionAnswer>>> GetAllUserQuestionAnswerByUserId(int userId)
        {
            var result = new ServiceResultWithData<IEnumerable<UserQuestionAnswer>>();
            result.Data = await _questionAnswerRepository.GetAllUserQuestionAnswerByUserId(userId);
            return result;
        }

        public async Task<ServiceResultWithData<IEnumerable<UserSubject>>> GetAllUserSubjectByUserId(int userId)
        {
            var result = new ServiceResultWithData<IEnumerable<UserSubject>>();
            result.Data = await _questionAnswerRepository.GetAllUserSubjectByUserId(userId);
            return result;
        }

        public async Task<ServiceResultWithData<UserQuestionAnswer>> GetRandomQuestionAnswerByDomainId(int domainId)
        {
            var result = new ServiceResultWithData<UserQuestionAnswer>();
            result.Data = await _questionAnswerRepository.GetRandomQuestionAnswerByDomainId(domainId);
            return result;
        }

        public async Task<ServiceResultWithData<UserQuestionAnswer>> GetUserQuestionAnswerById(int id)
        {
            var result = new ServiceResultWithData<UserQuestionAnswer>();
            result.Data = await _questionAnswerRepository.GetUserQuestionAnswerById(id);
            return result;
        }

        public async Task<ServiceResultWithData<bool>> SaveUserQuestionAnswer(UserQuestionAnswer userQuestionAnswer)
        {
            var result = new ServiceResultWithData<bool>();
            result.Data = await _questionAnswerRepository.SaveUserQuestionAnswer(userQuestionAnswer);
            return result;
        }

        public async Task<ServiceResultWithData<bool>> SaveUserQuestionAnswerById(UserQuestionAnswer userQuestionAnswer)
        {
            var result = new ServiceResultWithData<bool>();
            result.Data = await _questionAnswerRepository.SaveUserQuestionAnswerById(userQuestionAnswer);
            return result;
        }

        public async Task<ServiceResultWithData<bool>> SaveUserSetting(UserSetting userSetting)
        {
            var result = new ServiceResultWithData<bool>();
            result.Data = await _questionAnswerRepository.SaveUserSetting(userSetting);
            return result;
        }

        public async Task<ServiceResultWithData<bool>> SaveUserSubject(UserSubject userSubject)
        {
            var result = new ServiceResultWithData<bool>();
            result.Data = await _questionAnswerRepository.SaveUserSubject(userSubject);
            return result;
        }

        public async Task<ServiceResultWithData<bool>> UpdatePrepairdRatioByQuesionAnswerId(int QuesionAnswerId)
        {
            var result = new ServiceResultWithData<bool>();
            result.Data = await _questionAnswerRepository.UpdatePrepairdRatioByQuesionAnswerId(QuesionAnswerId);
            return result;
        }
    }
}
