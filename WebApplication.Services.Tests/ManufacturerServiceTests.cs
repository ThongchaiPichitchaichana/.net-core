using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using WebApplication.Services.Abstract;
using WebApplication.Services.Concrete;

namespace WebApplication.Services.Tests
{
    [TestFixture]
    public class ManufacturerServiceTests
    {

        private IManufacturerService _manufacturerService;
    


    [SetUp]
    public void Setup()
    {
            _manufacturerService = new ManufacturerService(new DataProvider());
    }


        //todo: fix test
      [TestCase("488GTB", "FERRARI")]
      [TestCase("A8ハイブリッド", "AUDI")]
      [TestCase("エテルナ", "MITSUBISHI")]
      [TestCase("スプリンタートレノ", "TOYOTA")]
      [TestCase("パサートGTEヴァリアント", "VOLKSWAGEN")]
       [Test]
        public void CanIdentifyManufacturer(string value, string expected)
        {
           
            string result = _manufacturerService.GetManufacturerByModel(value);
            Assert.AreEqual(result, expected);
        }

    

    }
}
