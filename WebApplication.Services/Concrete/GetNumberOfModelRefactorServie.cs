using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using WebApplication.Services.Abstract;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class GetNumberOfModelRefactorService : IGetNumberOfModelRefactorService
    {
        private IDataProviderRefactor _dataProvider;
        public GetNumberOfModelRefactorService(IDataProviderRefactor dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public List<GetNumberOfModel> GetNumberOfModel()
        {
            var context = _dataProvider.Manufacturers;
            var Manufacturers = context.manufacturerRefactor;

            List<GetNumberOfModel> result = new List<GetNumberOfModel>();
            
            var query = (
                         from M in Manufacturers 
                         select new { M.ManufacturerName, NumberOfModel = M.vehicleModel.Count()  } ).ToList();
            foreach (var item in query)
            {
                GetNumberOfModel temp = new GetNumberOfModel();
                
                temp.ManufacturerName = item.ManufacturerName;
                temp.NumberOfModel = item.NumberOfModel;
                result.Add(temp);
            }
            
            context.Dispose();
            return result;
        }


    }
}