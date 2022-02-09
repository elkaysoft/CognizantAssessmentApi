using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognizantAssessment.Core.DTO
{
    public class GetVehiclesDto
    {
        public Int64 Id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year_model { get; set; }
        public decimal price { get; set; }
        public bool licensed { get; set; }
        public string warehouse { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string location { get; set; }
    }
}
