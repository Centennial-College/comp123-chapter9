using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerDemo
{
    class Taxpayer
    {
        private double _yearlyGrossIncome;
        private double _incomeTaxOwed;

        public string SocialSecurityNumber { get; set; }
        public double YearlyGrossIncome
        {
            get
            {
                return this._yearlyGrossIncome;
            }
            set
            {
                this._yearlyGrossIncome = value;
                if (this.YearlyGrossIncome < 30000)
                {
                    this._incomeTaxOwed = this.YearlyGrossIncome * .15;
                }
                else
                {
                    this._incomeTaxOwed = this.YearlyGrossIncome * .28;
                }
            }
        }
        public double IncomeTaxOwed
        {
            get
            {
                return this._incomeTaxOwed;
            }
        }

        public Taxpayer(string ssn, double income)
        {
            this.SocialSecurityNumber = ssn;
            this.YearlyGrossIncome = income;
        }

        public override string ToString()
        {
            return string.Format("Social Security Number: {0}\nIncome: {1:C}\nTax Owing: {2:C}",
                this.SocialSecurityNumber, this.YearlyGrossIncome, this.IncomeTaxOwed);
        }

    }
}
