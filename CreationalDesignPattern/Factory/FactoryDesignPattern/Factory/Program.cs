using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardName = Console.ReadLine();

            CreditCard card = CreditCardFactory.GetCreditCard(cardName);

            if (card != null)
            {
                Console.WriteLine("CardType : " + card.GetCardType());
                Console.WriteLine("CreditLimit : " + card.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + card.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();

        }
    }
}
