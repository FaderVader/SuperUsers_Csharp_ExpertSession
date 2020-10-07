using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePerson
{
    class MyContext : DbContext
    {        
        public DbSet<Person> Personer { get; set; }
    }
    
}
