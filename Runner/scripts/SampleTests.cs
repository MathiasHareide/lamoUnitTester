public class SampleTests
{
    [LamoUnitTest(Description = "Checks if 2 + 2 = 4")]
    public static bool Addition()
    {
        return 2 + 2 == 4;
    }

    [LamoUnitTest(Description = "Checks if 5 is more than 3")]
    public static bool MoreThan()
    {
        return 5 > 3;
    }

    [LamoUnitTest(Description = "Checks if false == true. If this doesn't fail idk what's wrong.")]
    public static bool ThisShouldFail()
    {
        return false;
    }
}
