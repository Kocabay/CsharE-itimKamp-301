using CsharEğitimKampı301.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CsharEğitimKampı301.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<object> GetProductsWithCategory();
    }
}
