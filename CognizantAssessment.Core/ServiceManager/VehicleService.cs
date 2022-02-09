using CognizantAssessment.Core.DTO;
using CognizantAssessment.Core.IServiceManager;
using CognizantAssessment.Data.Entity;
using CognizantAssessment.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognizantAssessment.Core.ServiceManager
{
    public class VehicleService : IVehicleService
    {
        private readonly IRepository<Cars> _carRepository;
        private readonly IRepository<Warehouse> _warehouseRepository;

        public VehicleService(IRepository<Cars> carRepository, IRepository<Warehouse> warehouseRepository)
        {
            _carRepository = carRepository;
            _warehouseRepository = warehouseRepository;
        }


        public async Task<List<GetVehiclesDto>> GetAllVehicles()
        {
            var result = new List<GetVehiclesDto>();
            var resp = await _carRepository.GetAllWithInclude(x => x.date_added, nameof(Warehouse));
            if (resp != null)
            {
                resp.ForEach(p =>
                {
                    result.Add(new GetVehiclesDto
                    {
                        Id = p.Id,
                        licensed = p.licensed,
                        make = p.make,
                        model = p.model,
                        price = p.price,
                        year_model = p.year_model,
                        latitude = p.Warehouse.Latitude,
                        location = p.location,
                        longitude = p.Warehouse.Longitude,
                        warehouse = p.Warehouse.Name
                    });
                });
            }

            return result;
        }
    }
}
