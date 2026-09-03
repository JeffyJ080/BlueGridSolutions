using System.ComponentModel.DataAnnotations;

namespace BlueGridSolutions.Models;

public class ContactInquiryModel
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

    [Required(ErrorMessage = "Subject is required.")]
    [StringLength(150, MinimumLength = 3, ErrorMessage = "Subject must be between 3 and 150 characters.")]
    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a service interest.")]
    public string ServiceInterest { get; set; } = string.Empty;

    [Required(ErrorMessage = "Inquiry message is required.")]
    [StringLength(2000, MinimumLength = 10, ErrorMessage = "Message must be at least 10 characters.")]
    public string Message { get; set; } = string.Empty;

    public string PreferredContactMethod { get; set; } = "Email"; // "Email", "Phone", "WhatsApp"
}
