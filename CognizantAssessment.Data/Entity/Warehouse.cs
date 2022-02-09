using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognizantAssessment.Data.Entity
{
    public class Warehouse
    {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public ICollection<Cars> Cars { get; set; }
    }
}
