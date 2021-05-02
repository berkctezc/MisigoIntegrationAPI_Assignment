using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailInvoiceController : ControllerBase
    {
        IRetailInvoiceService _retailInvoiceService;
        public RetailInvoiceController(IRetailInvoiceService retailInvoiceService)
        {
            _retailInvoiceService = retailInvoiceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _retailInvoiceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var result = _retailInvoiceService.GetRetailInvoiceDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _retailInvoiceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdetailsbyid")]
        public IActionResult GetDetailsById(int id)
        {
            var result = _retailInvoiceService.GetRetailInvoiceDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(RetailInvoice retailInvoice)
        {
            var result = _retailInvoiceService.Add(retailInvoice);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(RetailInvoice retailInvoice)
        {
            var result = _retailInvoiceService.Delete(retailInvoice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(RetailInvoice retailInvoice)
        {
            var result = _retailInvoiceService.Update(retailInvoice);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}