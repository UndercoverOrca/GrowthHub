namespace GrowthHub.Domain;

public class MoneyDistribution
{
    public Guid Id { get; set; }
    
    public int Spending { get; set; }
    
    public int Savings { get; set; }
    
    public Guid UserId { get; set; }
    
    public virtual User User { get; set; }
}