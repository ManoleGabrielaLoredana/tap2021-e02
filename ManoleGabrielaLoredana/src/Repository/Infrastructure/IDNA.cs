using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Infrastructure
{
    public interface IDNA
    {
        List<DNA> GetAll();
        DNA GetById(Guid Id);
        void Insert(DNA dna);
        void Update(DNA dna);
        void Delete(DNA dna);
        void Save();
    }
}
