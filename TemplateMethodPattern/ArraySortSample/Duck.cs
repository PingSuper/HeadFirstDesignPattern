using System;
namespace TemplateMethodPattern.ArraySortSample
{
	public class Duck : IComparable
	{
        private readonly string name;
        private readonly int weight;

        public Duck(string name, int weight)
		{
            this.name = name;
            this.weight = weight;
        }

        public override string ToString()
        {
            return name + " weights " + weight;
        }

        // override the Template Method CompareTo step
        public int CompareTo(object? obj)
        {
            Duck otherDuck = (Duck)obj;

            if(this.weight < otherDuck.weight) {
                return -1;
            }
            else if (this.weight == otherDuck.weight) {
                return 0;
            }
            else {
                return 1;
            }
        }


    }
}

