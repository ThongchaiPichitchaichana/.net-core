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


    public interface IManufacturerRefactorService
    {
        string GetManufacturerByModel(string model);

    }
    public interface IGetNumberOfModelRefactorService
    {

        List<GetNumberOfModel> GetNumberOfModel();
    }
}
