using CsharEğitimKampı301.DataAccessLayer.Abstract;
using CsharEğitimKampı301.DataAccessLayer.Context;
using CsharEğitimKampı301.DataAccessLayer.Repositories;
using CsharEğitimKampı301.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace CsharEğitimKampı301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<object> GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products.Select(x => new  
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice,
                ProductDescription = x.ProductDescription,
                CategoryId = x.Category.CategoryId,
                CategoryName = x.Category.CategoryName,
                 
            }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
