using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductDAL.Repost
{
    public class SizeScaleRepo:ISizeScaleRepo
    {
        private ProductDbContext _productDbContext;

        public SizeScaleRepo(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public void AddSizeScale(SizeScale sizeScale)
        {
            _productDbContext.tblSizeScale.Add(sizeScale);
            _productDbContext.SaveChanges();
        }


        public IEnumerable<SizeScale> GetSizeScales()
        {
            return _productDbContext.tblSizeScale.ToList();
        }
    }
}
