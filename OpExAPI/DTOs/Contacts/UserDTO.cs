using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpExAPI.Models;

namespace OpExAPI.DTOs
{
    public class UserDTO
    {
        public String Username { get; set; }
        public String Name { get; set; }
        public String RegisterEmail { get; set; }
        public String Function { get; set; }
        public String Token { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public UserRole Role { get; set; }

        public OrganizationDTO Organization { get; set; }
        public List<UserContactDTO> UserContacts { get; set; }
    }

    public class UserContactDTO
    {
        public String Name { get; set; }
        public String Details { get; set; }
    }
}
