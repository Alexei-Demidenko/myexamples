using System.Collections.Generic;

namespace Head_12_Generic_Type
{
    internal class ClassExample<T>
    {
        private readonly List<T> ListValue = new() { };
		public void AddValue(T value)
        {
            ListValue.Add(value);
		}
        public List<T> GetListValue => ListValue;
    }
}
