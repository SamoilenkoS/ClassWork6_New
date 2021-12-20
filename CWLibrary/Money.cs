using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary
{
    public class Money
    {
        private int _intPart;
        private int _coins;

        public int IntPart => _intPart;
        public int Coins => _coins;

        public Money(int intPart, int coins)
        {
            _intPart = intPart;
            _coins = coins;
        }

        public static Money operator +(Money a, Money b)
        {
            int intResult = a.IntPart + b.IntPart;
            int coinsResult = a.Coins + b.Coins;
            if (coinsResult > 100)
            {
                coinsResult %= 100;
                ++intResult;
            }

            return new Money(intResult, coinsResult);
        }

        public static explicit operator int(Money a)
        {
            return a.IntPart * 100 + a.Coins;
        }

        public override string ToString()
        {
            return $"{IntPart}.{Coins}";
        }
    }
}
