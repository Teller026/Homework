using System;

namespace TaskApp
{
    public class BoolArray
    {
        private bool[] _data;
        public BoolArray(int size)
        {
            _data = new bool[size];
        }
        public bool this[int index]
        {
            get
            {
                if (index < 0 || index >= _data.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return !_data[index];
            }
            set
            {
                if (index >= 0 && index < _data.Length)
                {
                    _data[index] = value;
                }
            }
        }
        public bool State
        {
            get
            {
                bool result = false;
                foreach (bool item in _data)
                {
                    result |= item;
                    if (result) break;
                }
                return result;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BoolArray container = new BoolArray(3);
            
            container[0] = true;
            container[1] = false;
            container[2] = false;

            Console.WriteLine(container[0]);
            Console.WriteLine(container[1]);
            Console.WriteLine(container.State);
        }
    }
}
