using System;
namespace OpExAPI.DTOs
{
    public class OrganizationDTO
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public AddressDTO Address { get; set; }
    }
}
