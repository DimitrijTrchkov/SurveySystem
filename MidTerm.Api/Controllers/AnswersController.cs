using Microsoft.AspNetCore.Mvc;
using MidTerm.Services.Abstractions;
using MidTerm.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidTerm.Api.Controllers
{
    [ApiController]
    [Route("api/answers")]
    public class AnswersController : ControllerBase
    {
        private readonly IAnswersService _service;

        public AnswersController(IAnswersService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllAnswers()
        {
            var response = await _service.GetAllAnswers();
            return Ok(response);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAnswer([FromRoute] int id)
        {
            var response = await _service.GetAnswers(id);
            return Ok(response);
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateAnswers([FromBody] AnswersDTO request)
        {
            var response = await _service.CreateAnswers(request);
            return Ok(response);
        }
        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> EditAnswer([FromRoute] int id, [FromBody] AnswersDTO request)
        {
            var response = await _service.EditAnswers(id, request);
            return Ok(response);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAnswers([FromRoute] int id)
        {
            var response = await _service.DeleteAnswers(id);
            return Ok(response);
        }
    }
}
