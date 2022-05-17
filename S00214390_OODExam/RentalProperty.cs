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
        //Creating the properties
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

        
        //method to increase the rent
        public void IncreaseRent(decimal percentage)
        {
            decimal increasedamount;
            increasedamount = (percentage/100) * Price;
            Price = Price + increasedamount;
        }

        public override string ToString()
        {
            return $"{Location}  {Price:C4}";
        }
    }
    
    //class to create the table
    public class RentalData: DbContext
    {
        public RentalData() : base("S00214390RentalDatabase") { }

        public DbSet<RentalProperty> Rental { get; set; }
    }




}
