using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpticianMathLibrary;
using RobsWebsiteV2.Controllers;
using RobsWebsiteV2.Models;

namespace RobsWebsiteV2.Controllers
{
    //[Produces("application/json")]
    //[Route("api/[Controller]")]
    //public class PowerController : Controller
    //{
    //    [HttpGet("Nominal/{PowerFront}/{PowerBack}")]
    //    public ActionResult<double> NominalPower(PowerModel power)
    //    {
    //        if (!ModelState.IsValid)
    //            return BadRequest(ModelState);

    //        power.Result = Power.NominalPower(power.PowerFront, power.PowerBack);

    //        return power.Result;            
    //    }
    //}
}