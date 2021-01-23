using Mapper.Models.Enums;

namespace Mapper.DTO
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public int Age { get; set; }
        public enmGender Gender { get; set; }
        public bool IsStudent { get; set; }
        public AddressDto Address { get; set; }
    }
}
