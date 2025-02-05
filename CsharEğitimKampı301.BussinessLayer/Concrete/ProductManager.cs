﻿using CsharEğitimKampı301.BussinessLayer.Abstract;
using CsharEğitimKampı301.DataAccessLayer.Abstract;
using CsharEğitimKampı301.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CsharEğitimKampı301.BussinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product entity)
        {
            
        _productDal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<object> TGetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory();
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
             _productDal.Update(entity);
        }
    }
}
