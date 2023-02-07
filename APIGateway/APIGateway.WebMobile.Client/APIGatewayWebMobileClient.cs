using CommonEntities;
using CommonEntities.Auth;
using CommonEntities.Base;
using CommonEntities.QuestionAnswer;
using CommonEntities.Result;
using GenericApi;
using static CommonEntities.Enums;
using System.Runtime.InteropServices;

namespace APIGateway.WebMobile.Client
{
    public class APIGatewayWebMobileClient : BaseClient.BaseClient
    {
        public static async Task<string> CreateToken(ApiUrl apiUrl, UserInfo userInfo)
        {
            SetUrls(apiUrl, userInfo);
            return await Api.CallAsync(userInfo);
        }

        public static async Task<string> WeatherForecast(ApiUrl apiUrl, EmptyRequest emptyRequest)
        {
            SetUrls(apiUrl, emptyRequest);
            return await Api.CallAsync(emptyRequest);
        }

        public static async Task<string> Register(ApiUrl apiUrl, UserInfo userInfo)
        {
            SetUrls(apiUrl, userInfo);
            return await Api.CallAsync(userInfo);
        }

        public static async Task<string> GetAllUserDomainBySubjectId(ApiUrl apiUrl, IntegerReguest integerReguest)
        {
            SetUrls(apiUrl, integerReguest);
            return await Api.CallAsync(integerReguest);
        }

        
        
        public static async Task<string> GetAllUserQuestionAnswerByUserId(ApiUrl apiUrl, IntegerReguest integerReguest)
        {
            SetUrls(apiUrl, integerReguest);
            return await Api.CallAsync(integerReguest);
        }

        
        public static async Task<string> GetAllUserQuestionAnswerByDomainId(ApiUrl apiUrl, IntegerReguest integerReguest)
        {
            SetUrls(apiUrl, integerReguest);
            return await Api.CallAsync(integerReguest);
        }

        
        public static async Task<string> GetAllUserSubjectByUserId(ApiUrl apiUrl, IntegerReguest integerReguest)
        {
            SetUrls(apiUrl, integerReguest);
            return await Api.CallAsync(integerReguest);
        }

        
        public static async Task<string> GetRandomQuestionAnswerByDomainId(ApiUrl apiUrl, IntegerReguest integerReguest)
        {
            SetUrls(apiUrl, integerReguest);
            return await Api.CallAsync(integerReguest);
        }
        
        public static async Task<string> GetUserQuestionAnswerById(ApiUrl apiUrl, IntegerReguest integerReguest)
        {
            SetUrls(apiUrl, integerReguest);
            return await Api.CallAsync(integerReguest);
        }
        public static async Task<string> SaveUserQuestionAnswerById(ApiUrl apiUrl, UserQuestionAnswer userQuestionAnswer)
        {
            SetUrls(apiUrl, userQuestionAnswer);
            return await Api.CallAsync(userQuestionAnswer);
        }

        public static async Task<string> SaveUserQuestionAnswer(ApiUrl apiUrl, UserQuestionAnswer userQuestionAnswer)
        {
            SetUrls(apiUrl, userQuestionAnswer);
            return await Api.CallAsync(userQuestionAnswer);
        }

        public static async Task<string> SaveUserSetting(ApiUrl apiUrl, UserSetting userSetting)
        {
            SetUrls(apiUrl, userSetting);
            return await Api.CallAsync(userSetting);
        }


        public static async Task<string> SaveUserSubject(ApiUrl apiUrl, UserSubject userSubject)
        {
            SetUrls(apiUrl, userSubject);
            return await Api.CallAsync(userSubject);
        }

        public static async Task<string> UpdatePrepairdRatioByQuesionAnswerId(ApiUrl apiUrl, IntegerReguest integerReguest)
        {
            SetUrls(apiUrl, integerReguest);
            return await Api.CallAsync(integerReguest);
        }

    }
}