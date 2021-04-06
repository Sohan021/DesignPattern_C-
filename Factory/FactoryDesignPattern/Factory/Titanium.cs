namespace Factory
{
    class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public int GetCreditLimit()
        {
            return 25000;
        }

        public string GetCardType()
        {
            return "Titanium Edge";
        }
    }
}
