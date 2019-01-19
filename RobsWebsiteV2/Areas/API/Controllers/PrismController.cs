using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpticianMathLibrary;
using RobsWebsiteV2.Models;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class PrismController : ControllerBase
    {
        /// <summary>
        /// Apical Angle API
        /// </summary>
        /// <param name="prism"></param>
        /// <returns></returns>
        [HttpGet("ApicalAngle/{DegreesDeviation}/{Index}")]
        public ActionResult<PrismModel> ApicalAngle(PrismModel prism)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            prism.Result = Prism.ApicalAngle(prism.DegreesDeviation, prism.Index);

            return prism;
        }
    }
}