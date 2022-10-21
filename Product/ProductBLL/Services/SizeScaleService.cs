using ProductDAL.Repost;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBLL.Services
{
    public class SizeScaleService
    {
        private ISizeScaleRepo _sizeScaleRepo;

        public SizeScaleService(ISizeScaleRepo sizeScaleRepo)
        {
            _sizeScaleRepo = sizeScaleRepo;
        }

        //Add SizeScale
        public void AddSizeScale(SizeScale sizeScaleRepo)
        {
            _sizeScaleRepo.AddSizeScale(sizeScaleRepo);
        }

        //Get SizeScales
        public IEnumerable<SizeScale> GetSizeScales()
        {
            return _sizeScaleRepo.GetSizeScales();
        }
    }
}
