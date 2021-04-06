namespace FactoryMethodDesignPattern
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard card = new Titanium();
            return card;
        }
    }
}
