using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognizantAssessment.Data.Entity
{
    public class Cars
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 WarehouseId { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year_model { get; set; }
        public decimal price { get; set; }
        public bool licensed { get; set; }
        public string location { get; set; }
        public DateTime date_added { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
