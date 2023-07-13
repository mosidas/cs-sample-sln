namespace LibraryTest;

using Library;

public class Class1Test
{
    [Fact]
    public void AddTest()
    {
        var c = new Class1();
        Assert.Equal(3, c.Add(1, 2));
    }

    [Fact]
    public void FalseTest()
    {
        Assert.True(true);
    }
}