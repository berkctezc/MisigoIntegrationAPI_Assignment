using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WholesaleCustomerController : ControllerBase
    {
        IWholesaleCustomerService _wholesaleCustomerService;
        public WholesaleCustomerController(IWholesaleCustomerService wholesaleCustomerService)
        {
            _wholesaleCustomerService = wholesaleCustomerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _wholesaleCustomerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var result = _wholesaleCustomerService.GetWholesaleCustomerDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _wholesaleCustomerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdetailsbyid")]
        public IActionResult GetDetailsById(int id)
        {
            var result = _wholesaleCustomerService.GetWholesaleCustomerDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(WholesaleCustomer wholesaleCustomer)
        {
            var result = _wholesaleCustomerService.Add(wholesaleCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(WholesaleCustomer wholesaleCustomer)
        {
            var result = _wholesaleCustomerService.Delete(wholesaleCustomer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(WholesaleCustomer wholesaleCustomer)
        {
            var result = _wholesaleCustomerService.Update(wholesaleCustomer);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}