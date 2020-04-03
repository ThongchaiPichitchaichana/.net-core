using System.Collections.Generic;
using WebApplication.Services.Abstract;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class DataProvider: IDataProvider
    {
        public List<Manufacturer> Manufacturers => Db.GetManufacturers();

        public List<VehicleModel> Models => Db.GetModels();
    }
}
