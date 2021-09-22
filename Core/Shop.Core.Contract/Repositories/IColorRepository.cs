using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface IColorRepository
    {
        
        List<Color> GetAll();
        Color GetByColorId(int colorid);
        void AddColor(Color color);
        void UpdateColor(Color color);
    }
}
