namespace JahCore.Attributes;
[AttributeUsage(AttributeTargets.Property)]
public class JahKeyAttribute: System.Attribute
{
    public bool IsAutoIncrement { get; set; } = true;
    // For composite keys, allow ordering
    public int Order { get; set; }
    public JahKeyAttribute()
    {
    }
}