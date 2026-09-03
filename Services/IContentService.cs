namespace BlueGridSolutions.Services;

using BlueGridSolutions.Models;

public interface IContentService
{
    Task<CompanyInfo> GetCompanyInfoAsync();
    Task<List<ServiceItem>> GetServicesAsync();
    Task<ServiceItem?> GetServiceByIdAsync(string id);
    Task<List<PropertyProject>> GetProjectsAsync();
    Task<PropertyProject?> GetProjectByIdAsync(string id);
    Task<List<PropertyProject>> GetFeaturedProjectsAsync();
    Task<List<TeamMember>> GetTeamMembersAsync();
    Task<List<FaqItem>> GetFaqsAsync();
    Task<List<FaqItem>> GetFaqsByCategoryAsync(string category);
}
