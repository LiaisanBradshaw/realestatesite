namespace FinalProject.Models
{
    public class FeaturedHouses
    {
        public int Id { get; set; }

        public string Address { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public string ImagePath { get; set; }

        public FeaturedHouses(int _Id, string _Address, string _Description, double _Price, string _ImagePath)
        {
            Id = _Id;
            Address = _Address;
            Description = _Description;
            Price = _Price;
            ImagePath = _ImagePath;
        }
    }
}
