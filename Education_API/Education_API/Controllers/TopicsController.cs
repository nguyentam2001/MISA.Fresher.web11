using AplicationCore.Entities;
using AplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Education_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TopicsController : BaseEntityController<Topic>
    {
        ITopicService _topicService;
        public TopicsController(IBaseSevice<Topic> baseSevice, ITopicService topicService) : base(baseSevice)
        {
            _topicService = topicService;
        }

           [HttpGet("filter")]

           public IActionResult GetTopicFilter( int GradeID,  string SubjectCode)
        {
            return Ok(_topicService.GetTopicsFilter(GradeID, SubjectCode));
        }
           
    }
}
