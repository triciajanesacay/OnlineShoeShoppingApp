using System;

namespace OnlineShoeShopping.BL
{
    public class CostumerInventory
    {
        public void Catalogue()
        {
            ProductControl productServices = new ProductControl();

        START:
            Console.WriteLine("(1) Item View");
            Console.WriteLine("(2) Item Add");
            Console.WriteLine("(3) Item Removed");
            Console.WriteLine("(4) exit");
            int costumerInput = int.Parse(Console.ReadLine());
            switch (costumerInput)
            {
                case 1:
                    productServices.ProductView();
                    goto START;
                case 2:
                    productServices.ProductAdd();
                    goto START;
                case 3:
                    productServices.ProductRemoved();
                    goto START;

                default:
                    break;
            }

        }
    }
}