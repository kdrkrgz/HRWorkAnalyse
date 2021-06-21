using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Entities.Dtos.Permit;

namespace HRWorkAnalyse.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PermitsController : ControllerBase
    {
        private readonly IPermitService _permitService;

        public PermitsController(IPermitService permitService)
        {
            _permitService = permitService;
        }

        [HttpGet("title/{titleId}")]
        public IActionResult GetByTitle(int titleId)
        {
            var result = _permitService.GetByTitle(titleId);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(CreatePermitDto createPermitDto)
        {
            var result = _permitService.Create(createPermitDto);
            if (!result.IsSuccess)
            {
                return BadRequest();
            }
            return Created(nameof(Post),result);
        }

        [HttpPut]
        public IActionResult Put(UpdatePermitDto updatePermitDto)
        {
            var result = _permitService.Update(updatePermitDto);
            if (!result.IsSuccess)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _permitService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
