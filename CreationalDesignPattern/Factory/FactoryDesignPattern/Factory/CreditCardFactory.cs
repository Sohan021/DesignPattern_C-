namespace Factory
{
    class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard card = null;

            if (cardType == "MoneyBack")
                card = new MoneyBack();
            else if (cardType == "Titanium")
                card = new Titanium();
            else if (cardType == "Platinum")
                card = new Platinum();

            return card;
        }
    }
}
