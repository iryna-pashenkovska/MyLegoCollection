using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLegoCollection.Migrations
{
    public partial class AddDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "ThemeId", "Description", "Name" },
                values: new object[] { 1, "For 50 years, we have been introducing DUPLO® sets to little builders with big imaginations.", "Duplo" });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "ThemeId", "Description", "Name" },
                values: new object[] { 2, "LEGO® BOOST lets children create models with motors and sensors, and then bring their creations to life through simple, icon-based coding commands. The free LEGO BOOST tablet app includes easy step-by-step building instructions for creating and coding multifunctional models.", "BOOST" });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "ThemeId", "Description", "Name" },
                values: new object[] { 3, "Relive your favorite Harry Potter™ moments with these magical sets.", "Harry Potter" });

            migrationBuilder.InsertData(
                table: "Constructors",
                columns: new[] { "ConstructorId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription", "ThemeId" },
                values: new object[,]
                {
                    { 1, "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10875_alt1", "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10875_alt1", "The LEGO® DUPLO® Cargo Train is now even easier for your toddler to control and interact with in multiple ways. Young children can become the train driver with the Push & Go motor — a gentle push either forwards or backwards sends the train on its way and a firm hold or lift off the tracks will make it stop. Help them place the 5 colored action bricks along the track to sound the horn, turn the lights on and off, pause and refuel, change direction and stop the train wherever they like. With a harbor, boat, café, loading station, 2 cranes, 3 DUPLO figures plus an animal figure and lots of cool track pieces included in this LEGO DUPLO set, preschoolers can enjoy classic, fun train play. Download the optional app to unlock even more play possibilities, including remote-control function and fun activities to complete with your toddler!", "Cargo Train", 119.99m, "Our famous apple pies!", 1 },
                    { 2, "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10874_alt1", "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10874_alt1", "The LEGO® DUPLO® 10874 Steam Train is now even easier for your toddler to control and interact with in multiple ways. Young children can become the train driver with the Push & Go motor — a gentle push either forwards or backwards sends the train on its way and a firm hold or lift off the tracks will make it stop. Help them place the 5 colored action bricks along the track to sound the horn, turn the lights on and off, pause and refuel, change direction and stop the train wherever they like. With a train station, coal tipper, 2 DUPLO figures plus an animal figure and a simple toy train track included in this LEGO DUPLO set, preschoolers can enjoy classic, fun train play. Download the optional app to unlock even more play possibilities, including remote-control function and fun activities to complete with your toddler!", "Steam Train", 59.99m, "Includes train driver and child LEGO® DUPLO® figures, plus a squirrel figure.", 1 },
                    { 3, "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10907_alt1", "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10907_alt1", "Introduce your toddler to a world of animals and environments with the LEGO® DUPLO® 10907 World Animals playset! Take a safari across the African savannah and pretend to photograph lions and giraffes, spot cute woodland creatures as you canoe along a woodland river, build a sandcastle on a tropical beach, go whale watching at the south pole… With a captivating range of toy animals, buildings, vehicles, characters and accessories, this globe-spanning educational toy for toddlers contains endless opportunities to engage and inspire any preschooler.", "World Animals", 99.99m, "Includes 6 LEGO® DUPLO® figures: a traveler, pilot, surfer dad and child, and a canoer dad and child.", 1 },
                    { 4, "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10572_alt1", "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10572_alt1", "The LEGO® DUPLO® All-In-One Box of Fun set has a whole load of DUPLO bricks for fun building and rebuilding for creative play. At its heart is a buildable wagon base with rounded edges and wheels that really turn. This comprehensive set also includes 2 opening window elements, a cute dog and numbered bricks with corresponding decorated bricks to help your child develop their counting skills. There are even extra classic DUPLO bricks for more creative fun. Includes a boy DUPLO figure.", "LEGO® DUPLO® All-in-One-Box-of-Fun", 29.99m, "Let your imagination run wild with this colorful collection of LEGO DUPLO elements in a handy storage case!", 1 },
                    { 5, "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10863_alt1", "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10863_alt1", "Toddlers will have so much fun building their own animal train with the LEGO® DUPLO® 10863 My First Animal Brick Box! Help them sort the bricks into different colors and talk about each iconic animal as you build them together: an elephant with a slide for a trunk, a crocodile with hinged jaws, a lion with opening mouth, a giraffe with a bendy neck and a white bird. The bright and chunky DUPLO bricks are specially designed to be fun and safe for small hands and come in a handy storage box.", "My First Animal Brick Box", 29.99m, "Features 5 buildable animals: an elephant on wheels with a slide for a trunk, a crocodile on wheels with hinged jaws, a lion on wheels with opening mouth, a giraffe on wheels with a bendy neck and a bird.", 1 },
                    { 6, "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10882_alt1", "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10882_alt1", "Open up endless possibilities for your toddler to make a cool track for any new or existing DUPLO train set with these LEGO® DUPLO® 10882 Train Tracks. With level crossings, stops, switches and a combination of curved and straight track pieces there is so much they can do! Preschoolers will also love to place the red action brick on the track and make any compatible DUPLO train (including 10874 Steam Train or 10875 Cargo Train) stop when it reaches it.", "Train Tracks", 19.99m, "Features a straight piece and 10 curved pieces of track, plus 2 stops, 2 switches, a level crossing and a red (stop train) action brick.", 1 },
                    { 7, "https://sh-s7-live-s.legocdn.com/is/image/LEGO/2304_alt1", "https://sh-s7-live-s.legocdn.com/is/image/LEGO/2304_alt1", "Even big imaginations need a place to start--and our baseplates do the job.", "LEGO® DUPLO® Green Baseplate", 14.99m, "Even big imaginations need a place to start--and our baseplates do the job.", 1 },
                    { 8, "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10904_alt1", "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10904_alt1", "Share precious developmental milestones with your toddler and open up a world of imaginative play with the LEGO® DUPLO® Town 10904 Baby Animals toy. This educational toy for toddlers includes a cute baby panda snacking on bamboo, a rare baby white tiger admiring a pretty pink flower, a baby giraffe nibbling the leaves on a tree and an adorable baby elephant who's come to play with his friends. The easy-to-handle animal figures and building bricks develop toddlers' social and emotional understanding and their early construction and fine motor skills.", "Baby Animals", 9.99m, "LEGO® DUPLO® animal set featuring 4 cute baby animal toys: a panda, white tiger, giraffe and elephant.", 1 },
                    { 9, "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10870_alt1", "https://sh-s7-live-s.legocdn.com/is/image/LEGO/10870_alt1", "Little animal lovers will enjoy looking after this selection of LEGO® DUPLO® 10870 Farm Animals. Help them put the chicken in its coop, lead the piglet and calf to the feeding trough and water bucket, and pet the friendly cat. The chicken coop is simple for preschoolers to build and great practice for early construction skills. Includes 4 animal figures.", "Farm Animals", 9.99m, "Includes 4 animal figures: a calf, piglet, chicken and a cat.", 1 },
                    { 10, "http://sh-s7-live-s.legocdn.com/is/image/LEGO/75253_alt1", "http://sh-s7-live-s.legocdn.com/is/image/LEGO/75253_alt1", "Introduce your Star Wars™ fan to a rich LEGO® brick galaxy of lovable droids, exciting missions and coding fun for kids with the LEGO Star Wars BOOST Droid Commander set. This interactive robot toy puts your child in command of 3 app-controlled Star Wars LEGO droids: R2-D2, a Gonk Droid and a Mouse Droid, each with their own personalities and skills. Using the free LEGO BOOST Star Wars app, your young commander builds the droids, inserts the Bluetooth-controlled Move Hub into the one that will solve each mission, and brings it to life using the intuitive drag-and-drop coding environment (visit LEGO.com/devicecheck for a list of compatible devices). Your youngster then constructs tools, weapons, targets, obstacles and lots more as they progress through over 40 exciting missions – they’ll love it! This set makes a great birthday or Christmas gift or just a gift for any occasion. It also helps youngsters develop their critical thinking and creative problem-solving skills, introduces them to basic engineering and robotics, and, just as importantly, lets them play in a rich and expansive galaxy filled with unforgettable icons like Luke Skywalker, X-wings, the Death Star and many more.", "Droid Commander", 199.99m, "Iconic droid models make for a fun building challenge.", 2 },
                    { 11, "https://sh-s7-live-s.legocdn.com/is/image/LEGO/17101_alt1", "https://sh-s7-live-s.legocdn.com/is/image/LEGO/17101_alt1", "Bring your LEGO® creations to life with the new LEGO BOOST Creative Toolbox—a fun and easy way for your 7+ builder to learn the basics of coding, engineering and robotics. Simply choose one of the 5 models available with the BOOST set, download the free, easy-to-use app and you’re ready to go! Choose between Vernie the Robot—a moving, talking robot; the M.T.R.4 (Multi-Tooled Rover 4)—a robust, versatile rover with 4 different tool attachments including a spring-loaded shooter; the Guitar4000—a musical instrument with pitch bend and sound effects; Frankie the Cat—an interactive robot pet that plays, purrs and expresses its mood; or the AutoBuilder—an automated production line that really builds miniature LEGO models! Then bring your creation to life with the app’s intuitive, icon-based coding interface and complete an array of exciting activities designed for each model. With LEGO BOOST, children learn about loops and variables, improve STEM and creative-problem solving skills and develop their imagination as they toggle between guided and open-ended play. The more activities you complete, the more coding blocks you unlock! The LEGO BOOST app is available for selected iOS, Android and Kindle smart devices. Please go to LEGO.com/devicecheck for a list of all compatible devices. The app offers regular updates with new challenges and coding options designed to encourage social play.", "BOOST Creative Toolbox", 159.99m, "Includes a LEGO® Motorized Hub, additional Motor and a Color & Distance Sensor, plus more than 840 LEGO pieces for building and rebuilding any of 5 multifunctional models.", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Constructors",
                keyColumn: "ConstructorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "ThemeId",
                keyValue: 2);
        }
    }
}
