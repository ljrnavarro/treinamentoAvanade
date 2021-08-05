using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Services.EmployeeRole;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Api.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1", Deprecated = false)]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class EmployeeRoleController : ControllerBase
    {
        private readonly IEmployeeRoleAppService _employeeRoleAppService;

        public EmployeeRoleController(IEmployeeRoleAppService employeeRoleAppService)
        {
            _employeeRoleAppService = employeeRoleAppService;
        }
   
        [HttpPost(Name = "EmployeeRole")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(EmployeeRoleDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateEmployeeRole([FromBody] EmployeeRoleDto employeeRoleDto)
        {
            var item = await _employeeRoleAppService.AddEmployeeRoleAsync(employeeRoleDto);

            if (!item.validationResult.IsValid)
            {
                BadRequest(string.Join('\n', item.validationResult.Errors));
            }
            return Ok(item);
        }

        [HttpGet(Name = "EmployeeRoleGet")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(List<EmployeeRoleDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllEmployeeRole()
        {
            var itens = await _employeeRoleAppService.GetAllEmployeeRoleAsync();

            return Ok(itens);
        }


        [HttpGet(template: "{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(List<EmployeeRoleDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(string id)
        {
            var item = await _employeeRoleAppService.GetByIdAsync(id);

            return Ok(item);
        }

        [HttpDelete(template: "{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(List<EmployeeRoleDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteById(string id)
        {
            var item = await _employeeRoleAppService.DeleteByIdAsync(id);

            return Ok(item);
        }

        [HttpPut(Name = "EmployeeRoleUpdate")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(List<EmployeeRoleDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update([FromBody] EmployeeRoleDto employeeRoleDto)
        {
            var item = await _employeeRoleAppService.UpdateAsync(employeeRoleDto);

            return Ok(item);
        }
    }
}
