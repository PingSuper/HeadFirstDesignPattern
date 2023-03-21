using System;
namespace FactoryMethodPattern.Products
{
	public class PepperoniPizza : Pizza
    {
		public PepperoniPizza()
		{
		}

        public override void Bake()
        {
            Console.WriteLine("Bake Pepperoni Pizza...");
        }

        public override void Box()
        {
            Console.WriteLine("Box Pepperoni Pizza..."); ;
        }

        public override void Cut()
        {
            Console.WriteLine("Cut Pepperoni Pizza...");
        }

        public override void Prepare()
        {
            Console.WriteLine("Prepare Pepperoni Pizza...");
        }
    }
}

