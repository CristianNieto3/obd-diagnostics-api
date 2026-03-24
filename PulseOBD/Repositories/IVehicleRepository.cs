using PulseOBD.Models;

namespace PulseOBD.Repositories;

public interface IVehiclesRepository
{
   List<Vehicle> void GetAll();
    Vehicle? void GetById();
    void Add(Vehicle vehicle);
    void Update(Vehicle);
    void Delete(Vehicle);
}