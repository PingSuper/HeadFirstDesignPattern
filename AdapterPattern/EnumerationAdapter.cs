using System;
using AdapterPattern.Adaptee;
using AdapterPattern.Target;

namespace AdapterPattern
{
	public class EnumerationAdapter: IIterator
    {
        private readonly IEnumeration enumeration;

        public EnumerationAdapter(IEnumeration enumeration)
		{
            this.enumeration = enumeration;
        }

        public bool HasNext()
        {
            return enumeration.HasMoreElements();
        }

        public object Next()
        {
            return enumeration.NextElement();
        }

        public void Remove()
        {
            throw new NotSupportedException();
        }
    }
}

