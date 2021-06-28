using System;
namespace OnlineShoeShopping.DL
{
    public class ProductDetails
    {
        public string shoeBrand;
        private string price;
        private DateTime date;

        public ProductDetails(string shoetBrand, string price, DateTime date)
        {
            this.shoeBrand = shoetBrand;
            this.price = price;
            this.date = date;
        }

        public string ShoetBrand
        {
            get { return shoeBrand; }
            set { shoeBrand = value; }
        }


        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


    }
}