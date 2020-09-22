using System;
using System.Collections.Generic;

namespace Cleanwaterprojectsupport.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            Donations = new HashSet<Donations>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string CreditCard { get; set; }
        public string PhoneNumber { get; set; }
        public string Useraccountid { get; set; }

        public ICollection<Donations> Donations { get; set; }
    }
}
