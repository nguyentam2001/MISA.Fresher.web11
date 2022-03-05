using AplicationCore.Entities;
using AplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Education_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SubjectsController : BaseEntityController<Subject>
    {
        public SubjectsController(IBaseSevice<Subject> baseSevice) : base(baseSevice)
        {
        }
    }
}
