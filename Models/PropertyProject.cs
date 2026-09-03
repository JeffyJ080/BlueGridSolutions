namespace BlueGridSolutions.Models;

public class PropertyProject
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; // "Luxury Residential", "Commercial Asset", "Modern Apartment", "Executive Villa"
    public string Location { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public decimal MonthlyRent { get; set; }
    public decimal Valuation { get; set; }
    public string FormattedRent => $"${MonthlyRent:N0}/mo";
    public string FormattedValuation => $"${Valuation:N0}";
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int SquareFeet { get; set; }
    public int ParkingSpaces { get; set; }
    public string Status { get; set; } = "Available"; // "Available", "Leased", "Under Management"
    public string ImageUrl { get; set; } = string.Empty;
    public List<string> GalleryImages { get; set; } = new();
    public string Description { get; set; } = string.Empty;
    public List<string> Amenities { get; set; } = new();
    public decimal ProjectedYieldPercent { get; set; }
    public bool IsFeatured { get; set; }
    public int YearBuilt { get; set; }
}
