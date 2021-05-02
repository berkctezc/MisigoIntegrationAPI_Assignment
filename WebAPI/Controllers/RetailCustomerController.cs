using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailCustomerController : ControllerBase
    {
        IRetailCustomerService _retailCustomerService;
        public RetailCustomerController(IRetailCustomerService retailCustomerService)
        {
            _retailCustomerService = retailCustomerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _retailCustomerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var result = _retailCustomerService.GetRetailCustomerDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _retailCustomerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdetailsbyid")]
        public IActionResult GetDetailsById(int id)
        {
            var result = _retailCustomerService.GetRetailCustomerDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(RetailCustomer retailCustomer)
        {
            var result = _retailCustomerService.Add(retailCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(RetailCustomer retailCustomer)
        {
            var result = _retailCustomerService.Delete(retailCustomer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(RetailCustomer retailCustomer)
        {
            var result = _retailCustomerService.Update(retailCustomer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}