using Repository.Data;
using Repository.Infrastructure;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class DNARepo : IDNA
    {
        private DNAContext _context;

        public DNARepo(DNAContext context)
        {
            _context = context;
        }
        public void Delete(DNA dna)
        {
            _context.DNAs.Remove(dna);
        }

        public List<DNA> GetAll()
        {
            return _context.DNAs.ToList();
        }

        public DNA GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(DNA dna)
        {
            _context.DNAs.Add(dna);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(DNA dna)
        {
            throw new NotImplementedException();
        }
    }
}
