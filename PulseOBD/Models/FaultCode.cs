namespace PulseOBD.Models;

public class FaultCode
{
    public int Id{get; set;}
    public string Code {get; set;}
    public string Description{get; set;}
    public string? AiExplanation{get; set;}
    public DateTimeOffset CapturedAt {get; set;}
    public bool IsActive {get; set;}
}