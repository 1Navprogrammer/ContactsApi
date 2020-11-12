using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Models
{
    public class ContactsApiContext : DbContext
    {
        public ContactsApiContext (DbContextOptions<ContactsApiContext> options)
            : base(options)
        {
        }

        public DbSet<ContactsApi.Models.Contact> Contact { get; set; }
    }
}
