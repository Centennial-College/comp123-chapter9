using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    class ClassifiedAd
    {
        private string _category;
        private int _numberOfWords;
        private double _price;

        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }

        public int NumberOfWords
        {
            get
            {
                return this._numberOfWords;
            }
            set
            {
                this._numberOfWords = value;
                this._price = 0.09 * this.NumberOfWords;
            }
        }

        public double Price
        {
            get
            {
                return this._price;
            }
        }

        public ClassifiedAd(string category, int numWords)
        {
            this.Category = category;
            this.NumberOfWords = numWords;
        }

        public override string ToString()
        {
            return string.Format("Category: {0}\nNumber of Words: {1}\nPrice: {2:C}",
                this.Category, this.NumberOfWords, this.Price);
        }
    }
}
