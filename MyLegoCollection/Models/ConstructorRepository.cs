using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLegoCollection.Models
{
    public class ConstructorRepository : IConstructorRepository
    {
        private readonly AppDbContext appDbContext;
        public ConstructorRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Constructor> AllContructors
        {
            get
            {
                return appDbContext.Constructors.Include(t => t.Theme);
            }
        }

        public Constructor GetConstructorById(int constructorId)
        {
            return appDbContext.Constructors.FirstOrDefault(c => c.ConstructorId == constructorId);
        }
    }
}
