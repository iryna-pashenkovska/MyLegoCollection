using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLegoCollection.Models
{
    public interface IThemeRepository
    {
        IEnumerable<Theme> AllThemes { get; }
    }
}
