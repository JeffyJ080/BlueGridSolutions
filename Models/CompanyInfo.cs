namespace BlueGridSolutions.Models;

public class CompanyInfo
{
    public string Name { get; set; } = "BlueGridSolutions";
    public string Tagline { get; set; } = "Excellence in Luxury Property Management & Investment Stewardship";
    public string ShortDescription { get; set; } = string.Empty;
    public string Story { get; set; } = string.Empty;
    public string Mission { get; set; } = string.Empty;
    public string Vision { get; set; } = string.Empty;
    public List<string> CoreValues { get; set; } = new();
    public List<CompanyStat> KeyMetrics { get; set; } = new();
    public ContactDetails Contact { get; set; } = new();
    public SocialLinks Socials { get; set; } = new();
}

public class CompanyStat
{
    public string Value { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class ContactDetails
{
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string WhatsAppNumber { get; set; } = string.Empty;
    public string WhatsAppDirectUrl => $"https://wa.me/{WhatsAppNumber.Replace("+", "").Replace(" ", "").Replace("-", "")}";
    public string OfficeAddress { get; set; } = string.Empty;
    public string CityStateZip { get; set; } = string.Empty;
    public string OperatingHours { get; set; } = string.Empty;
}

public class SocialLinks
{
    public string LinkedIn { get; set; } = string.Empty;
    public string Instagram { get; set; } = string.Empty;
    public string Facebook { get; set; } = string.Empty;
    public string Twitter { get; set; } = string.Empty;
}
