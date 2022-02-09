using CognizantAssessment.Core.DTO;
using CognizantAssessment.Core.IServiceManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognizantAsessment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("GetVehicles")]
        public async Task<IActionResult> GetAllVehicles()
        {
            var result = new List<GetVehiclesDto>();

            try
            {
                var vehicleObj = await _vehicleService.GetAllVehicles();
                if (vehicleObj.Any())
                {
                    result = vehicleObj;
                    return Ok(result);
                }
                else
                {
                    return NotFound(result);
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Ooops! something went wrong");
            }
        }

    }

}
