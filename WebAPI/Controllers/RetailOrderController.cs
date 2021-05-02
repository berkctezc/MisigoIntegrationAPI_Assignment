using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailOrderController : ControllerBase
    {
        IRetailOrderService _retailOrderService;
        public RetailOrderController(IRetailOrderService retailOrderService)
        {
            _retailOrderService = retailOrderService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _retailOrderService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var result = _retailOrderService.GetRetailOrderDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _retailOrderService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdetailsbyid")]
        public IActionResult GetDetailsById(int id)
        {
            var result = _retailOrderService.GetRetailOrderDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(RetailOrder retailOrder)
        {
            var result = _retailOrderService.Add(retailOrder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(RetailOrder retailOrder)
        {
            var result = _retailOrderService.Delete(retailOrder);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(RetailOrder retailOrder)
        {
            var result = _retailOrderService.Update(retailOrder);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}