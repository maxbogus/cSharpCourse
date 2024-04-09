using System;

namespace NumericAnalysis;

public class IntegralCalculus
{
    public static double Calculate(Func<double, double> func, double x1, double x2, double precision)
    {
        double y1 = func(x1);
        double y2 = func(x2);

        throw new NotImplementedException();
    }
}
