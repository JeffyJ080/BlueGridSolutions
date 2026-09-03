using System.ComponentModel.DataAnnotations;

namespace BlueGridSolutions.Models;

public class RentalYieldModel
{
    [Range(10000, 100000000, ErrorMessage = "Purchase price must be at least $10,000.")]
    public decimal PurchasePrice { get; set; } = 850000m;

    [Range(100, 1000000, ErrorMessage = "Monthly rent must be at least $100.")]
    public decimal MonthlyRent { get; set; } = 4800m;

    [Range(0, 10000000, ErrorMessage = "Annual expenses must be positive.")]
    public decimal AnnualOperatingExpenses { get; set; } = 9600m; // HOA, insurance, property tax, maintenance reserve

    [Range(0, 50, ErrorMessage = "Vacancy rate must be between 0% and 50%.")]
    public decimal VacancyRatePercent { get; set; } = 4.0m;

    // Derived Financial Metrics
    public decimal AnnualGrossRent => MonthlyRent * 12m;

    public decimal EffectiveGrossIncome => AnnualGrossRent * (1.0m - (VacancyRatePercent / 100.0m));

    public decimal NetOperatingIncome => EffectiveGrossIncome - AnnualOperatingExpenses;

    public decimal GrossYieldPercent => PurchasePrice > 0 ? (AnnualGrossRent / PurchasePrice) * 100.0m : 0m;

    public decimal NetYieldPercent => PurchasePrice > 0 ? (NetOperatingIncome / PurchasePrice) * 100.0m : 0m;

    public decimal MonthlyNetCashFlow => NetOperatingIncome / 12.0m;
}
