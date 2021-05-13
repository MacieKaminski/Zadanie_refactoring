namespace Zadanie_refactoring
{
	public class ShippingInfo
	{
		private StateShippingInfo getShippingInfo(State shipToState)
		{
			switch (shipToState)
			{
				case State.Alaska:
					return new AlaskaShippingInfo();
				case State.NewYork:
					return new NewYorkShippingInfo();
				case State.Florida:
					return new FloridaShippingInfo();
				default:
					return null;
			}
		}

		public decimal CalculateShippingAmount(State shipToState)
        {
			StateShippingInfo stateShippingInfo = getShippingInfo(shipToState);
			return stateShippingInfo.ShippingAmount();
        }
	}
}
