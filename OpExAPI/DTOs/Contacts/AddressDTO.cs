using System;
namespace OpExAPI.DTOs
{
    public class AddressDTO
    {
        public String Street { get; set; }
        public String Number { get; set; }
        public String Extra { get; set; }
        public String PostalCode { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
    }
}
