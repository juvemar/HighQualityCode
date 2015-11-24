namespace TemplateMethod
{
    using System;

    public class TestingTemplateMethod
    {
        static void Main()
        {
            ExchangeBureau firstBureau = new ExchangeEuroInLeva();
            ExchangeBureau secondBureau = new ExchangeLevaInEuro();

            firstBureau.TemplateMethod(100.0m);

            Console.WriteLine();

            secondBureau.TemplateMethod(200.9m);
        }
    }
}
