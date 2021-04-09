namespace Factory
{
    class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public int GetCreditLimit()
        {
            return 15000;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }
    }
}
