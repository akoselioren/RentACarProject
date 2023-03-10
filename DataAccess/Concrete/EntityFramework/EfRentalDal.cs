using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join rent in context.Rentals
                             on car.Id equals rent.CarId
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             join cust in context.Customers
                             on rent.CustomerId equals cust.CustomerId
                             join user in context.Users
                             on cust.UserId equals user.UserId


                             select new RentalDetailDto
                             {
                                 BrandId = brand.Id,
                                 CarId = car.Id,
                                 ColorId = color.Id,
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 ModelName = car.Description,
                                 UserName = user.FirstName + " " + user.LastName,
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate

                             };
                return result.ToList();
            }
        }
    }

}
