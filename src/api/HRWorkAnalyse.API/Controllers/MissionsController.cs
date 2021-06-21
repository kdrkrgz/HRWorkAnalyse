using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Entities.Dtos.Mission;
using Microsoft.AspNetCore.Mvc;

namespace HRWorkAnalyse.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MissionsController: ControllerBase
    {
        private readonly IMissionService _missionService;

        public MissionsController(IMissionService missionService)
        {
            _missionService = missionService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _missionService.Get(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpGet("title/{id}")]
        public IActionResult GetByTitle(int id)
        {
            var result = _missionService.GetAll(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(CreateMissionDto createMissionDto)
        {
            var result = _missionService.Create(createMissionDto);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Created(nameof(Post),result);
        }

        [HttpPut]
        public IActionResult Put(UpdateMissionDto updateMissionDto)
        {
            var result = _missionService.Update(updateMissionDto);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _missionService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
