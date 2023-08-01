namespace FinalProject.Models
{
    public class FeaturedHousesVModel
    {

        public string Title = "House For You";
        public List<FeaturedHouses> FeaturedHouses = new List<FeaturedHouses>()
        {
            new FeaturedHouses(1, "20920 South Ave, Rehoboth Beach, DE 19971", "5bd, 4ba, 2,400 sqft", 1100000,"~/images/1.jpg"),
            new FeaturedHouses(2, "41312 Gloucester Dr, Rehoboth Beach, DE 19971", "5bd, 3ba, 2,923 sqft", 1099999,"~/images/2.jpg"),
            new FeaturedHouses(3, "20585 Quillen Rd, Rehoboth Beach, DE 19971", "4bd, 4ba, 2,715 sqft", 899900,"~/images/3.jpg"),
            

        };
    }
}
