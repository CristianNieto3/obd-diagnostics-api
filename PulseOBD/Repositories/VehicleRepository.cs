
using PulseOBD.Models;

namespace PulseOBD.Repositories;

public class EfVehicleRepository : IVehicleRepository
{

    public Task<List<Vehicle>> GetAll()
    {
        throw new NotImplementedException();
    }

     public Task<Vehicle> AddVehicle(Vehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public Task<Vehicle?> GetById(int Id)
    {
        throw new NotImplementedException();
    }

      public Task<bool> DeleteById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateById(int Id, Vehicle vehicle)
    {
        throw new NotImplementedException();
    }
}




