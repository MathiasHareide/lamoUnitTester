public class SampleTests
{
    [LamoUnitTest(Description = "2 + 2 = 4", Args = [2, 2, 4])]
    [LamoUnitTest(Description = "3 + -2 = 1", Args = [3, -2, 1])]
    public static bool Addition(int a, int b, int expected)
    {
        return a + b == expected;
    }

    [LamoUnitTest(Description = "5 > 3", Args = [5, 3])]
    public static bool MoreThan(int a, int b)
    {
        return a > b;
    }

    [LamoUnitTest(Description = "If this doesn't fail idk what's wrong.")]
    public static bool ThisShouldFail()
    {
        return false;
    }
}
