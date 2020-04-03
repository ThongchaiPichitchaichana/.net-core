using System.Collections.Generic;
using WebApplication.Services.Models;

namespace WebApplication.Services.Abstract
{
    public interface IManufacturerService
    {
        string GetManufacturerByModel(string model);
    
    }
    public interface IGetNumberOfModelService
    {
 
        List<GetNumberOfModel> GetNumberOfModel();
    }

}
