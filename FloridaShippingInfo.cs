namespace Zadanie_refactoring
{
    public class FloridaShippingInfo : StateShippingInfo
    {
        public override decimal ShippingAmount()
        {
            return 3m;
        }
    }
}
