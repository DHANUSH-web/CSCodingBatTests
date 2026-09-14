using CSCodingBat;

namespace CSCodingBatTests;

public class ProgramTests
{
    [Theory]
    [InlineData("last", "chars", "ls")]
    [InlineData("yo", "java", "ya")]
    [InlineData("hi", "", "h@")]
    [InlineData("", "hello", "@o")]
    [InlineData("", "", "@@")]
    public void LastChars_ReturnsExpected(string a, string b, string expected)
    {
        Assert.Equal(expected, Program.LastChars(a, b));
    }

    [Theory]
    [InlineData("abc", "cat", "abcat")]
    [InlineData("dog", "cat", "dogcat")]
    [InlineData("abc", "", "abc")]
    [InlineData("", "cat", "cat")]
    [InlineData("", "", "")]
    public void Concat_ReturnsExpected(string a, string b, string expected)
    {
        Assert.Equal(expected, Program.Concat(a, b));
    }

    [Theory]
    [InlineData("coding", "codign")]
    [InlineData("cat", "cta")]
    [InlineData("ab", "ba")]
    [InlineData("a", "a")]
    [InlineData("", "")]
    public void LastTwo_ReturnsExpected(string input, string expected)
    {
        Assert.Equal(expected, Program.LastTwo(input));
    }

    [Theory]
    [InlineData("redxx", "red")]
    [InlineData("blueTimes", "blue")]
    [InlineData("NoColor", "")]
    [InlineData("red", "red")]
    [InlineData("blu", "")]
    public void SeeColors_ReturnsExpected(string input, string expected)
    {
        Assert.Equal(expected, Program.SeeColors(input));
    }

    [Theory]
    [InlineData("edited", true)]
    [InlineData("edit", false)]
    [InlineData("ed", true)]
    [InlineData("a", false)]
    public void FrontAgain_ReturnsExpected(string input, bool expected)
    {
        Assert.Equal(expected, Program.FrontAgain(input));
    }

    [Theory]
    [InlineData("Hello", "Hi", "loHi")]
    [InlineData("Hello", "java", "ellojava")]
    [InlineData("ab", "xyz", "abyz")]
    [InlineData("abc", "abc", "abcabc")]
    public void MinCat_ReturnsExpected(string a, string b, string expected)
    {
        Assert.Equal(expected, Program.MinCat(a, b));
    }

    [Theory]
    [InlineData("xHix", "Hix")]
    [InlineData("xHi", "Hii")]
    [InlineData("Hxix", "Hxix")]
    public void WithoutX_ReturnsExpected(string input, string expected)
    {
        Assert.Equal(expected, Program.WithoutX(input));
    }

    [Fact]
    public void Front11_BothNonEmpty()
    {
        Assert.Equal(new[] { 1, 7 }, Program.Front11(new[] { 1, 2, 3 }, new[] { 7, 9, 8 }));
    }

    [Fact]
    public void Front11_FirstEmpty()
    {
        Assert.Equal(new[] { 2 }, Program.Front11(Array.Empty<int>(), new[] { 2, 8 }));
    }

    [Fact]
    public void Front11_BothEmpty()
    {
        Assert.Empty(Program.Front11(Array.Empty<int>(), Array.Empty<int>()));
    }

    [Theory]
    [InlineData(12, true)]
    [InlineData(17, false)]
    [InlineData(19, true)]
    [InlineData(10, true)]
    [InlineData(15, false)]
    public void Near10_ReturnsExpected(int input, bool expected)
    {
        Assert.Equal(expected, Program.Near10(input));
    }

    [Theory]
    [InlineData(6, 8, 1)]
    [InlineData(3, 8, 0)]
    [InlineData(20, 6, 2)]
    public void TeaParty_ReturnsExpected(int tea, int candy, int expected)
    {
        Assert.Equal(expected, Program.TeaParty(tea, candy));
    }

    [Theory]
    [InlineData("fig", "Fizz")]
    [InlineData("dib", "Buzz")]
    [InlineData("fib", "FizzBuzz")]
    [InlineData("hello", "hello")]
    public void FizzString_ReturnsExpected(string input, string expected)
    {
        Assert.Equal(expected, Program.FizzString(input));
    }

