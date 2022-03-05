using AplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Education_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseEntityController<TEntity> : ControllerBase
    {
        protected IBaseSevice<TEntity> _baseService;
        public BaseEntityController(IBaseSevice<TEntity> baseSevice)
        {
            _baseService = baseSevice;
        }
        /// <summary>
        /// Lấy danh sách entities ở controler base
        /// </summary>
        /// <returns></returns>
        [HttpGet]
         public IActionResult Get()
        {
            var entities = _baseService.GetTEntities();
            return Ok(entities);
        }
        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        virtual public IActionResult Post(TEntity entity)
        {
            return Ok(_baseService.Add(entity));
        }
     
    }
}
