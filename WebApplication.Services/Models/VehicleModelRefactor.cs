using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Services.Models
{
    public class VehicleModelRefactor
    {
        public string Id { get; set; }

        public string ModelName { get; set; }

        public string ManufacturerId { get; set; }

        [ForeignKey("ManufacturerId")]
        public virtual Manufacturer manufacturer { get; set; }
    }

}