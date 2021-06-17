using System;
using System.Collections;

namespace IEnumerable_IEnumerator
{
    class CarModelEnumerator : IEnumerator
    {
        string[] Model;
        int position = -1;
        public CarModelEnumerator(string[] days)
        {
            this.Model = days;
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
