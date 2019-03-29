using System;
using System.Collections.Generic;

namespace PartyHive.Models
{
    public partial class Host
    {
        public Host()
        {
            Party = new HashSet<Party>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public ICollection<Party> Party { get; set; }
    }
}
