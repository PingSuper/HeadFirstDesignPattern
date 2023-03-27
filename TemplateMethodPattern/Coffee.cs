using System;
namespace TemplateMethodPattern
{
	public class Coffee: CaffeineBeverage
	{
		public Coffee()
		{
		}

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}

