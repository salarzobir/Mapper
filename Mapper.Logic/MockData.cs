using Mapper.Entity;
using Mapper.Models.Enums;
using System.Collections.Generic;
using System.Linq;

// 10, 100, 1000, 10000 ve 100000

namespace Mapper.Logic
{
    public static class MockData
    {
        public static List<Customer> Customer10;
        public static List<Customer> Customer100;
        public static List<Customer> Customer1000;
        public static List<Customer> Customer10000;

        public static void CreateMockData()
        {
            Customer10000 = new List<Customer>();
            for (int i = 0; i < 10000; i++)
            {
                Customer10000.Add(new Customer
                {
                    Id = i,
                    Age = 10,
                    Gender = enmGender.Male,
                    IdentityNumber = "45412344578",
                    IsStudent = true,
                    Name = "Ricardo Andrade",
                    Surname = "Quaresma Bernard",
                    Address = new Address
                    {
                        ApartmentNumber = 100,
                        City = "Antalya",
                        Country = "Turkey",
                        IsResidentialArea = true,
                        ZipCode = "7200"
                    }
                });
            }

            Customer10 = Customer10000.Take(10).ToList();
            Customer100 = Customer10000.Take(100).ToList();
            Customer1000 = Customer10000.Take(1000).ToList();
        }
    }
}