    [Theory]
    [InlineData(1, "1!")]
    [InlineData(2, "2!")]
    [InlineData(3, "Fizz!")]
    [InlineData(5, "Buzz!")]
    [InlineData(15, "FizzBuzz!")]
    public void FizzString2_ReturnsExpected(int input, string expected)
    {
        Assert.Equal(expected, Program.FizzString2(input));
    }

    [Theory]
    [InlineData(1, 2, 3, true)]
    [InlineData(3, 1, 2, true)]
    [InlineData(3, 2, 2, false)]
    public void TwoAsOne_ReturnsExpected(int a, int b, int c, bool expected)
    {
        bool actual = Program.TwoAsOne(a, b, c);

        if (expected)
            Assert.True(actual);
        else
            Assert.False(actual);
    }

    [Theory]
    [InlineData(1, 2, 4, false, true)]
    [InlineData(1, 2, 1, false, false)]
    [InlineData(1, 1, 2, true, true)]
    public void InOrder_ReturnsExpected(int a, int b, int c, bool bOk, bool expected)
    {
        bool actual = Program.InOrder(a, b, c, bOk);

        if (expected)
            Assert.True(actual);
        else
            Assert.False(actual);
    }

    [Theory]
    [InlineData(2, 5, 11, false, true)]
    [InlineData(5, 7, 6, false, false)]
    [InlineData(5, 5, 7, true, true)]
    public void InOrderEqual_ReturnsExpected(int a, int b, int c, bool equalsOk, bool expected)
    {
        bool actual = Program.InOrderEqual(a, b, c, equalsOk);

        if (expected)
            Assert.True(actual);
        else
            Assert.False(actual);
    }

    [Theory]
    [InlineData(23, 19, 13, true)]
    [InlineData(23, 19, 12, false)]
    [InlineData(23, 19, 3, true)]
    public void LastDigit_ReturnsExpected(int a, int b, int c, bool expected)
    {
        bool exp = Program.LastDigit(a, b, c);

        if (expected)
            Assert.True(exp);
        else
            Assert.False(exp);
    }

    [Theory]
    [InlineData(1, 2, 11, true)]
    [InlineData(11, 2, 10, false)]
    [InlineData(10, 0, 2, true)]
    public void LessBy10_ReturnsExpected(int a, int b, int c, bool expected)
    {
        bool exp = Program.LessBy10(a, b, c);

        if (expected)
            Assert.True(exp);
        else
            Assert.False(exp);
    }

    [Theory]
    [InlineData(2, 3, true, 5)]
    [InlineData(3, 3, true, 7)]
    [InlineData(3, 3, false, 6)]
    public void WithoutDoubles_ReturnsExpected(int die1, int die2, bool noDoubles, int expected)
    {
        Assert.Equal(expected, Program.WithoutDoubles(die1, die2, noDoubles));
    }

    [Theory]
    [InlineData(2, 3, 3)]
    [InlineData(6, 2, 6)]
    [InlineData(3, 2, 3)]
    public void MaxMod5_ReturnsExpected(int a, int b, int expected)
    {
        Assert.Equal(expected, Program.MaxMod5(a, b));
    }

    [Theory]
    [InlineData(2, 2, 2, 10)]
    [InlineData(2, 2, 1, 0)]
    [InlineData(0, 0, 0, 5)]
    public void RedTicket_ReturnsExpected(int a, int b, int c, int expected)
    {
        Assert.Equal(expected, Program.RedTicket(a, b, c));
    }

    [Theory]
    [InlineData(1, 2, 3, 0)]
    [InlineData(2, 2, 2, 20)]
    [InlineData(1, 1, 2, 10)]
    public void GreenTicket_ReturnsExpected(int a, int b, int c, int expected)
    {
        Assert.Equal(expected, Program.GreenTicket(a, b, c));
    }

