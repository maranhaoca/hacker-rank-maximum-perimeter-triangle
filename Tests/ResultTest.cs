using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        List<int> sticks = new List<int>(){1, 2, 3, 4, 5, 10};

        List<int> expected = new List<int>(){3, 4, 5};

        var actual = Result.maximumPerimeterTriangle(sticks);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        List<int> sticks = new List<int>(){1, 1, 1, 3, 3};

        List<int> expected = new List<int>(){1, 3, 3};

        var actual = Result.maximumPerimeterTriangle(sticks);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        List<int> sticks = new List<int>(){1, 2, 3};

        List<int> expected = new List<int>(){-1};

        var actual = Result.maximumPerimeterTriangle(sticks);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        List<int> sticks = new List<int>(){1, 1, 1, 2, 3, 5};

        List<int> expected = new List<int>(){1, 1, 1};

        var actual = Result.maximumPerimeterTriangle(sticks);

        Assert.Equal(expected, actual);
    }
}