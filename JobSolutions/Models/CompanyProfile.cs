namespace JobSolutions.Models;

public class CompanyProfile
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ContactInfo { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public string CompanyLogoPath { get; set; } = string.Empty;
    public bool VerificationStatus { get; set; } = false;
    public bool VerificationNoted { get; set; } = false;

}
