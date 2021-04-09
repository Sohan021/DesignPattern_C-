namespace FactoryMethodDesignPattern
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard card = new Platinum();
            return card;
        }


    }
}
