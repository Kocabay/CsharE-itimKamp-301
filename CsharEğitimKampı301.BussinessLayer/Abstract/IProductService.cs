using CsharEğitimKampı301.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CsharEğitimKampı301.BussinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
         List<object> TGetProductsWithCategory();
    }   
}
