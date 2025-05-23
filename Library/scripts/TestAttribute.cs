[AttributeUsage(AttributeTargets.Method)]
public class LamoUnitTestAttribute : Attribute
{
    public required string Description { get; set; }
}
