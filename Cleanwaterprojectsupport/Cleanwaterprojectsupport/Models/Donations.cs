using System;
using System.Collections.Generic;

namespace Cleanwaterprojectsupport.Models
{
    public partial class Donations
    {
        public int Id { get; set; }
        public string DonorName { get; set; }
        public string Amount { get; set; }
        public DateTime Date { get; set; }
        public int? UserProfileId { get; set; }

        public UserProfile UserProfile { get; set; }
    }
}
