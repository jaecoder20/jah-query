namespace JahCore.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class TableAttribute : System.Attribute
{
    private string _tableName;
    public TableAttribute(string tableName)
    {
        if (string.IsNullOrWhiteSpace(tableName))
            throw new ArgumentException("Table name cannot be null or empty", nameof(tableName));
            
        _tableName = tableName.Trim();
    }
    // Property to access the table name
    public string Name => _tableName;
    public string Schema { get; set; }
}