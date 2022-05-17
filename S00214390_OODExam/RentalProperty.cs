using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00214390_OODExam
{
    public class RentalProperty
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public RentalType TypeOfRental { get; set; }
        public enum RentalType
        {
            House,
            Flat,
            Share,

        }
        public decimal Price { get; set; }
        public string Description { get; set; }


        public void IncreaseRent(decimal percentage)
        {
            decimal increasedamount;
            increasedamount = (percentage/100) * Price;
            Price = Price + increasedamount;
        }
    }
    
    public class RentalData: DbContext
    {
        public RentalData() : base("S00214390RentalDatabase") { }

        public DbSet<RentalProperty> Rental { get; set; }
    }




}
