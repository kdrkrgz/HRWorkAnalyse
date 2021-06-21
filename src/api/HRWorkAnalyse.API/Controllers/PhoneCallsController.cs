using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Entities.Dtos.PhoneCall;

namespace HRWorkAnalyse.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhoneCallsController : ControllerBase
    {
        private readonly IPhoneCallService _phoneCallService;

        public PhoneCallsController(IPhoneCallService phoneCallService)
        {
            _phoneCallService = phoneCallService;
        }

        [HttpGet("{employeeId}")]
        public IActionResult GetByEmployee(int employeeId)
        {
            var result = _phoneCallService.GetAll(employeeId);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("title/{titleId}")]
        public IActionResult GetByTitle(int titleId)
        {
            var result = _phoneCallService.GetByTitle(titleId);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }
        
        [HttpPost]
        public IActionResult Post(CreatePhoneCallDto createPhoneCallDto)
        {
            var result = _phoneCallService.Create(createPhoneCallDto);
            if (!result.IsSuccess)
            {
                return BadRequest();
            }
            return Created(nameof(Post),result);
        }

        [HttpPut]
        public IActionResult Put(UpdatePhoneCallDto updatePhoneCallDto)
        {
            var result = _phoneCallService.Update(updatePhoneCallDto);
            if (!result.IsSuccess)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _phoneCallService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
