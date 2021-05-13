using System;

namespace Zadanie_refactoring
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine(new ClientCode().CalculateShipping());
		}

		public class ClientCode
		{
			public decimal CalculateShipping()
			{
				ShippingInfo shippingInfo = new ShippingInfo();
				return shippingInfo.CalculateShippingAmount(State.Alaska);
			}
		}
	}
}
