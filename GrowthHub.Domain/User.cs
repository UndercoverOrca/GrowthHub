using Microsoft.AspNetCore.Identity;

namespace GrowthHub.Domain;

public class User : IdentityUser
{
    public Guid Guid { get; set; }
    
    public string FullName { get; set; }
    
    public MoneyDistribution MoneyDistribution { get; set; }
    
    public List<Transaction> Transactions { get; set; }
}