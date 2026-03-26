namespace RotaApplication.Models;

// This class represents the staffing requirements for a specific day, 
// including the number of staff needed and any special notes or conditions for that day.

public class DayRequirements
{
    public int Id { get; set; }

    public required string DayName { get; set; } // e.g., Monday, Tuesday, etc.

    public int RequiredStaffCount { get; set; }

    public DateTime? MinimumCoverage { get; set; }

    public DateTime? MaximumCoverage { get; set; }

    public string? Notes { get; set; }

    public bool IsWeekend { get; set; }


}