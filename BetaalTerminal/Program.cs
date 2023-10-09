using Spectre.Console;
namespace BetaalTerminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bedrag = AnsiConsole.Ask<int>("Hoeveel wil je betalen?");
            Console.WriteLine("");
            var betaalMethode = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Welke betaalmethode wil je gebruiken?")
        .PageSize(3)
        .AddChoices(new[] {
            "Paypal", "Bancontact", "MealVouchers",
        }));
            IPaymentMethod paymentMethod = null;
            if (betaalMethode == "Paypal")
            {
                paymentMethod = new PayPal();
            }
            if (betaalMethode == "Bancontact")
            {
                paymentMethod = new Bancontact();
            }
            if (betaalMethode == "MealVouchers")
            {
                paymentMethod = new MealVouchers();
            }

            paymentMethod.StartPaymentProcess();

            Console.WriteLine(paymentMethod.IsPaymentSucceeded() ? paymentMethod.GetPaymentSucceededMessage() : paymentMethod.GetPaymentFailedMessage());
        }
    }
}