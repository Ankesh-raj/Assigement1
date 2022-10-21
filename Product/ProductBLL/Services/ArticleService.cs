using ProductDAL.Repost;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBLL.Services
{
    public class ArticleService
    {
        private IArticleRepo _articleRepo;

        public ArticleService(IArticleRepo articleRepo)
        {
            _articleRepo = articleRepo;
        }

        //Add Article
        public void AddArticle(Article article)
        {
            _articleRepo.AddArticle(article);
        }

        //Get Articles
        public IEnumerable<Article> GetArticles()
        {
            return _articleRepo.GetArticles();
        }
    }
}
