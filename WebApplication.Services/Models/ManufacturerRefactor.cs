using System.Collections.Generic;

namespace WebApplication.Services.Models
{
    public class ManufacturerRefactor
    {
        public string Id { get; set; }
        public string ManufacturerName { get; set; }

        public virtual List<VehicleModel> vehicleModel { get; set; }
    }
}