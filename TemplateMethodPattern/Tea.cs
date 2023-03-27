using System;
namespace TemplateMethodPattern
{
	public class Tea : CaffeineBeverage
	{
		public Tea()
		{
		}

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}

