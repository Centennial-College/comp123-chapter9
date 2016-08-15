using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionDemo
{
    class Fraction
    {
        private int _wholeNumber;
        private int _numerator;
        private int _denominator;

        public Fraction(int whole, int num, int denom)
        {
            this.WholeNumber = whole;
            this.Numerator = num;
            this.Denominator = denom;
        }

        public Fraction(int num, int denom) : this(0, num, denom)
        {
        }

        public Fraction() : this(0, 0, 1)
        {
        }

        public int WholeNumber
        {
            get
            {
                return this._wholeNumber;
            }
            set
            {
                this._wholeNumber = value;
            }
        }
        public int Numerator
        {
            get
            {
                return this._numerator;
            }
            set
            {
                this._numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return this._denominator;
            }
            set
            {
                if (value == 0)
                    this._denominator = 1;
                else
                    this._denominator = value;
            }
        }

        private int _gcf()
        {
            int gcf = 1;
            int largerNum = Math.Max(this.Numerator, this.Denominator);

            for (int i = 2; i <= largerNum; i++)
            {
                // keep updating gcf with bigger and bigger matching values
                if (this.Numerator % i == 0 && this.Denominator % i == 0)
                    gcf = i;
            }

            return gcf;
        }

        private static int _lcd(int d1, int d2)
        {
            int lcd = 1;
            int checkUpTo = d1 * d2;

            for (int i = 2; i <= checkUpTo; i++)
            {
                // once you find a value that matches, break, don't go searching bigger ones
                if (i % d1 == 0 && i % d2 == 0)
                {
                    lcd = i;
                    break;
                }
            }
            return lcd;
        }

        public void Reduce()
        {
            int gcf;

            if (this.Numerator > this.Denominator)
            {
                this.WholeNumber += this.Numerator / this.Denominator;
                this.Numerator %= this.Denominator;
            }

            gcf = this._gcf();

            this.Numerator /= gcf;
            this.Denominator /= gcf;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction firstFrac = new Fraction(f1.WholeNumber, f1.Numerator, f1.Denominator);
            Fraction secondFrac = new Fraction(f2.WholeNumber, f2.Numerator, f2.Denominator);
            Fraction result;
            int newNum;
            int newDen;

            // eliminate any whole number part of the value
            if (firstFrac.WholeNumber != 0)
            {
                firstFrac.Numerator += firstFrac.WholeNumber * firstFrac.Denominator;
                firstFrac.WholeNumber = 0;
            }
            if (secondFrac.WholeNumber != 0)
            {
                secondFrac.Numerator += secondFrac.WholeNumber * secondFrac.Denominator;
                secondFrac.WholeNumber = 0;
            }

            // find common denominator and convert fractions to it
            int lcd = _lcd(firstFrac.Denominator, secondFrac.Denominator);
            firstFrac.Numerator *= (lcd / firstFrac.Denominator);
            secondFrac.Numerator *= (lcd / secondFrac.Denominator);

            newDen = lcd;

            // add the numerators
            newNum = firstFrac.Numerator + secondFrac.Numerator;

            result = new Fraction(newNum, newDen);

            result.Reduce();

            return result;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction firstFrac = new Fraction(f1.WholeNumber, f1.Numerator, f1.Denominator);
            Fraction secondFrac = new Fraction(f2.WholeNumber, f2.Numerator, f2.Denominator);
            Fraction result;
            int newNum;
            int newDen;

            // eliminate any whole number part of the value
            if (firstFrac.WholeNumber != 0)
            {
                firstFrac.Numerator += firstFrac.WholeNumber * firstFrac.Denominator;
                firstFrac.WholeNumber = 0;
            }
            if (secondFrac.WholeNumber != 0)
            {
                secondFrac.Numerator += secondFrac.WholeNumber * secondFrac.Denominator;
                secondFrac.WholeNumber = 0;
            }

            newNum = firstFrac.Numerator * secondFrac.Numerator;
            newDen = firstFrac.Denominator * secondFrac.Denominator;

            result = new Fraction(newNum, newDen);

            result.Reduce();

            return result;
        }

        public override string ToString()
        {
            if (this.Numerator == 0)
                return string.Format("{0}", this.WholeNumber);
            else if (this.WholeNumber != 0)
                return string.Format("{0} {1}/{2}",
                    this.WholeNumber, this.Numerator, this.Denominator);
            else
                return string.Format("{0}/{1}",
                    this.Numerator, this.Denominator);
        }
    }
}
