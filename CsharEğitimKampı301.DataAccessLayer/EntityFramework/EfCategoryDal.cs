using CsharEğitimKampı301.DataAccessLayer.Abstract;
using CsharEğitimKampı301.DataAccessLayer.Repositories;
using CsharEğitimKampı301.EntityLayer.Concrete;

namespace CsharEğitimKampı301.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
