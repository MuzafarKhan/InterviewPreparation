namespace CommonEntities
{
    public class Enums
    {
        public enum SubjectStatus
        {
            NotActive,
            Active,
        }
        public enum DomainStatus
        {
            NotActive,
            Active,
        }
        public enum UserInfoStatus
        {
            NotActive,
            Active,
        }
        public enum QuestionAnswerStatus
        {
            NotActive,
            Active,
        }
        public enum APIGatewayWebClientMethodName
        {
            WeatherForecast,
            CreateToken,
            Register, 

        }

        public enum APIGatewayWebMobileClientMethodName
        {
            WeatherForecast,
            CreateToken,
            Register,
            GetAllUserDomainBySubjectId,
            GetAllUserQuestionAnswerByUserId,
            GetAllUserQuestionAnswerByDomainId,
            GetAllUserSubjectByUserId,
            GetRandomQuestionAnswerByDomainId,
            GetUserQuestionAnswerById,
            SaveUserQuestionAnswerById,
            SaveUserQuestionAnswer,
            SaveUserSetting,
            SaveUserSubject,
            UpdatePrepairdRatioByQuesionAnswerId,

        }
    }
}