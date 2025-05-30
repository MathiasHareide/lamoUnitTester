using System.Reflection;

public class TestRunner
{
    public static void RunTests(Assembly assembly)
    {
        foreach (var type in assembly.GetTypes())
        {
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance))
            {
                foreach (var attr in method.GetCustomAttributes<LamoUnitTestAttribute>())
                { 
                    if (attr == null) continue;
                    if (method.Invoke(null, attr.Args) is bool result)
                    {
                        Console.WriteLine($"{(result ? "[PASSED]" : "[FAILED]")} {method.Name}: " + attr.Description);
                    }
                    else
                    {
                        Console.WriteLine($"{method.Name}: Returned unexpected result");
                    }
                }
            }
        }
    }
}
