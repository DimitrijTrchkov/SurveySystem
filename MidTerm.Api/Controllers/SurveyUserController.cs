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
    [Route("api/surveyUsers")]
    public class SurveyUserController : ControllerBase
    {
        private readonly ISurveyUserService _service;

        public SurveyUserController(ISurveyUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllSurveyUsers()
        {
            var response = await _service.GetAllSurveyUsers();
            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetSurveyUser([FromRoute] int id)
        {
            var response = await _service.GetSurveyUser(id);
            return Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateSurveyUser([FromBody] SurveyUserDTO request)
        {
            var response = await _service.CreateSurveyUser(request);
            return Ok(response);
        }
        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> EditSurveyUser([FromRoute] int id, [FromBody] SurveyUserDTO request)
        {
            var response = await _service.EditSurveyUser(id, request);
            return Ok(response);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteSurveyUser([FromRoute] int id)
        {
            var response = await _service.DeleteSurveyUser(id);
            return Ok(response);
        }
    }
}
