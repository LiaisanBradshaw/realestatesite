namespace FinalProject.Models
{
    public class BuyViewModel
    {
        public string Title = "Houses For Sale";
        public List<Buy> Buy = new List<Buy>()
        {
            new Buy(1, "31 Henlopen Ave, Rehoboth Beach, DE 19971", "3bd, 3ba, 2,042 sqft", 1999000,"~/images/6.jpg", "Built in 1960", "2 Open Parking Spaces", 9814, 0, 550, 700, "Not Included", 11064),
            new Buy(2, "35553 Dry Brook Dr, Rehoboth Beach, DE 19971", "5bd, 3ba, 3,000 sqft", 999000,"~/images/7.jpg","Built in 2004", "2 Attached Garage Spaces", 2772, 0, 158, 201, "Not Included", 3156 ),
            new Buy(3, "69 Sussex St, Rehoboth Beach, DE 19971", "7bd, 6ba, 3,200 sqft", 2199000,"~/images/8.jpg", "Built in 1992", "3 Open Parking Spaces", 10796, 0,605, 770, "Not Included", 12171),
            new Buy(4, "37600 Atlantic St #4, Rehoboth Beach, DE 19971", "4bd, 5ba, 2,800 sqft", 950000,"~/images/9.jpg", "Built in 2005", "2 Attached Garage Spaces", 4664, 0, 261, 333, "Not Included", 5258),
            new Buy(5, "38373 F Benson St UNIT 2, Rehoboth Beach, DE 19971", "2bd, 1ba, - sqft", 559900,"~/images/10.jpg", "Built in 1984", "1 Open Parking Space", 2740, 0,154, 196, "Not Included", 3090),
            new Buy(6, "21049 Laguna Dr, Rehoboth Beach, DE 199711", "3bd, 3ba, 2,788 sqft", 670000,"~/images/11.jpg", "Built in 2006", "2 Attached Garage Spaces", 3213, 0, 184, 235, "Not Included", 3887),
        };
    }
}
