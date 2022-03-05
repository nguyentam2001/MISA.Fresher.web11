using AplicationCore.Entities;
using AplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Education_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GradesController : BaseEntityController<Grade>
    {
        IGradeService _gradeService;
        
        public GradesController(IGradeService gradeService):base(gradeService)
        {
            _gradeService=gradeService;
        }
    }
}
