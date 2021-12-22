using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Fresher.web11.Models;

namespace MISA.Fresher.web11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //Phương thức get Api
        [HttpGet]
        public string GetName()
        {
            return "Nguyễn Tâm";

        }
        //truyền đối số qua router bằng phương thức get
        //Dùng để lấy khách hàng theo id
        [HttpGet("{name}")]
        public string GetName2(string name)
        {
            return name;
        }
        //Truyền bằng query thường dùng để tìm kiếm, lọc dữ liệu
        //api/person/byName?firstName=a&lastName=b
        [HttpGet("search")]
        public string GetCustomer(string firstName, string? lastName, int? age)
        {
           return $"{firstName}:{lastName}:{age}";
        }


        // lấy dữ liệu qua post
        /* [HttpPost()]
         public string GetNamePost(string name)
         {

             return name;
         }*/
        //pst qua body thường để dùng thêm mới dữ liệu
        /* [HttpPost()]
         public string PostCustomerBody([FromBody]string name)
         {

             return name;
         }*/
        //chuyền kiểu dữ liệu customer
        [HttpPost()]
        public Customer PostCustomerBody(Customer customer)
        {

            return customer;
        }

    }
}
