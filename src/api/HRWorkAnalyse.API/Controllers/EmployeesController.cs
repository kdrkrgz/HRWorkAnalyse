using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Entities.Dtos.Employee;

namespace HRWorkAnalyse.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _employeeService.Get(id);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("title/{id}")]
        public IActionResult GetByTitle(int id)
        {
            var result = _employeeService.GetByTitle(id);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(CreateEmployeeDto createEmployeeDto)
        {
            var result = _employeeService.Create(createEmployeeDto);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Created(nameof(Post), result);
        }

        [HttpPut]
        public IActionResult Put(UpdateEmployeDto updateEmployeDto)
        {
            var result = _employeeService.Update(updateEmployeDto);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _employeeService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
