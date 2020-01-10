using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLegoCollection.Models
{
    public interface IConstructorRepository
    {
        IEnumerable<Constructor> AllContructors { get; }
        Constructor GetConstructorById(int constructorId);
    }
}
