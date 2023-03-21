using System;
namespace FactoryMethodPattern.Products
{
	public abstract class Pizza
	{
		public Pizza()
		{
		}

		public abstract void Prepare();
		public abstract void Bake();
		public abstract void Cut();
		public abstract void Box();

    }
}

