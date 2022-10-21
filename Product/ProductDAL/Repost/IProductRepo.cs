using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAL.Repost
{
    public interface IProductRepo
    {
        void AddProduct(Product product);
        IEnumerable<Product> GetProducts();
        void GenerateProductCode(Product product, out string productCode);




        //void ShowProduct(Product product);

    }
}
