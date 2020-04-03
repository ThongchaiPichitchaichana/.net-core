using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using WebApplication.Services.Abstract;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class GetNumberOfModelService : IGetNumberOfModelService
    {
        private IDataProvider _dataProvider;
        public GetNumberOfModelService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public List<GetNumberOfModel> GetNumberOfModel()
        {
            var Manufacturers = _dataProvider.Manufacturers;
            var VehicleModel = _dataProvider.Models;

            List<GetNumberOfModel> result = new List<GetNumberOfModel>();
            
            var query = (from v in VehicleModel
                         join M in Manufacturers on v.ManufacturerId equals M.Id
                         group v by M into g
                         select new { g.Key.ManufacturerName, NumberOfModel = g.Key.ManufacturerName.Count() } ).ToList();
            foreach (var item in query)
            {
                GetNumberOfModel temp = new GetNumberOfModel();
                
                temp.ManufacturerName = item.ManufacturerName;
                temp.NumberOfModel = item.NumberOfModel;
                result.Add(temp);
            }
            return result;
        }


    }
}