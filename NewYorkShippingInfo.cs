namespace Zadanie_refactoring
{
    public class NewYorkShippingInfo : StateShippingInfo
    {
        public override decimal ShippingAmount()
        {
            return 10m;
        }
    }
}
