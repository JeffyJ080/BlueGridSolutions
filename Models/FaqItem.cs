namespace BlueGridSolutions.Models;

public class FaqItem
{
    public string Id { get; set; } = string.Empty;
    public string Question { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; // "Property Management", "Tenant Placement", "Maintenance SLAs", "Fees & Pricing"
    public int DisplayOrder { get; set; }
}
