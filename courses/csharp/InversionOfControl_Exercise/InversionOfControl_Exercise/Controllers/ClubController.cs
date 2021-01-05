using InversionOfControl_Exercise.Domain.Entities.DTOs;
using InversionOfControl_Exercise.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InversionOfControl_Exercise.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubController : ControllerBase
    {
        private readonly IServiceClub _serviceClub;

        // Using Dependency Injection to by constructor to use the service we created.
        public ClubController(IServiceClub serviceClub) => _serviceClub = serviceClub;

        [HttpGet]
        [Route("Calculate")]
        public IActionResult CalculatePercentage([FromQuery] ClubDTO clubDTO)
        {
            try
            {
                var data = _serviceClub.CalculatePercentage(clubDTO);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
