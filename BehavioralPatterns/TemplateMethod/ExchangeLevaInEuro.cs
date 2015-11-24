namespace TemplateMethod
{
    using System;
    /// <summary>
    /// The concrete "ExchangeLevaInEuro" class
    /// </summary>
    public class ExchangeLevaInEuro : ExchangeBureau
    {
        private const string MoneyLessOrEqualToZero = "Money less or equal to zero cannot be exchanged!";
        private const decimal EuroConst = 1.9558m; //23.09.2015

        private decimal moneyToExchange;
        private decimal exchangedMoney;

        protected override decimal MoneyToExchange
        {
            get
            {
                return this.moneyToExchange;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(MoneyLessOrEqualToZero);
                }

                this.moneyToExchange = value;
            }
        }

        public override void ReceiveMoney(decimal money)
        {
            this.MoneyToExchange = money;
            Console.WriteLine("Received money in leva: " + this.MoneyToExchange + "lv.");
        }

        public override void ExchangeMoney()
        {
            this.exchangedMoney = this.MoneyToExchange / EuroConst;
            Console.WriteLine("Money was exchanged.");
        }

        public override void ReturnMoney()
        {
            Console.WriteLine("Money in euro: " + this.exchangedMoney + "EU.");
        }
    }
}
