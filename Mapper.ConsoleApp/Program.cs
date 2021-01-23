using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Mapper.DTO;
using Mapper.Entity;
using Mapper.Logic;
using Mapper.SystemLinqExtentions;
using System.Collections.Generic;
using System.Linq;

namespace Mapper.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //TestCustomer1 testCustomer1 = new TestCustomer1();
            //testCustomer1.Setup();
            //testCustomer1.AutoMapperLibraryDataCount10();

            BenchmarkRunner.Run<TestCustomer1>();
        }
    }

    [MemoryDiagnoser]
    public class TestCustomer1
    {
        private Core.IMapper _agileMapper;
        private Core.IMapper _expressMapper;
        private Core.IMapper _mapsterMapper;
        private AutoMapper.Mapper _autoMapper;

        [GlobalSetup]
        public void Setup()
        {
            MockData.CreateMockData();
            _agileMapper = new AgileMapperLibrary.Mapper();
            _expressMapper = new ExpressMapperLibrary.Mapper();
            _mapsterMapper = new MapsterLibrary.Mapper();

            AutoMapper.MapperConfiguration config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDto>();
                cfg.CreateMap<Address, AddressDto>();
            });

            _autoMapper = new AutoMapper.Mapper(config);
        }

        #region ManuelMapping
        [Benchmark]
        public void ManuelMappingDataCount10()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            foreach (Customer item in MockData.Customer10)
            {
                customerDtos.Add(new CustomerDto
                {
                    Age = item.Age,
                    Gender = item.Gender,
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    IsStudent = item.IsStudent,
                    Name = item.Name,
                    Surname = item.Surname,
                    Address = new AddressDto
                    {
                        ApartmentNumber = item.Address.ApartmentNumber,
                        City = item.Address.City,
                        Country = item.Address.Country,
                        IsResidentialArea = item.Address.IsResidentialArea,
                        ZipCode = item.Address.ZipCode
                    }
                });
            }
        }

        [Benchmark]
        public void ManuelMappingDataCount100()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            foreach (Customer item in MockData.Customer100)
            {
                customerDtos.Add(new CustomerDto
                {
                    Age = item.Age,
                    Gender = item.Gender,
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    IsStudent = item.IsStudent,
                    Name = item.Name,
                    Surname = item.Surname,
                    Address = new AddressDto
                    {
                        ApartmentNumber = item.Address.ApartmentNumber,
                        City = item.Address.City,
                        Country = item.Address.Country,
                        IsResidentialArea = item.Address.IsResidentialArea,
                        ZipCode = item.Address.ZipCode
                    }
                });
            }
        }

        [Benchmark]
        public void ManuelMappingDataCount1000()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            foreach (Customer item in MockData.Customer1000)
            {
                customerDtos.Add(new CustomerDto
                {
                    Age = item.Age,
                    Gender = item.Gender,
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    IsStudent = item.IsStudent,
                    Name = item.Name,
                    Surname = item.Surname,
                    Address = new AddressDto
                    {
                        ApartmentNumber = item.Address.ApartmentNumber,
                        City = item.Address.City,
                        Country = item.Address.Country,
                        IsResidentialArea = item.Address.IsResidentialArea,
                        ZipCode = item.Address.ZipCode
                    }
                });
            }
        }

        [Benchmark]
        public void ManuelMappingDataCount10000()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            foreach (Customer item in MockData.Customer10000)
            {
                customerDtos.Add(new CustomerDto
                {
                    Age = item.Age,
                    Gender = item.Gender,
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    IsStudent = item.IsStudent,
                    Name = item.Name,
                    Surname = item.Surname,
                    Address = new AddressDto
                    {
                        ApartmentNumber = item.Address.ApartmentNumber,
                        City = item.Address.City,
                        Country = item.Address.Country,
                        IsResidentialArea = item.Address.IsResidentialArea,
                        ZipCode = item.Address.ZipCode
                    }
                });
            }
        }
        #endregion

        #region ManuelLinqMapping
        [Benchmark]
        public void ManuelLinqMappingDataCount10()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();

            customerDtos.AddRange(MockData.Customer10.Select(item =>
                 new CustomerDto
                 {
                     Age = item.Age,
                     Gender = item.Gender,
                     Id = item.Id,
                     IdentityNumber = item.IdentityNumber,
                     IsStudent = item.IsStudent,
                     Name = item.Name,
                     Surname = item.Surname,
                     Address = new AddressDto
                     {
                         ApartmentNumber = item.Address.ApartmentNumber,
                         City = item.Address.City,
                         Country = item.Address.Country,
                         IsResidentialArea = item.Address.IsResidentialArea,
                         ZipCode = item.Address.ZipCode
                     }
                 }));
        }

        [Benchmark]
        public void ManuelLinqMappingDataCount100()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();

            customerDtos.AddRange(MockData.Customer100.Select(item =>
                 new CustomerDto
                 {
                     Age = item.Age,
                     Gender = item.Gender,
                     Id = item.Id,
                     IdentityNumber = item.IdentityNumber,
                     IsStudent = item.IsStudent,
                     Name = item.Name,
                     Surname = item.Surname,
                     Address = new AddressDto
                     {
                         ApartmentNumber = item.Address.ApartmentNumber,
                         City = item.Address.City,
                         Country = item.Address.Country,
                         IsResidentialArea = item.Address.IsResidentialArea,
                         ZipCode = item.Address.ZipCode
                     }
                 }));
        }

        [Benchmark]
        public void ManuelLinqMappingDataCount1000()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();

            customerDtos.AddRange(MockData.Customer1000.Select(item =>
                 new CustomerDto
                 {
                     Age = item.Age,
                     Gender = item.Gender,
                     Id = item.Id,
                     IdentityNumber = item.IdentityNumber,
                     IsStudent = item.IsStudent,
                     Name = item.Name,
                     Surname = item.Surname,
                     Address = new AddressDto
                     {
                         ApartmentNumber = item.Address.ApartmentNumber,
                         City = item.Address.City,
                         Country = item.Address.Country,
                         IsResidentialArea = item.Address.IsResidentialArea,
                         ZipCode = item.Address.ZipCode
                     }
                 }));
        }

        [Benchmark]
        public void ManuelLinqMappingDataCount10000()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();

            customerDtos.AddRange(MockData.Customer10000.Select(item =>
                 new CustomerDto
                 {
                     Age = item.Age,
                     Gender = item.Gender,
                     Id = item.Id,
                     IdentityNumber = item.IdentityNumber,
                     IsStudent = item.IsStudent,
                     Name = item.Name,
                     Surname = item.Surname,
                     Address = new AddressDto
                     {
                         ApartmentNumber = item.Address.ApartmentNumber,
                         City = item.Address.City,
                         Country = item.Address.Country,
                         IsResidentialArea = item.Address.IsResidentialArea,
                         ZipCode = item.Address.ZipCode
                     }
                 }));
        }
        #endregion

        #region SalarManuelLinqMapping
        [Benchmark]
        public void SalarManuelLinqMappingDataCount10()
        {
            List<CustomerDto> customerDtos = MockData.Customer10.ToCustomerDto().ToList();
        }

        [Benchmark]
        public void SalarManuelLinqMappingDataCount100()
        {
            List<CustomerDto> customerDtos = MockData.Customer100.ToCustomerDto().ToList();
        }

        [Benchmark]
        public void SalarManuelLinqMappingDataCount1000()
        {
            List<CustomerDto> customerDtos = MockData.Customer1000.ToCustomerDto().ToList();
        }

        [Benchmark]
        public void SalarManuelLinqMappingDataCount10000()
        {
            List<CustomerDto> customerDtos = MockData.Customer10000.ToCustomerDto().ToList();
        }
        #endregion


        #region AgileMapper
        [Benchmark]
        public void AgileMapperLibraryDataCount10()
        {
            List<CustomerDto> customerDtos = _agileMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
        }

        [Benchmark]
        public void AgileMapperLibraryDataCount100()
        {
            List<CustomerDto> customerDtos = _agileMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
        }

        [Benchmark]
        public void AgileMapperLibraryDataCount1000()
        {
            List<CustomerDto> customerDtos = _agileMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
        }

        [Benchmark]
        public void AgileMapperLibraryDataCount10000()
        {
            List<CustomerDto> customerDtos = _agileMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
        }
        #endregion


        #region AutoMapper
        [Benchmark]
        public void AutoMapperLibraryDataCount10()
        {
            List<CustomerDto> customerDtos = _autoMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
        }

        [Benchmark]
        public void AutoMapperLibraryDataCount100()
        {
            List<CustomerDto> customerDtos = _autoMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
        }

        [Benchmark]
        public void AutoMapperLibraryDataCount1000()
        {
            List<CustomerDto> customerDtos = _autoMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
        }

        [Benchmark]
        public void AutoMapperLibraryDataCount10000()
        {
            List<CustomerDto> customerDtos = _autoMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
        }
        #endregion


        #region ExpressMapper
        [Benchmark]
        public void ExpressMapperLibraryDataCount10()
        {
            List<CustomerDto> customerDtos = _expressMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
        }

        [Benchmark]
        public void ExpressMapperLibraryDataCount100()
        {
            List<CustomerDto> customerDtos = _expressMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
        }

        [Benchmark]
        public void ExpressMapperLibraryDataCount1000()
        {
            List<CustomerDto> customerDtos = _expressMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
        }

        [Benchmark]
        public void ExpressMapperLibraryDataCount10000()
        {
            List<CustomerDto> customerDtos = _expressMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
        }
        #endregion


        #region Mapster
        [Benchmark]
        public void MapsterLibraryDataCount10()
        {
            List<CustomerDto> customerDtos = _mapsterMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
        }

        [Benchmark]
        public void MapsterLibraryDataCount100()
        {
            List<CustomerDto> customerDtos = _mapsterMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
        }

        [Benchmark]
        public void MapsterLibraryDataCount1000()
        {
            List<CustomerDto> customerDtos = _mapsterMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
        }

        [Benchmark]
        public void MapsterLibraryDataCount10000()
        {
            List<CustomerDto> customerDtos = _mapsterMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
        }
        #endregion


        #region TinyMapper
        //[Benchmark]
        //public void TinyMapperLibraryDataCount10()
        //{
        //    IMapper Mapper = new TinyMapperLibrary.Mapper();
        //    Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
        //}

        //[Benchmark]
        //public void TinyMapperLibraryDataCount100()
        //{
        //    IMapper Mapper = new TinyMapperLibrary.Mapper();
        //    Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
        //}

        //[Benchmark]
        //public void TinyMapperLibraryDataCount1000()
        //{
        //    IMapper Mapper = new TinyMapperLibrary.Mapper();
        //    Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
        //}

        //[Benchmark]
        //public void TinyMapperLibraryDataCount10000()
        //{
        //    IMapper Mapper = new TinyMapperLibrary.Mapper();
        //    Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
        //}
        #endregion

    }
}
