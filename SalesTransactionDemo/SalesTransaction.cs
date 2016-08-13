using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemo
{
    class SalesTransaction
    {
        private string _salespersonName;
        private double _salesAmt;
        private readonly double _commision;

        public SalesTransaction(string name, double salesAmt, double commRate)
        {
            this._salespersonName = name;
            this._salesAmt = salesAmt;
            this._commision = salesAmt * commRate;
        }

        public SalesTransaction(string name, double salesAmt) : this(name, salesAmt, 0)
        {
        }

        public SalesTransaction(string name) : this(name, 0, 0)
        {
        }

        public static double operator +(SalesTransaction s1, SalesTransaction s2)
        {
            return s1._salesAmt + s2._salesAmt;
        }

        public override string ToString()
        {
            return string.Format("Salesperson Name: {0}\nSales Amount: {1:C}\nCommision: {2:C}",
                this._salespersonName, this._salesAmt, this._commision);
        }
    }
}
