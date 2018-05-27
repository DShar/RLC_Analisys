using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLC_Analysis.Model
{
    public class Complex
    {
        private double Re, Im;

        public Complex()
        {
            this.Re = 0;
            this.Im = 0;
        }
        public Complex(double a, double b)
        {
            this.Re = a;
            this.Im = b;
        }

        public Complex(Complex a)
        {
            this.Re = a.Real();
            this.Im = a.Imaginary();
        }

        public double Real()
        {
            return this.Re;
        }

        public double Imaginary()
        {
            return this.Im;
        }

        public static Complex Sum(Complex a, Complex b)
        {
            Complex sum = new Complex();
            sum.Re = a.Re + b.Re;
            sum.Im = a.Im + b.Im;
            return (sum);
        }
        public static Complex Sum(Complex a, Complex b, Complex c)
        {
            Complex sum = new Complex();
            sum.Re = a.Re + b.Re + c.Re;
            sum.Im = a.Im + b.Im + c.Im;
            return (sum);
        }

        public static Complex Subtruct(Complex a, Complex b)
        {
            Complex sub = new Complex();
            sub.Re = a.Re - b.Re;
            sub.Im = a.Im - b.Im;
            return (sub);
        }

        public static Complex Multiplication(Complex a, Complex b)
        {
            Complex mul = new Complex();
            mul.Re = a.Re * b.Re - a.Im * b.Im;
            mul.Im = a.Re * b.Im + a.Im * b.Re;
            return (mul);
        }

        public static double SqrAbs(Complex a)
        {
            double sAbs;
            sAbs = a.Re * a.Re + a.Im * a.Im;
            return (sAbs);
        }

        public static double Abs(Complex a)
        {
            double abs;
            abs = System.Math.Sqrt(Complex.SqrAbs(a));
            return (abs);
        }

        //Перегрузка операторов
        public static Complex operator ~(Complex a) { return new Complex(a.Re, -a.Im); }
        public static Complex operator !(Complex a) { return ~a; }
        public static Complex operator +(Complex a, double b) { return new Complex(a.Re + b, a.Im); }
        public static Complex operator +(Complex a, Complex b) { return Complex.Sum(a, b); }
        public static Complex operator -(Complex a, double b) { return new Complex(a.Re - b, a.Im); }
        public static Complex operator -(Complex a, Complex b) { return Complex.Subtruct(a, b); }
        public static Complex operator *(Complex a, double b) { return new Complex(a.Re * b, a.Im * b); }
        public static Complex operator *(Complex a, Complex b) { return Complex.Multiplication(a, b); }
        public static Complex operator /(Complex a, double b) { return new Complex(a.Re / b, a.Im / b); }
        public static Complex operator /(Complex a, Complex b) { return (a * ~b / Complex.SqrAbs(b)); }


        public override string ToString()
        {
            return this.Re.ToString() + (this.Im < 0 ? " " : " + ") + this.Im.ToString() + 'i';
        }
    }
}
