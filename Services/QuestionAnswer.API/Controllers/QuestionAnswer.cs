using CommonEntities.Auth;
using CommonEntities.Base;
using CommonEntities.QuestionAnswer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionAnswer.API.Service;

namespace QuestionAnswer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionAnswerController : ControllerBase
    {
        public IQuestionAnswerService _questionAnswerService;
        public QuestionAnswerController(IQuestionAnswerService questionAnswerService)
        {
            _questionAnswerService = questionAnswerService;
        }

        [HttpPost]
        [Route("GetAllUserDomainBySubjectId")]
        public async Task<IActionResult> GetAllUserDomainBySubjectId(IntegerReguest integerReguest)
        {
            var responseData = await _questionAnswerService.GetAllUserDomainBySubjectId(integerReguest.Value);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new UserDomainControllerReponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }

        [HttpPost]
        [Route("GetAllUserQuestionAnswerByUserId")]
        public async Task<IActionResult> GetAllUserQuestionAnswerByUserId(IntegerReguest integerReguest)
        {
            var responseData = await _questionAnswerService.GetAllUserQuestionAnswerByUserId(integerReguest.Value);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new UserQuestionAnswerListControllerResponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }

        [HttpPost]
        [Route("GetAllUserQuestionAnswerByDomainId")]
        public async Task<IActionResult> GetAllUserQuestionAnswerByDomainId(IntegerReguest integerReguest)
        {
            var responseData = await _questionAnswerService.GetAllUserQuestionAnswerByDomainId(integerReguest.Value);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new UserQuestionAnswerListControllerResponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }

        [HttpPost]
        [Route("GetAllUserSubjectByUserId")]
        public async Task<IActionResult> GetAllUserSubjectByUserId(IntegerReguest integerReguest)
        {
            var responseData = await _questionAnswerService.GetAllUserSubjectByUserId(integerReguest.Value);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new UserSubjectControllerResponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }

        [HttpPost]
        [Route("GetRandomQuestionAnswerByDomainId")]
        public async Task<IActionResult> GetRandomQuestionAnswerByDomainId(IntegerReguest integerReguest)
        {
            var responseData = await _questionAnswerService.GetRandomQuestionAnswerByDomainId(integerReguest.Value);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new UserQuestionAnswerControllerResponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }
        [HttpPost]
        [Route("GetUserQuestionAnswerById")]
        public async Task<IActionResult> GetUserQuestionAnswerById(IntegerReguest integerReguest)
        {
            var responseData = await _questionAnswerService.GetUserQuestionAnswerById(integerReguest.Value);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new UserQuestionAnswerControllerResponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }
        [HttpPost]
        [Route("SaveUserQuestionAnswerById")]
        public async Task<IActionResult> SaveUserQuestionAnswerById(UserQuestionAnswer userQuestionAnswer)
        {
            var responseData = await _questionAnswerService.SaveUserQuestionAnswerById(userQuestionAnswer);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new BoolControllerResponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }

        [HttpPost]
        [Route("SaveUserQuestionAnswer")]
        public async Task<IActionResult> SaveUserQuestionAnswer(UserQuestionAnswer userQuestionAnswer)
        {
            var responseData = await _questionAnswerService.SaveUserQuestionAnswer(userQuestionAnswer);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new BoolControllerResponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }

        [HttpPost]
        [Route("SaveUserSetting")]
        public async Task<IActionResult> SaveUserSetting(UserSetting userSetting)
        {
            var responseData = await _questionAnswerService.SaveUserSetting(userSetting);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new BoolControllerResponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }


        [HttpPost]
        [Route("SaveUserSubject")]
        public async Task<IActionResult> SaveUserSubject(UserSubject userSubject)
        {
            var responseData = await _questionAnswerService.SaveUserSubject(userSubject);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new BoolControllerResponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }

        [HttpPost]
        [Route("UpdatePrepairdRatioByQuesionAnswerId")]
        public async Task<IActionResult> UpdatePrepairdRatioByQuesionAnswerId(IntegerReguest integerReguest)
        {
            var responseData = await _questionAnswerService.UpdatePrepairdRatioByQuesionAnswerId(integerReguest.Value);

            if (responseData.IsError())
            {
                return BadRequest();
            }

            var response = new BoolControllerResponse()
            {
                Payload = responseData.Data
            };

            return Ok(response);
        }
    }
}
