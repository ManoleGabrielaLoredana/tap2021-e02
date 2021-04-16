using Repository.Models;
using System;
using System.Collections.Generic;

namespace Repository.Data
{
    public class DbSet<T>
    {
        internal void Remove(DNA dna)
        {
            throw new NotImplementedException();
        }

        internal List<DNA> ToList()
        {
            throw new NotImplementedException();
        }

         internal object Where(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        internal void Add(object dns)
        {
            throw new NotImplementedException();
        }
    }
}