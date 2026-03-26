namespace RotaApplication.Models;


public class StaffModel
{
    public int Id {get; set;}

    public required string FirstName { get; set; }

    public required string LastNameInitial { get; set; }

    public DateTime StartTime { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


}