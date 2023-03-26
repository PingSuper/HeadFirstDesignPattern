using System;
namespace AdapterPattern.Target
{
	public interface IIterator
	{
		bool HasNext();
		Object Next();
		void Remove();
	}
}

