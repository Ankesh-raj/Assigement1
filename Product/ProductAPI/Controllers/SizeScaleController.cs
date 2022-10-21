using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBLL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeScaleController : ControllerBase
    {
        private SizeScaleService _sizeScaleServic;

        public SizeScaleController(SizeScaleService sizeScaleServic)
        {
            _sizeScaleServic = sizeScaleServic;
        }
        [HttpPost("AddSizeScale")]
        public IActionResult AddSizeScale([FromBody] SizeScale sizeScale)
        {
            _sizeScaleServic.AddSizeScale(sizeScale);
            return Ok("SizeScale created Successfully");
        }

        [HttpGet("GetSizeScales")]
        public IEnumerable<SizeScale> GetSizeScales()
        {
            return _sizeScaleServic.GetSizeScales();
        }
    }
}
