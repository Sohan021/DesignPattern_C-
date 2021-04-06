using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            CreditCard card = new PlatinumFactory().CreateProduct();
            if (card != null)
            {
                Console.WriteLine("Card Type : " + card.GetCardType());
                Console.WriteLine("Credit Limit : " + card.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + card.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }


            Console.WriteLine("--------------");


            card = new MoneyBackFactory().CreateProduct();
            if (card != null)
            {
                Console.WriteLine("Card Type : " + card.GetCardType());
                Console.WriteLine("Credit Limit : " + card.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + card.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();

        }
    }
}
