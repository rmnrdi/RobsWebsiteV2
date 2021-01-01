using Microsoft.AspNetCore.Mvc;
using RobsWebsiteV2.CalcModels.ToolSelector;
using OpticianMathLibrary;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class ToolSelectorController : Controller
    {
        [HttpGet("RefractivePower/{ToolPower}/{Index}")]
        public ActionResult<RefractivePowerModel> RefractivePower(RefractivePowerModel power)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            power.Result = Tools.RefractivePower(power.ToolPower, power.Index);
            return power;
        }

        [HttpGet("ToolSelector/{RefractivePower}/{Index}")]
        public ActionResult<ToolSelectorModel> ToolSelector(ToolSelectorModel tool)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            tool.Result = Tools.ToolSelector(tool.RefractivePower, tool.Index);
            return tool;
        }
    }
}
