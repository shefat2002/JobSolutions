namespace JobSolutions.Models;

public class CompanyOwnership
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public OwnershipType Type { get; set; }
}
public enum OwnershipType
{
    Private,
    Public,
    Government,
    NonProfit,
    Partnership,
    Cooperative
}
