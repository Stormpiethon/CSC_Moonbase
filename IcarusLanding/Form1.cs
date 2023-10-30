using IcarusLanding.Properties;

namespace IcarusLanding
{
    public partial class Form1 : Form
    {
        public Location currentLocation;

        public Form1()
        {
            // Initializing the form and setting the 'overview' object as the reference to the UI update by default
            InitializeComponent();
            currentLocation = overview;
            UpdateUI(currentLocation);
        }

        // Method to update the UI of the main form with the corresponding information of any particular location
        private void UpdateUI(Location location)
        {
            this.DescriptionBox.Text = location.Description;
            this.Navigation.Text = location.Name;
            this.BackgroundImage = location.BackgroundImage;
        }

        // Method to access a location based on its Y and X coordinate value
        public Location GetLocationByCoordinates(int x, int y)
        {
            // Comparison logic to identifiy the current location by the x and y coordinate values
            if (x == overview.X && y == overview.Y) return overview;
            if (x == laboratory.X && y == laboratory.Y) return laboratory;
            if (x == cafeteria.X && y == cafeteria.Y) return cafeteria;
            if (x == AICore.X && y == AICore.Y) return AICore;
            if (x == theatre.X && y == theatre.Y) return theatre;

            // Generic return to the overview object (default) in case an option is selected that has no x and y value associated with it.
            return overview;
        }

        // Instantiate a new object of the Location class for each of the possible locations that the user can visit.
        Location overview = new Location(0, 0, "Overview", "The Icarus Landing Moon Base was founded as a mining colony and travel hub for asteroid mining vessels. " +
            "The colony has roughly 200 people living in it at any given time. 5 children have been born on the moon base, are known " +
            "as Lunartians, and have citizenship in multiple countries at birth.", Resources.Moon_base_image);
        Location laboratory = new Location(0, 1, "Laboratory", "The Icarus Landing research and development laboratories are used to conduct experiments " +
            "that are unique to the Lunar environment's conditions, too dangerous to be done on Earth, or so highly " +
            "classified that the off-planet location serves the security demands of the Corporation.", Resources.Laboratory_MoonBase);
        Location cafeteria = new Location(1, 0, "Cafeteria", "The Icarus Landing cafeteria is equipped with some of the most advanced food processing and " +
            "preperation systems of all humanity. It was deemed appropriate to make sure that the dietary needs of all of " +
            "those who are employed at Icarus Landing were met.", Resources.Cafeteria_MoonBase);
        Location AICore = new Location(0, -1, "AI Core", "The AI core that overseas all of the automated systems of Icarus Landing. Access to " +
            "the core requires the highest security clearance of all the personnel on site. There are rumors about " +
            "sentience that has developed naturally within the core's algorithms.", Resources.AI_Core_MoonBase);
        Location theatre = new Location(-1, 0, "Theatre", "The state of the art theatre at Icarus Landing is on of the primary centers of entertainment " +
            "for staff. The theatre is also used for large scale breifings and announcements from management. Some of the " +
            "staff managed to bring some video game consoles with them to the Lunar base, and sometimes use them in the theatre.", Resources.Movie_Theatre_MoonBase);


        // Button event handling to implement different properties based on the location the user is in
        private void buttonNorth_Click(object sender, EventArgs e)
        {
            // Increment/Decrement the appropriate coordinate value based on the direction of the movement
            int newX = currentLocation.X;
            int newY = currentLocation.Y + 1;
            // Pass the new values into the method that will determine which location to display based on the x and y coordinates
            currentLocation = GetLocationByCoordinates(newX, newY);
            UpdateUI(currentLocation);
        }

        private void buttonEast_Click(object sender, EventArgs e)
        {
            // Increment/Decrement the appropriate coordinate value based on the direction of the movement
            int newX = currentLocation.X + 1;
            int newY = currentLocation.Y;
            // Pass the new values into the method that will determine which location to display based on the x and y coordinates
            currentLocation = GetLocationByCoordinates(newX, newY);
            UpdateUI(currentLocation);
        }

        private void buttonSouth_Click(object sender, EventArgs e)
        {
            // Increment/Decrement the appropriate coordinate value based on the direction of the movement
            int newX = currentLocation.X;
            int newY = currentLocation.Y - 1;
            // Pass the new values into the method that will determine which location to display based on the x and y coordinates
            currentLocation = GetLocationByCoordinates(newX, newY);
            UpdateUI(currentLocation);
        }

        private void buttonWest_Click(object sender, EventArgs e)
        {
            // Increment/Decrement the appropriate coordinate value based on the direction of the movement
            int newX = currentLocation.X - 1;
            int newY = currentLocation.Y;
            // Pass the new values into the method that will determine which location to display based on the x and y coordinates
            currentLocation = GetLocationByCoordinates(newX, newY);
            UpdateUI(currentLocation);
        }
    }

    // Class to define the attributes and methods of a 'Location' datatype
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Image BackgroundImage { get; set; }

        public Location(int c_x, int c_y, string c_name, string c_description, Image c_image)
        {
            X = c_x;
            Y = c_y;
            Name = c_name;
            Description = c_description;
            BackgroundImage = c_image;
        }
    }


}