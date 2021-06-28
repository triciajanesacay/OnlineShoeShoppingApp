using OnlineShoeShopping.DL;
using System;
using System.Collections.Generic;

namespace OnlineShoeShopping.BL
{
    public class CustomerAuthentication
    {
        public List<Costumer> CostumerCredentials = new List<Costumer>()
        {
            new Costumer("Tricia","Jane")
        };

        public void LogIn()
        {
            CostumerInventory catalogue = new CostumerInventory();
            bool successful = false;
            Console.WriteLine("Enter Email:");
            string costumerName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();

            foreach (Costumer user in CostumerCredentials)
            {
                if (costumerName == user.Email && passWord == user.PassWord)
                {
                    Console.WriteLine("Log in Success");
                    successful = true;
                    catalogue.Catalogue();
                }
            }
            if (!successful)
            {
                Console.WriteLine("Operation Cease...");
            }
        }
        public void Register()
        {
            Console.WriteLine("Enter Email: ");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string passWord = Console.ReadLine();

            CostumerCredentials.Add(new Costumer(Email, passWord));
            Console.WriteLine("Registered Successfully!");

            foreach (Costumer costumer in CostumerCredentials)
            {
                Console.WriteLine("Username:{0}, Passw:{1}", costumer.Email, costumer.PassWord);
            }

        }
    }
}