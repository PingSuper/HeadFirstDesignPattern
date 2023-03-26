using System;
namespace AdapterPattern.Adaptee
{
	public interface IEnumeration
	{
		bool HasMoreElements();
		object NextElement();
	}
}

