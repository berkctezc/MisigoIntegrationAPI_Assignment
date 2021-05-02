using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WholesaleOrderController : ControllerBase
    {
        IWholesaleOrderService _wholesaleOrderService;
        public WholesaleOrderController(IWholesaleOrderService wholesaleOrderService)
        {
            _wholesaleOrderService = wholesaleOrderService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _wholesaleOrderService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var result = _wholesaleOrderService.GetWholesaleOrderDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _wholesaleOrderService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdetailsbyid")]
        public IActionResult GetDetailsById(int id)
        {
            var result = _wholesaleOrderService.GetWholesaleOrderDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(WholesaleOrder wholesaleOrder)
        {
            var result = _wholesaleOrderService.Add(wholesaleOrder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(WholesaleOrder wholesaleOrder)
        {
            var result = _wholesaleOrderService.Delete(wholesaleOrder);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(WholesaleOrder wholesaleOrder)
        {
            var result = _wholesaleOrderService.Update(wholesaleOrder);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}