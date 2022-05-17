using Microsoft.VisualStudio.TestTools.UnitTesting;
using S00214390_OODExam;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RentalProperty_IncreasedRent()
        {
            RentalProperty p1 = new RentalProperty();
            p1.Price = 10.0m;

            decimal expectedResult = 15.0m;

            p1.IncreaseRent(50m);

            Assert.AreEqual(expectedResult, p1.Price);
        }
    }
}
