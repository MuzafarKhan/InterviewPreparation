using APIGateway.WebMobile.Client;
using CommonEntities.QuestionAnswer;
using CommonEntities.Result;
using Microsoft.AspNetCore.Mvc;
using MyInterviewPreparation.Settings;
using static CommonEntities.Enums;

namespace MyInterviewPreparation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionAnswerController : ControllerBase
    {
        private readonly IConfiguration config;
        public QuestionAnswerController(IConfiguration _config)
        {
            this.config = _config;
        }

        [HttpGet]
        [Route("GetAllUserDomainBySubjectId")]
        public async Task<IActionResult> GetAllUserDomainBySubjectId(int subjectId)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.GetAllUserDomainBySubjectId);

            result.Data = await APIGatewayWebMobileClient.GetAllUserDomainBySubjectId(
                proxy2.apiUrl,
                new CommonEntities.Base.IntegerReguest { Value = subjectId }
                ) ;
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllUserQuestionAnswerByUserId")]
        public async Task<IActionResult> GetAllUserQuestionAnswerByUserId(int userId)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.GetAllUserQuestionAnswerByUserId);

            result.Data = await APIGatewayWebMobileClient.GetAllUserQuestionAnswerByUserId(
                proxy2.apiUrl,
                new CommonEntities.Base.IntegerReguest { Value = userId }
                );
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllUserQuestionAnswerByDomainId")]
        public async Task<IActionResult> GetAllUserQuestionAnswerByDomainId(int domainId)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.GetAllUserQuestionAnswerByDomainId);

            result.Data = await APIGatewayWebMobileClient.GetAllUserQuestionAnswerByDomainId(
                proxy2.apiUrl,
                new CommonEntities.Base.IntegerReguest { Value = domainId }
                );
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAllUserSubjectByUserId")]
        public async Task<IActionResult> GetAllUserSubjectByUserId(int userId)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.GetAllUserSubjectByUserId);

            result.Data = await APIGatewayWebMobileClient.GetAllUserSubjectByUserId(
                proxy2.apiUrl,
                new CommonEntities.Base.IntegerReguest { Value = userId }
                );
            return Ok(result);
        }

        [HttpGet]
        [Route("GetRandomQuestionAnswerByDomainId")]
        public async Task<IActionResult> GetRandomQuestionAnswerByDomainId(int domainId)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.GetRandomQuestionAnswerByDomainId);

            result.Data = await APIGatewayWebMobileClient.GetRandomQuestionAnswerByDomainId(
                proxy2.apiUrl,
                new CommonEntities.Base.IntegerReguest { Value = domainId }
                );
            return Ok(result);
        }
        [HttpGet]
        [Route("GetUserQuestionAnswerById")]
        public async Task<IActionResult> GetUserQuestionAnswerById(int id)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.GetUserQuestionAnswerById);

            result.Data = await APIGatewayWebMobileClient.GetUserQuestionAnswerById(
                proxy2.apiUrl,
                new CommonEntities.Base.IntegerReguest { Value = id }
                );
            return Ok(result);
        }
        [HttpPost]
        [Route("SaveUserQuestionAnswerById")]
        public async Task<IActionResult> SaveUserQuestionAnswerById(UserQuestionAnswer userQuestionAnswer)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.SaveUserQuestionAnswerById);

            result.Data = await APIGatewayWebMobileClient.SaveUserQuestionAnswerById(
                proxy2.apiUrl,
                userQuestionAnswer
                );
            return Ok(result);
        }

        [HttpPost]
        [Route("SaveUserQuestionAnswer")]
        public async Task<IActionResult> SaveUserQuestionAnswer(UserQuestionAnswer userQuestionAnswer)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.SaveUserQuestionAnswer);

            result.Data = await APIGatewayWebMobileClient.SaveUserQuestionAnswer(
                proxy2.apiUrl,
                userQuestionAnswer
                );
            return Ok(result);
        }

        [HttpPost]
        [Route("SaveUserSetting")]
        public async Task<IActionResult> SaveUserSetting(UserSetting userSetting)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.SaveUserSetting);

            result.Data = await APIGatewayWebMobileClient.SaveUserSetting(
                proxy2.apiUrl,
                userSetting
                );
            return Ok(result);
        }


        [HttpPost]
        [Route("SaveUserSubject")]
        public async Task<IActionResult> SaveUserSubject(UserSubject userSubject)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.SaveUserSubject);

            result.Data = await APIGatewayWebMobileClient.SaveUserSubject(
                proxy2.apiUrl,
                userSubject
                );
            return Ok(result);
        }

        [HttpPost]
        [Route("UpdatePrepairdRatioByQuesionAnswerId")]
        public async Task<IActionResult> UpdatePrepairdRatioByQuesionAnswerId(int quesionAnswerId)
        {
            ServiceResultWithData<string> result = new ServiceResultWithData<string>();

            var proxy2 = new APIGatewayWebMobileProxy(
                _config: this.config,
                aPIGatewayWebMobileClientMethodName:
                APIGatewayWebMobileClientMethodName.UpdatePrepairdRatioByQuesionAnswerId);

            result.Data = await APIGatewayWebMobileClient.UpdatePrepairdRatioByQuesionAnswerId(
                proxy2.apiUrl,
                new CommonEntities.Base.IntegerReguest { Value = quesionAnswerId }
                );
            return Ok(result);
        }
    }
}
