
using PulseOBD.Models;
using PulseOBD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
namespace PulseOBD.Repositories;

//async can use await in its body. Use this in I/O bound operations mainly (network requests,file access, db queries etc..)
// Sync vs Async (core idea)
// Synchronous work means the current thread stays occupied until the operation finishes.
// Asynchronous work means the method can pause while waiting, so that thread can go do other work, then resume later.
//await means: pause here until that Task completes, then continue with the result or throw its exception.

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
        return _context.Vehicles.FindAsync(Id).AsTask();

    }

      public async Task<bool> DeleteById(int Id)
    {
        var deleteVehicle = await _context.Vehicles.FindAsync(Id);
        if (deleteVehicle is { })
        {
            _context.Vehicles.Remove(deleteVehicle);
            await _context.SaveChangesAsync();
            
        } 
        else
        {
            throw new InvalidOperationException("Vehicle not found.");
        }
        return true;
    }

    public async Task<bool> UpdateById(int Id, Vehicle vehicle)
    {
        var updatedVehicle = await _context.Vehicles.FindAsync(Id);

        if(updatedVehicle != null)
        {
            updatedVehicle.VIN = vehicle.VIN;
            updatedVehicle.Make = vehicle.Make;
            updatedVehicle.Model =vehicle.Model;
            updatedVehicle.Year = vehicle.Year;
            await _context.SaveChangesAsync();
            return true;
        }

        throw new InvalidOperationException("Vehicle not found");
        
        
    }
}




