namespace GrowthHub.WebUi;

public class CashbookOptions
{
    // TODO: Implement IOptions pattern for connection strings
    public const string BasePath = "ConnectionStrings";

    public string CashbookConnection { get; set; }
}