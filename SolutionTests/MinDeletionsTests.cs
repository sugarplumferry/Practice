using LeetCodeConsole.inteface;
using Microsoft.Extensions.DependencyInjection;

namespace SolutionTests;

public class MinDeletionsTests
{
    private readonly ISolution _solution;

    public MinDeletionsTests()
    {
        var serviceProvider = TestStartup.ConfigureServices();
        _solution = serviceProvider.GetRequiredService<ISolution>();
    }

    [Fact]
    public void NoDeletionsNeeded()
    {
        // Arrange
        string input = "aab";

        // Act
        int deletions = _solution.MinDeletions(input);

        // Assert
        Assert.Equal(0, deletions);
    }

    [Fact]
    public void TwoDeletionsNeeded()
    {
        // Arrange
        string input = "aaabbbcc";

        // Act
        int deletions = _solution.MinDeletions(input);

        // Assert
        Assert.Equal(2, deletions);
    }

    // Add more test cases to cover various scenarios and edge cases
}