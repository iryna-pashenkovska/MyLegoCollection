using System.Collections.Generic;

namespace MyLegoCollection.Models
{
    public class Theme
    {
        public int ThemeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Constructor> Constructors { get; set; }
    }
}