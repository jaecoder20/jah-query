namespace JahCore.Attributes;
[AttributeUsage(AttributeTargets.Property)]
public class JahColumnAttribute : System.Attribute
{
    private string _columnName;
    public JahColumnAttribute(string columnName)
    {
        if (string.IsNullOrWhiteSpace(columnName))
            throw new ArgumentException("Column name cannot be null or empty", nameof(columnName));
            
        _columnName = columnName.Trim();
    }
    public string Name => _columnName;
    public bool IsNullable { get; set; } = true;
    public int? MaxLength { get; set; }
    
}