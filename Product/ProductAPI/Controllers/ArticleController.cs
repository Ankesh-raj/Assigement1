using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBLL.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private ArticleService _articleServic;

        public ArticleController(ArticleService articleServic)
        {
            _articleServic = articleServic;
        }
        [HttpPost("AddArticle")]
        public IActionResult AddArticle([FromBody] Article article)
        {
            _articleServic.AddArticle(article);
            return Ok("Article created Successfully");
        }

        [HttpGet("GetArticles")]
        public IEnumerable<Article> GetArticles()
        {
            return _articleServic.GetArticles();
        }

    }
}
