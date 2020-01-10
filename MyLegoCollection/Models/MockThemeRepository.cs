using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLegoCollection.Models
{
    public class MockThemeRepository : IThemeRepository
    {
        public IEnumerable<Theme> AllThemes =>
            new List<Theme>
            {
                new Theme{ThemeId = 1, Name = "Duplo", Description = "For 50 years, we have been introducing DUPLO® sets to little builders with big imaginations."},
                new Theme{ThemeId = 2, Name = "BOOST", Description = "LEGO® BOOST lets children create models with motors and sensors, and then bring their creations to life through simple, icon-based coding commands. The free LEGO BOOST tablet app includes easy step-by-step building instructions for creating and coding multifunctional models."},
                new Theme{ThemeId = 3, Name = "Harry Potter", Description = "Relive your favorite Harry Potter™ moments with these magical sets."}
            };
    }
}
