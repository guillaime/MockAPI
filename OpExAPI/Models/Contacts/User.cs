using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpExAPI.Models
{
    public class User
    {
        public String username, name, registerEmail, organization, function;

        [JsonIgnoreAttribute]
        public String hashPassword;

        public IEnumerable<UserContact> userContacts;

        public User(String username, String hashPassword, String name, String registerEmail, String organization, String function, IEnumerable<UserContact> userContacts)
        {
            this.username = username;
            this.hashPassword = hashPassword;
            this.name = name;
            this.registerEmail = registerEmail;
            this.organization = organization;
            this.function = function;
            this.userContacts = userContacts;
        }
    }

    public class UserContact
    {
        public String name, details;

        public UserContact(String name, String details)
        {
            this.name = name;
            this.details = details;
        }
    }
}
