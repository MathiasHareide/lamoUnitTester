[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class LamoUnitTestAttribute: Attribute
{
    public string Description { get; set; } = "N/A";
    public object[]? Args { get; set; } = null;
}
