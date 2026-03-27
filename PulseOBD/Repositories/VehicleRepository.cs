
using PulseOBD.Models;
using PulseOBD.Data;
using Microsoft.EntityFrameworkCore;
namespace PulseOBD.Repositories;

//async can use await in its body. Use this in I/O bound operations mainly (network requests,file access, db queries etc..)

public class EfVehicleRepository : IVehicleRepository
{
    private readonly ApplicationDbContext _context;

    public EfVehicleRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task<List<Vehicle>> GetAll()
    {
       return _context.Vehicles.AsNoTracking().ToListAsync();
    }

     public async Task<Vehicle> AddVehicle(Vehicle vehicle)
    {
        //add vehicle 
        _context.Vehicles.Add(vehicle);
        await _context.SaveChangesAsync();
        return vehicle;
    }

    public Task<Vehicle?> GetById(int Id)
    //if its not null, return it. otherwise throw an exception.
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




