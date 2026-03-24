using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace PulseOBD.Models;
public class Vehicle
{
    public int Id {get; set;}
    public int VIN{get; set;}
    public String Make{get; set;}
    public String Model{get; set;}
    public String Year {get; set;}
    public DateTime CreatedAt{get;set;}

    }