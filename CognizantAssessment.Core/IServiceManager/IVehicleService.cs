using CognizantAssessment.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognizantAssessment.Core.IServiceManager
{
    public interface IVehicleService
    {
        Task<List<GetVehiclesDto>> GetAllVehicles();
    }
}
