using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Entities.Dtos.Title;

namespace HRWorkAnalyse.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TitlesController : ControllerBase
    {
        private readonly ITitleService _titleService;

        public TitlesController(ITitleService titleService)
        {
            _titleService = titleService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _titleService.Get(id);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("department/{id}")]
        public IActionResult GetByDepartment(int id)
        {
            var result = _titleService.GetAll(id);
            if (!result.IsSuccess)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(CreateTitleDto createTitleDto)
        {
            var result = _titleService.Create(createTitleDto);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Created(nameof(Post),result);
        }

        [HttpPut]
        public IActionResult Put(UpdateTitleDto updateTitleDto)
        {
            var result = _titleService.Update(updateTitleDto);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _titleService.Delete(id);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
