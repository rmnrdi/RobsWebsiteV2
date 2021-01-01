using Microsoft.AspNetCore.Mvc;
using RobsWebsiteV2.CalcModels.Thickness;
using OpticianMathLibrary;

namespace RobsWebsiteV2.Areas.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class ThicknessController : Controller
    {
        [HttpGet("ApproximateSagFormula/{SurfacePower}/{LensDiameter}/{Index}")]
        public ActionResult<ApproximateSagModel> ApproximateSagForumula(ApproximateSagModel sag)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            sag.Result = Thickness.ApproximateSag(sag.SurfacePower, sag.LensDiameter, sag.Index);
            return sag;
        }

        [HttpGet("ApproximateThickness/{SurfacePower}/{LensDiamter}/{Index}/{LensThickness}")]
        public ActionResult<ApproximateThicknessModel> ApproximateThickness(ApproximateThicknessModel thickness)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            thickness.Result = Thickness.ApproximateThickness(thickness.SurfacePower, thickness.LensDiameter, thickness.Index, thickness.LensThickness);
            return thickness;

        }

        [HttpGet("CenterThickness/{SagittalFront}/{SagittalBack}/{EdgeThickness}")]
        public ActionResult<CenterThicknessModel> CenterThickness(CenterThicknessModel thickness)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            thickness.Result = Thickness.CenterThickness(thickness.SagittalFront, thickness.SagittalBack, thickness.EdgeThickness);
            return thickness;
        }

        [HttpGet("EdgeThickness/{SagittalFront}/{SagittalBack}/{CenterThickness}")]
        public ActionResult<EdgeThicknessModel> EdgeThickness(EdgeThicknessModel thickness)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            thickness.Result = Thickness.EdgeThickness(thickness.SagittalFront, thickness.SagittalBack, thickness.CenterThickness);
            return thickness;
        }

        [HttpGet("MinusPrismLensEdgeThickness/{SagittalDepth}/{MimimumCenterThickness}/{PrismBaseThickness}")]
        public ActionResult<MinusPrismLensEdgeThicknessModel> MinusPrismLensEdgeThickness(MinusPrismLensEdgeThicknessModel thickness)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            thickness.Result = Thickness.MinusPrismLensEdgeThickness(thickness.SagittalDepth, thickness.MinimumCenterThickness, thickness.PrismBaseThickness);
            return thickness;
        }

        [HttpGet("PlusPrismLensCenterThickness/{SagittalDepth}/{MinimumEdgeThickness}/{PrismBaseThickness}")]
        public ActionResult<PlusPrismLensCenterThicknessModel> PlusPrismCenterThickness(PlusPrismLensCenterThicknessModel thickness)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            thickness.Result = Thickness.PlusPrismLensCenterThickness(thickness.SagittalDepth, thickness.MinimumEdgeThickness, thickness.PrismBaseThickness);
            return thickness;
        }

        [HttpGet("PlusPrismLensThickestEdge/{PrismBaseThickness}/{MinimumEdgeThickness}")]
        public ActionResult<PlusPrismLensThickestEdgeModel> PlusPrismThickestEdge(PlusPrismLensThickestEdgeModel thickness)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            thickness.Result = Thickness.PlusPrismLensThickestEdge(thickness.PrismBaseThickness, thickness.MinimumEdgeThickness);
            return thickness;
        }

        [HttpGet("PrismPowerFromLensThickness/{ThicknessDifference}/{LensDiameter}/{Index}")]
        public ActionResult<PrismPowerFromThicknessModel> PrismPowerFromThickness(PrismPowerFromThicknessModel thickness)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            thickness.Result = Thickness.PrismPowerFromThickness(thickness.ThicknessDifference, thickness.LensDiameter, thickness.Index);
            return thickness;
        }

        [HttpGet("PrismThickness/{PrismPower}/{LensDiameter}/{Index}")]
        public ActionResult<PrismThicknessModel> PrismThickness(PrismThicknessModel thickness)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            thickness.Result = Thickness.PrismThickness(thickness.PrismPower, thickness.LensDiameter, thickness.Index);
            return thickness;
        }









    }
}
