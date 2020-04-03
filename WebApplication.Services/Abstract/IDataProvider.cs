using System.Collections.Generic;
using WebApplication.Services.Models;

namespace WebApplication.Services.Abstract
{
    public interface IDataProvider
    {
        List<Manufacturer> Manufacturers { get; }
        List<VehicleModel> Models { get; }
    }
}