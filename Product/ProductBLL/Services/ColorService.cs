using ProductDAL.Repost;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBLL.Services
{
    public class ColorService
    {
        private IColorRepo _colorRepo;

        public ColorService(IColorRepo colorRepo)
        {
            _colorRepo = colorRepo;
        }

        //Add Color
        public void AddColor(Color color)
        {
            _colorRepo.AddColor(color);
        }

        //Get Colors
        public IEnumerable<Color> GetColors()
        {
            return _colorRepo.GetColors();
        }
    }
}
