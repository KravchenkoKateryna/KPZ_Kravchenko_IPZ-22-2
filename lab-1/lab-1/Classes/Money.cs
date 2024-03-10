namespace lab_1.Classes
{
    public class Money
    {
        private int _mainPart = 0;
        private int _cents = 0;

        public Money(int mainPart, int cents)
        {
            SetMoneyMain(mainPart);
            SetCents(cents);
        }

        public int GetMoneyMain()
        {
            return _mainPart;
        }

        public void SetMoneyMain(int mainPart)
        {
            if (mainPart < 0)
                throw new Exception("Main part value should be larger than 0.");

            _mainPart = mainPart;
        }

        public int GetCents()
        {
            return _cents;
        }

        public void SetCents(int cents)
        {
            if (cents < 0 || cents >= 100)
                throw new Exception("Cents value should be between 0 and 99.");

            _cents = cents;
        }

        public string GetMoneySum()
        {
            return $"{_mainPart}.{_cents}";
        }

        public static bool operator >(Money left, Money right) =>
            100 * left.GetMoneyMain() + left.GetCents() > 100 * right.GetMoneyMain() + right.GetCents();

        public static bool operator <(Money left, Money right) =>
            100 * left.GetMoneyMain() + left.GetCents() < 100 * right.GetMoneyMain() + right.GetCents();

        public static Money operator -(Money left, Money right)
        {
            int cents = 100 * left.GetMoneyMain() + left.GetCents() - 100 * right.GetMoneyMain() + right.GetCents();

            return new Money(cents / 100, cents % 100);
        }
        public static Money operator +(Money left, Money right)
        {
            int cents = 100 * left.GetMoneyMain() + left.GetCents() + 100 * right.GetMoneyMain() + right.GetCents();

            return new Money(cents / 100, cents % 100);
        }
    }
}
