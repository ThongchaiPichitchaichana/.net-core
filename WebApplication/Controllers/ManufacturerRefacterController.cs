using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Services.Abstract;
using WebApplication.Services.Concrete;
using WebApplication.Services.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerRefactorController : ControllerBase
    {
        private IManufacturerRefactorService manufacturerService;
       
        private IGetNumberOfModelRefactorService getNumberOfModelService;
   
        public ManufacturerRefactorController(IManufacturerRefactorService _manufacturerService, IGetNumberOfModelRefactorService _getNumberOfModelService )
        {
            manufacturerService = _manufacturerService;
            getNumberOfModelService = _getNumberOfModelService;
       
        }

        //todo: Create a method to get manufacturer name by model
        // GET api/Manufacturer/model
        [HttpGet("{model}")]
        public IActionResult Get(string model)
        {
    
           string ManufacturerName = manufacturerService.GetManufacturerByModel(model)== null ? "" : manufacturerService.GetManufacturerByModel(model);
            GetManufacturerNameByModel getManufacturerNameByModel = new GetManufacturerNameByModel();
            getManufacturerNameByModel.ManufacturerName = ManufacturerName;
            if (ManufacturerName == "")
            {
                return NotFound(getManufacturerNameByModel);
            }
            return Ok(getManufacturerNameByModel);

        }

        //todo: create a method to return all manufacturers and number of models for these manufacturers
        [HttpGet]
        public IActionResult GetNumberOfModel()
        {
            List<GetNumberOfModel> getNumberOfModels = new List<GetNumberOfModel>();
            getNumberOfModels = getNumberOfModelService.GetNumberOfModel();
        
            if (getNumberOfModels == null)
            {
                return NotFound(getNumberOfModels);
            }
            return Ok(getNumberOfModels);

        }


        
    }
}