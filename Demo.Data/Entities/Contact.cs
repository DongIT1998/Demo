using Demo.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Massage { get; set; }
        public Status Status { get; set; }
    }
}
