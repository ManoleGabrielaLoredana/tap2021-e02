using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class DNAContext:DbContext
    {
        public DNAContext(DbContextOptions<DNAContext> options):base(options){

        }
        public DbSet<DNA> DNAs { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
