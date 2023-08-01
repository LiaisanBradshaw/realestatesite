namespace FinalProject.Models
{
    public class Rent
    {
        public int Id { get; set; }

        public string Address { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public string ImagePath { get; set; } 
        
        public bool IsPet { get; set; }

        public bool Pool { get; set; }

        public bool Playground { get; set; }

        public bool Gym { get; set; }

        public string Parking { get; set; }

        public Rent(int _Id, string _Address, string _Description, double _Price, string _ImagePath, bool _IsPet, bool _Pool, bool _Playground, bool _Gym, string _Parking)
        {
            Id = _Id;
            Address = _Address;
            Description = _Description;
            Price = _Price;
            ImagePath = _ImagePath;
            IsPet = _IsPet;
            Parking = _Parking;
            Pool = _Pool;
            Playground = _Playground;
            Gym = _Gym;
        }
    }
}
