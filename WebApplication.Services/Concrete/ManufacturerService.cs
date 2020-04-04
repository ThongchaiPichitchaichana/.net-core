using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using WebApplication.Services.Abstract;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class ManufacturerService : IManufacturerService
    {
        private IDataProvider _dataProvider;


        public ManufacturerService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public string GetManufacturerByModel(string model)
        {
            var Manufacturers =  _dataProvider.Manufacturers;
            var VehicleModel = _dataProvider.Models;

            string result= "";
            var query = (from v in VehicleModel
                        join Manufacturer in Manufacturers on v.ManufacturerId equals Manufacturer.Id
                       where v.ModelName == model
                       select new { Manufacturer.ManufacturerName }).ToList();
            result = query.FirstOrDefault().ManufacturerName.ToString();
            return result;
        }

      
    }
}