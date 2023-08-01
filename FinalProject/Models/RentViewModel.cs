namespace FinalProject.Models
{
    public class RentViewModel
    {
        public string Title = "Rental Listings";
        public List<Rent> rent = new List<Rent>()
        {
            new Rent(1, "29988 W Barrier Reef Blvd, Lewes, DE 19958", "3bd, 2ba, 1,930 sqft", 2695,"~/images/21.jpg", true, true, true, true, "Unknown"),
            new Rent(2, "28751 Valley View Ln, Lewes, DE 19958", "3bd, 2ba, 1,810 sqft", 2500,"~/images/22.jpg", false, false, false, false, "2 Parking Spaces"),
            new Rent(3, "33740 Skiff Aly #3103, Lewes, DE 19958", "2bd, 2ba, 1,290 sqft", 2100,"~/images/23.jpg", false, true, false, false, "Off-street"),
            new Rent(4, "16970 Bristol Rd, Lewes, DE 19958", "3bd, 2ba, 1,710 sqft", 2900,"~/images/24.jpg", true, false, false, false, "Contact to learn"),
            new Rent(5, "38211 Comegys Ct, Lewes, DE 19958", "4bd, 4ba, 4,500 sqft", 3900,"~/images/25.jpg", true, true, false, true, "Garage-Attached"),
            new Rent(6, "36011 Condo Dr #A102, Rehoboth Beach, DE 19971", "2bd, 2ba, 980 sqft", 1800,"~/images/26.jpg", true, false, false, false, "Contact to learn"),
            new Rent(7, "18037 Highwood Dr, Rehoboth Beach, DE 19971", "4bd, 4ba, -- sqft", 4500,"~/images/27.jpg", true, true, false, true, "2 Car garage"),
            new Rent(8, "17565 Shady Rd, Lewes, DE 19958", "3bd, 2a, 1,900 sqft", 2000,"~/images/28.jpg", false, false, false, false, "Off-street/Garage"),



        };
    }
}
