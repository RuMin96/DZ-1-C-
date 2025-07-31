using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_C_
{
    internal class Complex : IComparable<Complex>
    {
        private double re, im;

        public double Re
        {
            get => re;
            set => re = value;
        }

        public double Im
        {
            get => im;
            set => im = value;
        }

        public double this[string part]
        {
            get
            {
                if (part == "Re") return re;
                if (part == "Im") return im;
                throw new ArgumentException("Use 'Re' or 'Im'");
            }
            set
            {
                if (part == "Re") re = value;
                else if (part == "Im") im = value;
                else throw new ArgumentException("Use'Re'or'Im'");
            }
        }

        public Complex(double re = 0, double im = 0)
        {
            this.re = re;
            this.im = im;
        }

        public static Complex operator +(Complex a, Complex b) => new Complex(a.re + b.re, a.im + b.im);
        public static Complex operator +(Complex a, double b) => new Complex(a.re + b, a.im);
        public static Complex operator +(double a, Complex b) => b + a;

        public static Complex operator -(Complex a, Complex b) => new Complex(a.re - b.re, a.im - b.im);
        public static Complex operator -(Complex a, double b) => new Complex(a.re - b, a.im);
        public static Complex operator -(double a, Complex b) => new Complex(a - b.re, -b.im);

        public static Complex operator *(Complex a, Complex b) => new Complex(a.re * b.re - a.im * b.im, a.re * b.im + a.im * b.re);
        public static Complex operator *(Complex a, double b) => new Complex(a.re * b, a.im * b);
        public static Complex operator *(double a, Complex b) => b * a;

        public static Complex operator /(Complex a, Complex b)
        {
            double denominator = b.re * b.re + b.im * b.im;
            if (denominator == 0) throw new DivideByZeroException();
            return new Complex((a.re * b.re + a.im * b.im) / denominator, (a.im * b.re - a.re * b.im) / denominator);
        }

        public static Complex operator /(Complex a,double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return new Complex(a.re / b, a.im / b);
        }

        public static Complex operator /(double a,Complex b)
        {
            double denominator = b.re*b.re+ b.im*b.im;
            if (denominator == 0) throw new DivideByZeroException();
            return new Complex((a*b.re)/denominator, (-a*b.im)/denominator);
        }

        public static Complex operator -(Complex a) => new Complex(-a.re, -a.im);

        public static Complex operator ++(Complex a) => new Complex(a.re + 1, a.im);

        public static Complex operator --(Complex a) => new Complex(a.re - 1, a.im);

        public double Abs() => Math.Sqrt(re * re + im * im);

        public override bool Equals(object obj)
        {
            if(obj is Complex c)
                return re == c.re&& im == c.im;
            return false;
        }

        public override int GetHashCode()=>re.GetHashCode()^im.GetHashCode();
        public int CompareTo(Complex other)
        { 
            return this.Abs().CompareTo(other.Abs());
        }

        public override string ToString()
        {
            if (im == 0) return $"{re}";
            if (re == 0) return $"{im}i";
            if (im < 0) return $"{re}-{-im}i";
            return $"{re}+{im}i";
        }
    }
}
