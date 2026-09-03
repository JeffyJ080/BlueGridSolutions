using System.ComponentModel.DataAnnotations;

namespace BlueGridSolutions.Models;

public class QuoteRequestModel
{
    [Required(ErrorMessage = "Full Name is required.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Full Name must be between 2 and 100 characters.")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email Address is required.")]
    [EmailAddress(ErrorMessage = "Please provide a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number is required.")]
    [Phone(ErrorMessage = "Please provide a valid phone number.")]
    public string Phone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Property Type is required.")]
    public string PropertyType { get; set; } = string.Empty;

    [Required(ErrorMessage = "Service Required is required.")]
    public string ServiceRequired { get; set; } = string.Empty;

    [Range(1, 5000, ErrorMessage = "Number of units must be at least 1.")]
    public int NumberOfUnits { get; set; } = 1;

    public string PropertyLocation { get; set; } = string.Empty;

    [Range(0, 500000000, ErrorMessage = "Estimated valuation cannot be negative.")]
    public decimal EstimatedValuation { get; set; }

    [StringLength(1000, ErrorMessage = "Additional notes cannot exceed 1,000 characters.")]
    public string AdditionalNotes { get; set; } = string.Empty;
}
