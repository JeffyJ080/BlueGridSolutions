namespace BlueGridSolutions.Services;

using System.Net.Http.Json;
using System.Text.Json;
using BlueGridSolutions.Models;

public class ContentService : IContentService
{
    private readonly HttpClient _http;
    private readonly JsonSerializerOptions _jsonOptions;

    private CompanyInfo? _companyInfoCache;
    private List<ServiceItem>? _servicesCache;
    private List<PropertyProject>? _projectsCache;
    private List<TeamMember>? _teamCache;
    private List<FaqItem>? _faqsCache;

    public ContentService(HttpClient http)
    {
        _http = http;
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }

    public async Task<CompanyInfo> GetCompanyInfoAsync()
    {
        if (_companyInfoCache != null)
            return _companyInfoCache;

        try
        {
            _companyInfoCache = await _http.GetFromJsonAsync<CompanyInfo>("data/company.json", _jsonOptions) 
                ?? new CompanyInfo();
        }
        catch (Exception)
        {
            _companyInfoCache = new CompanyInfo();
        }

        return _companyInfoCache;
    }

    public async Task<List<ServiceItem>> GetServicesAsync()
    {
        if (_servicesCache != null)
            return _servicesCache;

        try
        {
            _servicesCache = await _http.GetFromJsonAsync<List<ServiceItem>>("data/services.json", _jsonOptions) 
                ?? new List<ServiceItem>();
        }
        catch (Exception)
        {
            _servicesCache = new List<ServiceItem>();
        }

        return _servicesCache;
    }

    public async Task<ServiceItem?> GetServiceByIdAsync(string id)
    {
        var services = await GetServicesAsync();
        return services.FirstOrDefault(s => string.Equals(s.Id, id, StringComparison.OrdinalIgnoreCase));
    }

    public async Task<List<PropertyProject>> GetProjectsAsync()
    {
        if (_projectsCache != null)
            return _projectsCache;

        try
        {
            _projectsCache = await _http.GetFromJsonAsync<List<PropertyProject>>("data/projects.json", _jsonOptions) 
                ?? new List<PropertyProject>();
        }
        catch (Exception)
        {
            _projectsCache = new List<PropertyProject>();
        }

        return _projectsCache;
    }

    public async Task<PropertyProject?> GetProjectByIdAsync(string id)
    {
        var projects = await GetProjectsAsync();
        return projects.FirstOrDefault(p => string.Equals(p.Id, id, StringComparison.OrdinalIgnoreCase));
    }

    public async Task<List<PropertyProject>> GetFeaturedProjectsAsync()
    {
        var projects = await GetProjectsAsync();
        return projects.Where(p => p.IsFeatured).ToList();
    }

    public async Task<List<TeamMember>> GetTeamMembersAsync()
    {
        if (_teamCache != null)
            return _teamCache;

        try
        {
            _teamCache = await _http.GetFromJsonAsync<List<TeamMember>>("data/team.json", _jsonOptions) 
                ?? new List<TeamMember>();
        }
        catch (Exception)
        {
            _teamCache = new List<TeamMember>();
        }

        return _teamCache;
    }

    public async Task<List<FaqItem>> GetFaqsAsync()
    {
        if (_faqsCache != null)
            return _faqsCache;

        try
        {
            var faqs = await _http.GetFromJsonAsync<List<FaqItem>>("data/faqs.json", _jsonOptions) 
                ?? new List<FaqItem>();
            _faqsCache = faqs.OrderBy(f => f.DisplayOrder).ToList();
        }
        catch (Exception)
        {
            _faqsCache = new List<FaqItem>();
        }

        return _faqsCache;
    }

    public async Task<List<FaqItem>> GetFaqsByCategoryAsync(string category)
    {
        var faqs = await GetFaqsAsync();
        if (string.IsNullOrWhiteSpace(category) || category.Equals("All", StringComparison.OrdinalIgnoreCase))
            return faqs;

        return faqs.Where(f => string.Equals(f.Category, category, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
