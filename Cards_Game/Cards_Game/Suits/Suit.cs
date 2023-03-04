using System;
namespace lesson6.Suits
{
	public abstract class Suit
	{
		public string Symbol { get; set; }

		public bool IsTrump { get; set; }

		public abstract void setSymbol();
	}
}

