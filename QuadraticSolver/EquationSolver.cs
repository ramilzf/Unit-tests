using System;

namespace QuadraticSolver
{
    public class EquationSolver
    {
        public static double[] Solve(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                return new double[0]; // No real roots

            if (discriminant == 0)
                return new double[] { -b / (2 * a) }; // One root

            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            return new double[] { root1, root2 };
        }
    }
}
