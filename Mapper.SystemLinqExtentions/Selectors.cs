using Mapper.DTO;
using Mapper.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Mapper.SystemLinqExtentions
{
    public static class Selectors
    {
        public static IEnumerable<CustomerDto> ToCustomerDto(this IEnumerable<Customer> source)
        {
            return source.Select(l => new CustomerDto
            {
                Age = l.Age,
                Gender = l.Gender,
                Id = l.Id,
                IdentityNumber = l.IdentityNumber,
                IsStudent = l.IsStudent,
                Name = l.Name,
                Surname = l.Surname,
                Address = new AddressDto
                {
                    ApartmentNumber = l.Address.ApartmentNumber,
                    City = l.Address.City,
                    Country = l.Address.Country,
                    IsResidentialArea = l.Address.IsResidentialArea,
                    ZipCode = l.Address.ZipCode
                }
            });
        }
    }
}
