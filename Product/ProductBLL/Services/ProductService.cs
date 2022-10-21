using ProductDAL;
using ProductDAL.Repost;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBLL.Services
{
    public class ProductService
    {
        IProductRepo _productRepo;
        ProductDbContext _productDbContext;


        public ProductService(IProductRepo productRepo, ProductDbContext  productDbContext)
        {
            _productRepo = productRepo;
            _productDbContext = productDbContext;
        }

        //Add Product
        public void AddProduct(Product product)
        {
          //  _productRepo.AddProduct(product);
          string productCode=string.Empty;
            _productRepo.GenerateProductCode(product, out productCode);
            product.ProductCode = productCode;
            _productDbContext.tblProduct.Add(product);
            _productDbContext.SaveChangesAsync();

        }

        //GetProducts
        public IEnumerable<Product> GetProducts()
        {
            return _productRepo.GetProducts();
        }

    }
}
