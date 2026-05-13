using System;

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
}
