using CommonEntities.QuestionAnswer;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace QuestionAnswer.API.Repository
{
    public class QuestionAnswerRepository : BaseRepositoryService, IQuestionAnswerRepository
    {
        public QuestionAnswerRepository(IConfiguration config) : base(config)
        {
        }
        public async Task<IEnumerable<UserDomain>> GetAllUserDomainBySubjectId(int subjectId)
        {
            IEnumerable<UserDomain> userDomains;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    userDomains = await connection.QueryAsync<UserDomain>("GetAllUserDomainBySubjectId",
                                    new { subjectId = subjectId },
                                    commandType: CommandType.StoredProcedure);
                }
                return userDomains;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public async Task<IEnumerable<UserQuestionAnswer>> GetAllUserQuestionAnswerByUserId(int userId)
        {
            IEnumerable<UserQuestionAnswer> userQuestionAnswer;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    userQuestionAnswer = await connection.QueryAsync<UserQuestionAnswer>("GetAllUserQuestionAnswerByUserId",
                                    new { userId = userId },
                                    commandType: CommandType.StoredProcedure);
                }
                return userQuestionAnswer;
            }
            catch (Exception ex)
            {

            }
            return null;
        }
        public async Task<IEnumerable<UserQuestionAnswer>> GetAllUserQuestionAnswerByDomainId(int domainId)
        {
            IEnumerable<UserQuestionAnswer> userQuestionAnswer;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    userQuestionAnswer = await connection.QueryAsync<UserQuestionAnswer>("GetAllUserQuestionAnswerByDomainId",
                                    new { domainId = domainId },
                                    commandType: CommandType.StoredProcedure);
                }
                return userQuestionAnswer;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public async Task<IEnumerable<UserSubject>> GetAllUserSubjectByUserId(int userId)
        {
            IEnumerable<UserSubject> userSubject;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    userSubject = await connection.QueryAsync<UserSubject>("GetAllUserSubjectByUserId",
                                    new { userId = userId },
                                    commandType: CommandType.StoredProcedure);
                }
                return userSubject;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public async Task<UserQuestionAnswer> GetRandomQuestionAnswerByDomainId(int domainId)
        {
            UserQuestionAnswer userQuestionAnswer;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    userQuestionAnswer = await connection.QueryFirstOrDefaultAsync<UserQuestionAnswer>("GetRandomQuestionAnswerByDomainId",
                                    new { domainId = domainId },
                                    commandType: CommandType.StoredProcedure);
                }
                return userQuestionAnswer;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public async Task<UserQuestionAnswer> GetUserQuestionAnswerById(int id)
        {
            UserQuestionAnswer userQuestionAnswer;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    userQuestionAnswer = await connection.QueryFirstOrDefaultAsync<UserQuestionAnswer>("GetUserQuestionAnswerById",
                                    new { id = id },
                                    commandType: CommandType.StoredProcedure);
                }
                return userQuestionAnswer;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public async Task<bool> SaveUserQuestionAnswerById(UserQuestionAnswer userQuestionAnswer)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await connection.QueryAsync("SaveUserQuestionAnswerById",
                                    new
                                    {
                                        id = userQuestionAnswer.id,
                                        question = userQuestionAnswer.Question,
                                        answer = userQuestionAnswer.Answer,
                                        useFullLink = userQuestionAnswer.UseFullLink,
                                    },
                                    commandType: CommandType.StoredProcedure);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public async Task<bool> SaveUserQuestionAnswer(UserQuestionAnswer userQuestionAnswer)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await connection.QueryAsync("SaveUserQuestionAnswer",
                                    new
                                    {
                                        Question = userQuestionAnswer.Question,
                                        Answer = userQuestionAnswer.Answer,
                                        DomainId = userQuestionAnswer.DomainId,
                                        UserId = userQuestionAnswer.UserId,
                                        QuestionAnswerStatus = userQuestionAnswer.QuestionAnswerStatus,
                                        UseFullLink = userQuestionAnswer.UseFullLink,
                                        PrepairedRatio = userQuestionAnswer.PrepairedRatio
                                    },
                                    commandType: CommandType.StoredProcedure);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public async Task<bool> SaveUserSubject(UserSubject userSubject)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await connection.QueryAsync("SaveUserSubject",
                                    new
                                    {
                                        Id = userSubject.Id,
                                        Name = userSubject.Name,
                                        SubjectStatus = userSubject.SubjectStatus,
                                        UserId = userSubject.UserId,
                                    },
                                    commandType: CommandType.StoredProcedure);
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public async Task<bool> SaveUserSetting(UserSetting userSetting)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await connection.QueryFirstOrDefaultAsync<UserSetting>("SaveUserSetting",
                                    new
                                    {
                                        id = userSetting.Id,
                                        subjectId = userSetting.SubjectId,
                                        userid = userSetting.UserId
                                    },
                                    commandType: CommandType.StoredProcedure);
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public async Task<bool> UpdatePrepairdRatioByQuesionAnswerId(int quesionAnswerId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await connection.QueryAsync("UpdatePrepairdRatioByQuesionAnswerId",
                                    new { quesionAnswerId = quesionAnswerId },
                                    commandType: CommandType.StoredProcedure);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
