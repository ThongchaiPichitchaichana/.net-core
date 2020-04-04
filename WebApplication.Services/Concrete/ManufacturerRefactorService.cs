using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using WebApplication.Services.Abstract;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class ManufacturerRefacterService : IManufacturerRefactorService
    {
        private IDataProviderRefactor _dataProvider;

        public ManufacturerRefacterService(IDataProviderRefactor dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public string GetManufacturerByModel(string model)
        {
            string result = "";

            var contextModel = _dataProvider.Models;
            var vehicleModelRefactor = contextModel.vehicleModelRefactor;

         
            var query = (from v in vehicleModelRefactor      
                         where v.ModelName == model
                         select new { v.manufacturer.ManufacturerName  }).ToList();
            result = query.FirstOrDefault().ManufacturerName.ToString();

          
            contextModel.Dispose();

            return result;
        }

      
    }
}