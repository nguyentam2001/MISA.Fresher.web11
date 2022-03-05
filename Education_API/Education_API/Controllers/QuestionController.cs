using AplicationCore.Entities;
using AplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Education_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class QuestionController : BaseEntityController<Question>
    {
        IQuestionService _questionService;
        public QuestionController(IBaseSevice<Question> baseSevice, IQuestionService questionService) : base(baseSevice)
        {
            _questionService = questionService;
        }

        [HttpPut]
        public IActionResult Put(Question question)
        {
           // _questionService.UpdateQuestion(question)
            return Ok(_questionService.UpdateQuestion(question));
        }
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            return Ok(_questionService.Delete(id));
        }
    }
}
