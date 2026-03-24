namespace PulseOBD.Models;

public class Session
{
    public int Id{get; set;}
    public int VehicleId{get; set;} //fk
    public DateTime StartTime {get; set;}
    public DateTime? EndTime{get; set;}
    public DateTime CreatedAt {get; set;}

}