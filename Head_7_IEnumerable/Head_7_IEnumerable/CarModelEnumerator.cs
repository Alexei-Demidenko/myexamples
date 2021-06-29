using System;
using System.Collections;

namespace Head_7_IEnumerable
{
    internal class CarModelEnumerator : IEnumerator
    {
        private readonly string[] Model;
        private int position = -1;
        public CarModelEnumerator(string[] model)
        {
            Model = model;
        }
        public object Current
        {
            get
            {
                if (position == -1 || position >= Model.Length)
                    throw new InvalidOperationException();
                return Model[position];
            }
        }
        public bool MoveNext()
        {
            if (position < Model.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset()
        {
            position = -1;
        }
    }
}
