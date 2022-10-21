﻿using Microsoft.EntityFrameworkCore;
using ProductDAL.Migrations;
using System;
using System.Collections.Generic;
using System.Text;
using ProductEntity;
using System.Linq;

namespace ProductDAL.Repost
{
    public class ProductRepo:IProductRepo
    {
        private ProductDbContext _productDbContext;

        public ProductRepo(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public void AddProduct(ProductEntity.Product product)
        {
            _productDbContext.tblProduct.Add(product);
            _productDbContext.SaveChanges();
        }

        public IEnumerable<ProductEntity.Product> GetProducts()
        {
            return _productDbContext.tblProduct.ToList();
        }

        private static int channel1Code = 001;
        private static long channel3Code = 10000000;
        private static Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public void GenerateProductCode(Product product, out string code)
        {
            code = ComputeCode(product);

            while (CheckIfUnique(code))
            {
                code = ComputeCode(product);
            }
        }

        private string ComputeCode(Product product)
        {
            string code;

            switch (product.ChannelId)
            {
                //productYear + three digit integer code(2022001)
                case 1:
                    code = $"{product.ProductYear}00{channel1Code}";
                    channel1Code++;
                    break;
                // 6 digit unique alphanumeric code 
                case 2:
                    code = AlphanumericGenerator(6);
                    break;
                //integer which increases sequencially
                case 3:
                    code = $"{channel3Code}";
                    channel3Code++;
                    break;

                default: code = "Invalid Code"; break;
            }
            return code;
        }
        private bool CheckIfUnique(string code)
        {
            return _productDbContext.tblProduct.Any(x => x.ProductCode == code);
        }
        private string AlphanumericGenerator(int length)
        {
            var result = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return result;
        }

    }
}
