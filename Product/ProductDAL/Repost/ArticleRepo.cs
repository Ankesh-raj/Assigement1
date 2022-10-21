using ProductDAL.Migrations;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductDAL.Repost
{
    public class ArticleRepo:IArticleRepo
    {
        private ProductDbContext _productDbContext;

        public ArticleRepo(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public void AddArticle(Article article)
        {
            _productDbContext.tblArticle.Add(article);
            _productDbContext.SaveChanges();
        }



        IEnumerable<Article> IArticleRepo.GetArticles()
        {
            return _productDbContext.tblArticle.ToList();
        }
    }
}
