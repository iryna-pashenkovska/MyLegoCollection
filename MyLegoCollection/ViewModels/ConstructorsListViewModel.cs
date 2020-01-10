using MyLegoCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLegoCollection.ViewModels
{
    public class ConstructorsListViewModel
    {
        public IEnumerable<Constructor> Constructors { get; set; }
        public string CurrentTheme { get; set; }
    }
}
