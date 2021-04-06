namespace Factory
{
    class Platinum : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public int GetCreditLimit()
        {
            return 35000;
        }

        public string GetCardType()
        {
            return "Platinum Plus";
        }
    }
}
