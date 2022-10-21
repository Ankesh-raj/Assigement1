using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAL.Repost
{
    public interface IArticleRepo
    {
        void AddArticle(Article article);
        IEnumerable<Article> GetArticles();
        public interface IProductCodeGenerationService
        {
            void GenerateProductCode(Product product, out string productCode);
        }

    }
}
