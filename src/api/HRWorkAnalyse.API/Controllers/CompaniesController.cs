using HRWorkAnalyse.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRWorkAnalyse.Entities.Dtos.Company;

namespace HRWorkAnalyse.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompaniesController: ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _companyService.GetAll();
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _companyService.Get(id);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(CreateCompanyDto companyDto)
        {
            var result = _companyService.Create(companyDto);
            if (!result.IsSuccess)
            {
                return BadRequest();
            }
            return Created(nameof(Post), result );
        }

        [HttpPut]
        public IActionResult Put(UpdateCompanyDto companyDto)
        {
            var result = _companyService.Update(companyDto);
            if (!result.IsSuccess)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _companyService.Delete(id);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
