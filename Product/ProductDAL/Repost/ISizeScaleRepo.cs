using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAL.Repost
{
    public interface ISizeScaleRepo
    {
        void AddSizeScale(SizeScale sizescale);
        IEnumerable<SizeScale> GetSizeScales();
    }
}
