using System;
namespace TemplateMethodPattern
{
	public abstract class CaffeineBeverage
	{
		// Template Method
		public void PrepareRecipe()
		{
			BoilWater();
			Brew();
			PourInCup();
			// Hook
			if(CustomerWantsCondiments())
			{
                AddCondiments();
            }
		}

		public abstract void Brew();
		public abstract void AddCondiments();

		public void BoilWater()
		{
			Console.WriteLine("Boiling water");
		}

		public void PourInCup()
		{
			Console.WriteLine("Pouring into cup");
		}

		// Hook method
		public virtual bool CustomerWantsCondiments()
		{
			return true;
		}

	}
}

