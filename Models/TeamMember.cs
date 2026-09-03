namespace BlueGridSolutions.Models;

public class TeamMember
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string AvatarUrl { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string LinkedInUrl { get; set; } = string.Empty;
    public int ExperienceYears { get; set; }
    public List<string> Specializations { get; set; } = new();
}
