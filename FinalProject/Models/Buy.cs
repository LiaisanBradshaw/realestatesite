namespace FinalProject.Models
{
    public class Buy
    {
        public int Id { get; set; }

        public string Address { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public string ImagePath { get; set; }

        public string Built { get; set; }

        public string Parking { get; set; }

        public double Interest { get; set; }

        public double mortgageInsurance { get; set; }

        public double propertyTaxes { get; set; }

        public double homeInsurance { get; set; }

        public string Utilities { get; set; }

        public double monthlyEta { get; set; }



        public Buy(int _Id, string _Address, string _Description, double _Price, string _ImagePath, string _Built, string _Parking, double _Interest, double _mortgageInsurance, double _propertyTaxes,double _homeInsurance, string _Utilities, double _monthlyEta)
        {
            Id = _Id;
            Address = _Address;
            Description = _Description;
            Price = _Price;
            ImagePath = _ImagePath;
            Built = _Built;
            Parking = _Parking;
            Interest = _Interest;
            mortgageInsurance = _mortgageInsurance;
            propertyTaxes = _propertyTaxes;
            homeInsurance = _homeInsurance;
            Utilities = _Utilities;
            monthlyEta = _monthlyEta;
        }
    }
}
