namespace PulseOBD.Models;

public class SensorReadings
{
    public int Id {get; set;}
    public int SessionId {get; set;}
    public DateTime Timestamp {get; set;}
    public String SensorType {get; set;}
    public String Unit {get; set;}
    public double Value { get; set;} // possibly for the values of the units?

}