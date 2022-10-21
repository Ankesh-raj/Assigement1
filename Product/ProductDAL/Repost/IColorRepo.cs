using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDAL.Repost
{
    public interface IColorRepo
    {
        void AddColor(Color color);
        IEnumerable<Color> GetColors();
    }
}
