using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Entities.Dtos.Department;
using Microsoft.AspNetCore.Mvc;

namespace HRWorkAnalyse.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController: ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _departmentService.Get(id);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("company/{id}")]
        public IActionResult GetByCompany(int id)
        {
            var result = _departmentService.GetAll(id);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }
        
        [HttpPost]
        public IActionResult Post(CreateDepartmentDto createDepartmentDto)
        {
            var result = _departmentService.Create(createDepartmentDto);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Created(nameof(Post), result);
        }

        [HttpPut]
        public IActionResult Put(UpdateDepartmentDto updateDepartmentDto)
        {
            var result = _departmentService.Update(updateDepartmentDto);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _departmentService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
