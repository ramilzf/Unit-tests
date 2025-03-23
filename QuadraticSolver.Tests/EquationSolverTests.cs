using Xunit;
using QuadraticSolver;

namespace QuadraticSolver.Tests
{
    public class EquationSolverTests
    {
        [Theory]
        [InlineData(1, 0, 1, 0)]   // No real roots
        [InlineData(1, 2, 1, 1)]   // One root
        [InlineData(1, -3, 2, 2)]  // Two roots
        public void TestRootCounts(double a, double b, double c, int expected)
        {
            var result = EquationSolver.Solve(a, b, c);
            Assert.Equal(expected, result.Length);
        }

        [Fact]
        public void TestExactRoots()
        {
            var result = EquationSolver.Solve(1, -3, 2); // roots: 1 and 2
            Assert.Contains(1, result);
            Assert.Contains(2, result);
        }
    }
}
