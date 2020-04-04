using System.Collections.Generic;
using WebApplication.Services.Concrete;
using WebApplication.Services.Models;

namespace WebApplication.Services.Abstract
{
    public interface IDataProvider
    {
        List<Manufacturer> Manufacturers { get; }
        List<VehicleModel> Models { get; }
    }

    public interface IDataProviderRefactor
    {
        MyContext Manufacturers { get; }
        MyContext Models { get; }
    }
}