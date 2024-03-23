using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrowthHub.Domain;

public class Transaction
{
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid Id { get; set; }

    [Required]
    public DateOnly TransactionDate { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public TypeOfTransaction TransactionType { get; set; }

    [Required]
    public decimal Amount { get; set; }

    [Required]
    public bool IsSpendingMoney { get; set; }

    public Guid UserId { get; set; }
    
    public virtual User User { get; set; }
}