using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WholesaleInvoiceController : ControllerBase
    {
        IWholesaleInvoiceService _wholesaleInvoiceService;
        public WholesaleInvoiceController(IWholesaleInvoiceService wholesaleInvoiceService)
        {
            _wholesaleInvoiceService = wholesaleInvoiceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _wholesaleInvoiceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var result = _wholesaleInvoiceService.GetWholesaleInvoiceDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _wholesaleInvoiceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdetailsbyid")]
        public IActionResult GetDetailsById(int id)
        {
            var result = _wholesaleInvoiceService.GetWholesaleInvoiceDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(WholesaleInvoice wholesaleInvoice)
        {
            var result = _wholesaleInvoiceService.Add(wholesaleInvoice);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(WholesaleInvoice wholesaleInvoice)
        {
            var result = _wholesaleInvoiceService.Delete(wholesaleInvoice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(WholesaleInvoice wholesaleInvoice)
        {
            var result = _wholesaleInvoiceService.Update(wholesaleInvoice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}