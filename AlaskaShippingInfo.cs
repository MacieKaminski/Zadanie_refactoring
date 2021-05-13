namespace Zadanie_refactoring
{
	public class AlaskaShippingInfo : StateShippingInfo
	{
		public override decimal ShippingAmount()
		{
			return 15m;
		}

	}
}
