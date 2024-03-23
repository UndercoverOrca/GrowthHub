using Microsoft.AspNetCore.Identity;

namespace GrowthHub.Domain;

public class User : IdentityUser<Guid>
{
    public string name { get; set; }
    
    public int savingPercentage { get; set; }
    
    public int investmentPercentage { get; set; }
    
    public int spendingMoneyPercentage { get; set; }

    public virtual ICollection<Transaction> transactions { get; set; }
}