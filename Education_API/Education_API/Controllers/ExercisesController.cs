using AplicationCore.Entities;
using AplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Education_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ExercisesController : BaseEntityController<Exercise>
    {
        IExerciseService _exerciseService;
        public ExercisesController(IBaseSevice<Exercise> baseSevice, IExerciseService exerciseService) : base(baseSevice)
        {
            _exerciseService = exerciseService;
        }

        [HttpPost]
        public override IActionResult Post(Exercise exercise)
        {
            return Ok(_exerciseService.Add(exercise));
        }
       

        [HttpGet("filter")]
        public IActionResult Get(int? GradeID, int? TopicID, int? SubjectID, string? QueryText,int PageIndex, int PageSize)
        {
            return Ok(_exerciseService.GetExercisesFilter(GradeID, TopicID, SubjectID, QueryText, PageIndex, PageSize));
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(_exerciseService.GetExerciseStore(id));
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(string id)
        {
            return Ok(_exerciseService.DeleteExerciseByID(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put(Exercise exercise)
        {
           return Ok( _baseService.Update(exercise));
        }
        [HttpPut("status")]
        public IActionResult Put(string id)
        {
            return Ok(_exerciseService.UpdateStatus(id));
        }
    }
}
