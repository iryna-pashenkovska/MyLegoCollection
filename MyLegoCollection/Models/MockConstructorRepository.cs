using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLegoCollection.Models
{
    public class MockConstructorRepository : IConstructorRepository
    {
        private readonly IThemeRepository themeRepository = new MockThemeRepository();
        public IEnumerable<Constructor> AllContructors =>
            new List<Constructor>
            {
                new Constructor{ConstructorId = 1, Name = "Steam Train", ShortDescription = "The LEGO® DUPLO® 10874 Steam Train is now even easier for your toddler to control and interact with in multiple ways. Young children can become the train driver with the Push & Go motor — a gentle push either forwards or backwards sends the train on its way and a firm hold or lift off the tracks will make it stop. Help them place the 5 colored action bricks along the track to sound the horn, turn the lights on and off, pause and refuel, change direction and stop the train wherever they like. With a train station, coal tipper, 2 DUPLO figures plus an animal figure and a simple toy train track included in this LEGO DUPLO set, preschoolers can enjoy classic, fun train play. Download the optional app to unlock even more play possibilities, including remote-control function and fun activities to complete with your toddler!", Price = 59.99M, Theme = themeRepository.AllThemes.ToList()[0], ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/81BwxLchXqL._AC_SX425_.jpg"}
            };

        public Constructor GetConstructorById(int constructorId)
        {
            return AllContructors.FirstOrDefault(c => c.ConstructorId == constructorId);
        }
    }
}
