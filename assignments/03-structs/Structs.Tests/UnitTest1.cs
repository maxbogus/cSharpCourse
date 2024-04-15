using System;
using Xunit;
using Structs;


namespace Structs {
    public struct Meter {
        public double Value { get; set; }

        public Meter(double val) {
            Value = val;
        }

        public static Meter operator +(Meter Value) => Value;
        public static Meter operator -(Meter Value) => new Meter(-Value.Value);

        public static Meter operator +(Meter a, Meter b)
            => new Meter(a.Value + b.Value);

        public static Meter operator -(Meter a, Meter b)
            => a + (-b);

        public static Meter operator *(Meter a, Meter b)
            => new Meter(a.Value * b.Value);

        public static Meter operator /(Meter a, Meter b)
        {
            return new Meter(a.Value / b.Value);
        }

        public static implicit operator int(Meter d) => (int)d.Value;
        public static implicit operator double(Meter d) => d.Value;
        public static explicit operator Meter(int b) => new Meter((double)b);
        public static explicit operator Meter(double b) => new Meter(b);
        public static explicit operator Meter(Inch b) => new Meter(b*2.54);

        public override string ToString() => $"{Value}";
        public override int GetHashCode() => Value.GetHashCode();
        public override bool Equals(object obj) {
            if (obj is Meter testMeter) {
                return Value == testMeter.Value * 0.0254;
            }

            if (obj is Inch testInch) {
                return Value == testInch.Value;
            }

            return false;
        }
    }

    public struct Inch {
        public double Value { get; set; }

        public Inch(double val) {
            Value = val;
        }

        public static Inch operator +(Inch Value) => Value;
        public static Inch operator -(Inch Value) => new Inch(-Value.Value);

        public static Inch operator +(Inch a, Inch b)
            => new Inch(a.Value + b.Value);

        public static Inch operator -(Inch a, Inch b)
            => a + (-b);

        public static Inch operator *(Inch a, Inch b)
            => new Inch(a.Value * b.Value);

        public static Inch operator /(Inch a, Inch b)
        {
            return new Inch(a.Value / b.Value);
        }

        public static implicit operator int(Inch d) => (int)d.Value;
        public static implicit operator double(Inch d) => d.Value;
        public static explicit operator Inch(int b) => new Inch((double)b);
        public static explicit operator Inch(double b) => new Inch(b);
        public static explicit operator Inch(Meter b) => new Inch(b*0.393701);

        public override string ToString() => $"{Value}";
        public override int GetHashCode() => Value.GetHashCode();
        public override bool Equals(object obj) {
            if (obj is Meter testMeter) {
                return Value == testMeter.Value * 0.0254;
            }

            if (obj is Inch testInch) {
                return Value == testInch.Value;
            }

            return false;
        }
    }

    public class UnitTests
    {
        [Fact(DisplayName = "Works Meter to Meter")]
        public void Test1()
        {
                Meter a = new Meter(2.0);
                Assert.Equal("2", a.ToString());
                Meter b = new Meter(-2.0);
                Assert.Equal("-2", b.ToString());
                Meter actual = -a;
                Assert.Equal("-2", actual.ToString());
                actual = a-b;
                Assert.Equal("4", actual.ToString());
                actual = a+b;
                Assert.Equal("0", actual.ToString());
                actual = b-a;
                Assert.Equal("-4", actual.ToString());
                actual = b*a;
                Assert.Equal("-4", actual.ToString());
                actual = b/a;
                Assert.Equal("-1", actual.ToString());
        }

        [Fact(DisplayName = "Works Meter to Inch")]
        public void Test2()
        {
                Meter a = new Meter(2.0);
                Assert.Equal("2", a.ToString());
                Inch b = new Inch(-2.0);
                Assert.Equal("-2", b.ToString());
                Meter actual = -a;
                Assert.Equal("-2", actual.ToString());
                actual = a-(Meter)b;
                Assert.Equal("7.08", actual.ToString());
                actual = a+(Meter)b;
                Assert.Equal("-3.08", actual.ToString());
                actual = (Meter)b-a;
                Assert.Equal("-7.08", actual.ToString());
                actual = (Meter)b*a;
                Assert.Equal("-10.16", actual.ToString());
                actual = (Meter)b/a;
                Assert.Equal("-2.54", actual.ToString());
        }

        [Fact(DisplayName = "Works Double to Meter")]
        public void Test3()
        {
                double a = new Meter(2.0);
                Assert.Equal("2", a.ToString());
                Meter b = new Meter(-2.0);
                Assert.Equal("-2", b.ToString());
                Meter actual = -(Meter)a;
                Assert.Equal("-2", actual.ToString());
                actual = (Meter)a-b;
                Assert.Equal("4", actual.ToString());
                actual = (Meter)a+b;
                Assert.Equal("0", actual.ToString());
                actual = b-(Meter)a;
                Assert.Equal("-4", actual.ToString());
                actual = b*(Meter)a;
                Assert.Equal("-4", actual.ToString());
                actual = b/(Meter)a;
                Assert.Equal("-1", actual.ToString());

        }

        [Fact(DisplayName = "Works Inch to Inch")]
        public void Test4()
        {
                Inch a = new Inch(2.0);
                Assert.Equal("2", a.ToString());
                Inch b = new Inch(-2.0);
                Assert.Equal("-2", b.ToString());
                Inch actual = -a;
                Assert.Equal("-2", actual.ToString());
                actual = a-b;
                Assert.Equal("4", actual.ToString());
                actual = a+b;
                Assert.Equal("0", actual.ToString());
                actual = b-a;
                Assert.Equal("-4", actual.ToString());
                actual = b*a;
                Assert.Equal("-4", actual.ToString());
                actual = b/a;
                Assert.Equal("-1", actual.ToString());

        }

        [Fact(DisplayName = "Works Inch to Meter")]
        public void Test5()
        {
                Inch a = new Inch(2.0);
                Assert.Equal("2", a.ToString());
                Meter b = new Meter(-2.0);
                Assert.Equal("-2", b.ToString());
                Meter actual = -(Meter)a;
                Assert.Equal("-5.08", actual.ToString());
                actual = (Meter)a-b;
                Assert.Equal("7.08", actual.ToString());
                actual = (Meter)a+b;
                Assert.Equal("3.08", actual.ToString());
                actual = b-(Meter)a;
                Assert.Equal("-7.08", actual.ToString());
                actual = b*(Meter)a;
                Assert.Equal("-10.16", actual.ToString());
                actual = b/(Meter)a;
                Assert.Equal("-0.39370078740157477", actual.ToString());

        }

        [Fact(DisplayName = "Works Double to Inch")]
        public void Test6()
        {
                Inch a = new Inch(2.0);
                Assert.Equal("2", a.ToString());
                double b = -2.0;
                Assert.Equal("-2", b.ToString());
                Inch actual = -a;
                Assert.Equal("-2", actual.ToString());
                actual = a-(Inch)b;
                Assert.Equal("4", actual.ToString());
                actual = a+(Inch)b;
                Assert.Equal("0", actual.ToString());
                actual = (Inch)b-a;
                Assert.Equal("-4", actual.ToString());
                actual = (Inch)b*a;
                Assert.Equal("-4", actual.ToString());
                actual = (Inch)b/a;
                Assert.Equal("-1", actual.ToString());

        }
    }
}