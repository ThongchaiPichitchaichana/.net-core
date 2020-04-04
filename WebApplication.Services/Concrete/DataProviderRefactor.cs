using System.Collections.Generic;
using WebApplication.Services.Abstract;
using WebApplication.Services.Models;

namespace WebApplication.Services.Concrete
{
    public class DataProviderRefactor: IDataProviderRefactor
    {
        public MyContext Manufacturers => DbRefactor.GetManufacturers();

        public MyContext Models => DbRefactor.GetModels();
    }
}
