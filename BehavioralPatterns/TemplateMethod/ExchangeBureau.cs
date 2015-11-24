namespace TemplateMethod
{
    /// <summary>
    /// The Abstract "ExchangeBureau" class
    /// </summary>
    public abstract class ExchangeBureau
    {
        protected abstract decimal MoneyToExchange { get; set; }

        public abstract void ReceiveMoney(decimal money);

        public abstract void ExchangeMoney();

        public abstract void ReturnMoney();

        public void TemplateMethod(decimal money)
        {
            ReceiveMoney(money);
            ExchangeMoney();
            ReturnMoney();
        }
    }
}
