using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductDAL.Repost
{
    public class ColorRepo:IColorRepo
    {
        private ProductDbContext _productDbContext;

        public ColorRepo(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public void AddColor(Color color)
        {
            _productDbContext.tblColor.Add(color);
            _productDbContext.SaveChanges();
        }


        IEnumerable<Color> IColorRepo.GetColors()
        {
            return _productDbContext.tblColor.ToList();
        }
    }
}
