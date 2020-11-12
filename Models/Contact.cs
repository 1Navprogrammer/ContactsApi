using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApi.Models
{
    public class Contact // Mycontacts model class
    {
        [Key] // creating a primar key for db
        public int Id { get; set; }
        // person name
        public string Name { get; set; }
        // person email address
        public string Email { get; set; }
        // person phone number
        public string Phone { get; set; }
        // physical address
        public string Address { get; set; }
    }
}
