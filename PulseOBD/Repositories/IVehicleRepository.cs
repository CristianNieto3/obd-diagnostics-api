using PulseOBD.Models;

namespace PulseOBD.Repositories;

public interface IVehicleRepository
{
    Task<List<Vehicle>> GetAll();
    Task<Vehicle?> GetById(int Id);

    Task<Vehicle> AddVehicle(Vehicle vehicle);

     Task<bool> UpdateById(int Id, Vehicle vehicle);

     Task<bool> DeleteById(int Id);





    
}