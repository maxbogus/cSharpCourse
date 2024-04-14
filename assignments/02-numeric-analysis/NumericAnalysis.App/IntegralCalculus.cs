using System;

namespace NumericAnalysis;

public class IntegralCalculus
{
    private static double IntegralCalculate(Func<double, double> f, double a, double b, int n) {
        double hStep = (b - a) / n;
        double sum = 0.5*(f(a) + f(b));
        for (int i = 1; i < n; ++i) {
            double x = a+i*hStep;
            sum += f(x);
        }
        return sum * hStep;
    }

    public static double Calculate(Func<double, double> func, double x1, double x2, double precision)
    {
        bool shouldExit = false;
        double steps = 1.0;

        while (!shouldExit) {
            if (((x2 - x1) / steps) <= precision) {
                shouldExit = true;
            } else {
                steps *= 2;
            }
        }

        return IntegralCalculate(func, x1, x2, (int)steps);
    }
}
