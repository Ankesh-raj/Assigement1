using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBLL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private ColorService _colorServic;

        public ColorController(ColorService colorServic)
        {
            _colorServic = colorServic;
        }
        [HttpPost("AddColor")]
        public IActionResult AddColor([FromBody] Color color)
        {
            _colorServic.AddColor(color);
            return Ok("Color created Successfully");
        }

        [HttpGet("GetColors")]
        public IEnumerable<Color> GetColors()
        {
            return _colorServic.GetColors();
        }
    }
}
