using CsharEğitimKampı301.BussinessLayer.Abstract;
using CsharEğitimKampı301.DataAccessLayer.Abstract;
using CsharEğitimKampı301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace CsharEğitimKampı301.BussinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
           _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
          return  _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName != "" && entity.CustomerName.Length >= 3 && entity.CustomerCity != null && entity.CustomerSurname != "" && entity.CustomerName.Length <= 30)
            {
                //ekleme işlemi yap
            _customerDal.Insert(entity); 
            }
            else
            {
                //hata mesajı ver   
            }
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
