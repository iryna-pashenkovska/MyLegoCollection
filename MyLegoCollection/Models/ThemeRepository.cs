using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLegoCollection.Models
{
    public class ThemeRepository : IThemeRepository
    {
        public AppDbContext AppDbContext { get; }
        public ThemeRepository(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }
        public IEnumerable<Theme> AllThemes => AppDbContext.Themes;
    }
}
