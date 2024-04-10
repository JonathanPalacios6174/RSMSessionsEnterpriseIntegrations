namespace RSMEnterpriseIntegrationsAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using RSMEnterpriseIntegrationsAPI.Application.DTOs;
    using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
    using RSMEnterpriseIntegrationsAPI.Domain.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderHeaderController: ControllerBase
    {
        private readonly ISalesOrderHeaderService _salesOrderHeaderService;

        public SalesOrderHeaderController(ISalesOrderHeaderService salesOrderHeaderService)
        {
            _salesOrderHeaderService = salesOrderHeaderService;
        }
        [HttpGet("GetAll")]

        public async Task<IActionResult> Get()
        {
            return Ok(await _salesOrderHeaderService.GetAllSalesOrderHeaders());

        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return Ok(await _salesOrderHeaderService.GetSalesOrderHeaderServiceById(id));
        }

        [HttpDelete("Delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _salesOrderHeaderService.DeleteSalesOrderHeader(id));
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateSalesOrderHeaderDto dto)
        {
            return Ok(await _salesOrderHeaderService.CreateSalesOrderHeader(dto));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateSalesOrderHeaderDto dto)
        {
            return Ok(await _salesOrderHeaderService.UpdateSalesOrderHeader(dto));
        }
    }
}