    [Theory]
    [InlineData(12, 23, true)]
    [InlineData(12, 43, false)]
    [InlineData(12, 44, false)]
    public void ShareDigit_ReturnsExpected(int a, int b, bool expected)
    {
        bool exp = Program.ShareDigit(a, b);

        if (expected)
            Assert.True(exp);
        else
            Assert.False(exp);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 13, 2 }, 6)]
    [InlineData(new int[] { 1, 1 }, 2)]
    [InlineData(new int[] { 1, 2, 13, 3, 2 }, 5)]
    public void Sum13_ReturnsExpected(int[] nums, int expected)
    {
        Assert.Equal(expected, Program.Sum13(nums));
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 100 }, 3)]
    [InlineData(new int[] { 1, 1, 5, 5, 10, 8, 7 }, 5)]
    [InlineData(new int[] { -10, -4, -2, -4, -2, 0 }, -3)]
    public void CenteredAverage_ReturnsExpected(int[] nums, int expected)
    {
        Assert.Equal(expected, Program.CenteredAverage(nums));
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 2 }, 5)]
    [InlineData(new int[] { 1, 2, 2, 6, 99, 99, 7 }, 5)]
    [InlineData(new int[] { 1, 1, 6, 7, 2 }, 4)]
    [InlineData(new int[] { 6, 7, 2 }, 2)]
    [InlineData(new int[] { 1, 6, 7, 6, 7 }, 1)]
    [InlineData(new int[] { 1, 6, 7, 2, 6, 99, 7 }, 3)]
    [InlineData(new int[] { 1, 6, 99, 7, 7 }, 8)]
    [InlineData(new int[] { 6, 7, 7 }, 7)]
    public void Sum67_ReturnsExcpected(int[] nums, int expected)
    {
        Assert.Equal(Program.Sum67(nums), expected);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 2 }, true)]
    [InlineData(new int[] { 1, 1, 2, 1, 5 }, false)]
    [InlineData(new int[] { 1, 1, 0 }, false)]
    public void Has22_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.Has22(nums));
        }
        else
        {
            Assert.False(Program.Has22(nums));
        }
    }

    [Theory]
    [InlineData(new int[] { 0, 2, 4 }, true)]
    [InlineData(new int[] { 1, 2, 3 }, false)]
    [InlineData(new int[] { 1, 2, 4 }, false)]
    public void Lucky13_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.Lucky13(nums));
        }
        else
        {
            Assert.False(Program.Lucky13(nums));
        }
    }

    [Theory]
    [InlineData(new int[] { 2, 3, 2, 2, 4, 2 }, true)]
    [InlineData(new int[] { 2, 3, 2, 2, 4, 2, 2 }, false)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    public void Sum28_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.Sum28(nums));
        }
        else
        {
            Assert.False(Program.Sum28(nums));
        }
    }

    [Theory]
    [InlineData(new int[] { 1, 4, 1 }, true)]
    [InlineData(new int[] { 1, 4, 1, 4 }, false)]
    [InlineData(new int[] { 1, 1 }, true)]
    public void More14_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.More14(nums));
        }
        else
        {
            Assert.False(Program.More14(nums));
        }
    }

    [Theory]
    [InlineData(4, new int[] { 0, 1, 2, 3 })]
    [InlineData(1, new int[] { 0 })]
    [InlineData(10, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    public void FizzArray_ReturnsExpected(int n, int[] expected)
    {
        Assert.Equal(Program.FizzArray(n), expected);
    }

    [Theory]
    [InlineData(new int[] { 1, 4, 1, 4 }, true)]
    [InlineData(new int[] { 1, 4, 2, 4 }, false)]
    [InlineData(new int[] { 1, 1 }, true)]
    public void Only14_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.Only14(nums));
        }
        else
        {
            Assert.False(Program.Only14(nums));
        }
    }
    
    [Theory]
    [InlineData(4, new string[] { "0", "1", "2", "3" })]
    [InlineData(1, new string[] { "0" })]
    [InlineData(10, new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" })]
    public void FizzArray2_ReturnsExpected(int n, string[] expected)
    {
        Assert.Equal(Program.FizzArray2(n), expected);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 2, 3, 4 }, true)]
    public void No14_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.No14(nums));
        }
        else
        {
            Assert.False(Program.No14(nums));
        }
    }
    
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 3 }, 1, true)]
    [InlineData(new int[] { 1, 2, 1, 3, 4 }, 2, false)]
    [InlineData(new int[] { 1, 2, 1, 3, 4 }, 1, false)]
    public void IsEverywhere_ReturnsExpected(int[] nums, int val, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.IsEverywhere(nums, val));
        }
        else
        {
            Assert.False(Program.IsEverywhere(nums, val));
        }
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 2 }, true)]
    [InlineData(new int[] { 4, 4, 1 }, true)]
    [InlineData(new int[] { 4, 4, 1, 1, 2, 2 }, false)]
    public void Either24_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.Either24(nums));
        }
        else
        {
            Assert.False(Program.Either24(nums));
        }
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[]{ 2, 3, 10 }, 2)]
    [InlineData(new int[] { 1, 2, 3 }, new int[]{ 2, 3, 5 }, 3)]
    [InlineData(new int[] { 1, 2, 3 }, new int[]{ 2, 3, 3 }, 2)]
    public void MatchUp_ReturnsExpected(int[] nums1, int[] nums2, int expected)
    {
        Assert.Equal(Program.MatchUp(nums1, nums2), expected);
    }

    [Theory]
    [InlineData(new int[] { 1, 7, 7 }, true)]
    [InlineData(new int[] { 1, 7, 1, 7 }, true)]
    [InlineData(new int[] { 1, 7, 1, 1, 7 }, false)]
    public void Has77_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.Has77(nums));
        }
        else
        {
            Assert.False(Program.Has77(nums));
        }
    }

    [Theory]
    [InlineData(new int[] { 1, 3, 2 }, true)]
    [InlineData(new int[] { 1, 3, 1, 2 }, true)]
    [InlineData(new int[] { 1, 3, 4, 2, 5 }, true)]
    [InlineData(new int[] { 1 }, false)]
    public void Has12_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.Has12(nums));
        }
        else
        {
            Assert.False(Program.Has12(nums));
        }
    }

    [Theory]
    [InlineData(new int[] { 2, 1, 3, 5 }, true)]
    [InlineData(new int[] { 2, 1, 2, 5 }, false)]
    [InlineData(new int[] { 2, 4, 2, 5 }, true)]
    public void ModThree_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.ModThree(nums));
        }
        else
        {
            Assert.False(Program.ModThree(nums));
        }
    }

    [Theory]
    [InlineData(new int[] { 3, 1, 3, 1, 3 }, true)]
    [InlineData(new int[] { 3, 1, 3, 3 }, false)]
    [InlineData(new int[] { 3, 4, 3, 3, 4 }, false)]
    public void HaveThree_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.HaveThree(nums));
        }
        else
        {
            Assert.False(Program.HaveThree(nums));
        }
    }

    [Theory]
    [InlineData(new int[] { 4, 2, 2, 3 }, true)]
    [InlineData(new int[] { 2, 2, 4 }, true)]
    [InlineData(new int[] { 2, 2, 4, 2 }, false)]
    public void TwoTwo_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.TwoTwo(nums));
        }
        else
        {
            Assert.False(Program.TwoTwo(nums));
        }
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1, 2 }, 1, false)]
    [InlineData(new int[] { 1, 2, 3, 1, 2 }, 2, true)]
    [InlineData(new int[] { 1, 2, 3, 1, 2 }, 3, false)]
    public void SameEnds_ReturnsExpected(int[] nums, int len, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.SameEnds(nums, len));
        }
        else
        {
            Assert.False(Program.SameEnds(nums, len));
        }
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1, 2 }, true)]
    [InlineData(new int[] { 1, 2, 3 }, true)]
    [InlineData(new int[] { 1, 2, 4 }, false)]
    public void TripleUp_ReturnsExpected(int[] nums, bool expected)
    {
        if (expected)
        {
            Assert.True(Program.TripleUp(nums));
        }
        else
        {
            Assert.False(Program.TripleUp(nums));
        }
    }
}
