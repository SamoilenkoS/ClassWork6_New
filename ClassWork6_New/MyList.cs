using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork6_New
{
    public class MyList
    {
        private const int DefaultSize = 4;
        private int _currentCount;
        private int[] _array;

        public int Length => _currentCount;
        public int Capacity => _array.Length;

        public int this[int index]
        {
            get
            {
                if(index >= Length || index < 0)
                {
                    throw new ArgumentException();
                }

                return _array[index];
            }
        }

        public MyList()
        {
            _array = new int[DefaultSize];
            _currentCount = 0;
        }

        public void AddBack(int el)
        {
            if(Capacity > Length)
            {
                _array[_currentCount++] = el;
            }
            else
            {
                //resize
            }
        }
    }
}
