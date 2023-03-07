using CarLibraryClass;
using System;
using System.Runtime.ConstrainedExecution;
using Xunit;

namespace TestingCarLibraryClass
{
    public class TestingCarLibrary
    {
        //Assert bliver brugt her fordi klassen som er blevet brugt, er Xunit testing.
        //Bliver brught i stedet for throw new exception [expectedexception(typeof(exception)]

        [Fact]
        public void TestingGetID()
        {
            Car MyCar = new Car();
            MyCar.Id = 43;
            Assert.Equal(43, MyCar.Id);
        }

        [Fact]
        public void TestingModelStringBelow4()
        {
            Car MyCar = new Car();
            Assert.Throws<Exception>(() => MyCar.Model = "123");
        }

        [Fact]
        public void TestPriceBelowZero()
        {
            Car MyCar = new Car();
            Assert.Throws<Exception>(() => MyCar.Price = -1);
        }

        [Fact]
        public void TestingLicensePlateLessThan2()
        {
            Car MyCar = new Car();
            Assert.Throws<Exception>(() => MyCar.LicensePlate = "a");
        }

        [Fact]
        public void TestingLicensePlateAbove7()
        {
            Car MyCar = new Car();
            Assert.Throws<Exception>(() => MyCar.LicensePlate = "AA44QQ38");
        }

        [Fact]
        public void TestingGetModel2()
        {
            Car MyCar = new Car();
            MyCar.Model = "123A567";
            Assert.Equal("123A567", MyCar.Model);
        }

        
        [Fact]
        public void TestingLicensePlateNoException()
        {
            Car MyCar = new Car();
            MyCar.LicensePlate = "1234567";
            var result = MyCar.LicensePlate;
            Assert.Same(result, MyCar.LicensePlate);
        }
        
        
        
        [Fact]
        public void TestingGetModel()
        {
            Car MyCar = new Car();
            MyCar.Model = "3J455";
            Assert.Equal("3J455", MyCar.Model);
        }
        

        
        [Fact]
        public void TestingGetPrice()
        {
            Car MyCar1 = new Car
            {
                Price = 25
            };
            var result = MyCar1.Price;
            Assert.Equal(25, result);
        }
        
    }
}
