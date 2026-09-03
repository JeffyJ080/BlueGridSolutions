namespace BlueGridSolutions.Models;

public class ServiceItem
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Tagline { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string FullDescription { get; set; } = string.Empty;
    public List<string> KeyFeatures { get; set; } = new();
    public List<string> OwnerBenefits { get; set; } = new();
    public string Badge { get; set; } = string.Empty;
    public bool IsPopular { get; set; }
}
