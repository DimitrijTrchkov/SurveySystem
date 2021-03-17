using Microsoft.AspNetCore.Mvc;
using MidTerm.Services.Abstractions;
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
    }
}
