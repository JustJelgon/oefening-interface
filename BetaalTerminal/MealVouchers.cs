using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaalTerminal
{
    class MealVouchers : IPaymentMethod
    {
        public string GetName()
        {
            return "Meal Vouchers";
        }

        public bool IsPaymentSucceeded()
        {
            Console.WriteLine("Vul de 3 laatste cijfers in van je mealvouchers kaart:");
            int availableBudget = int.Parse(Console.ReadLine());

            Console.WriteLine("Vul het te betalen bedrag in:");
            int paymentAmount = int.Parse(Console.ReadLine());

            return availableBudget >= paymentAmount;
        }

        public string GetPaymentSucceededMessage()
        {
            return "Betaling via MealVouchers was geslaagd.";
        }

        public string GetPaymentFailedMessage()
        {
            return "Betaling via MealVouchers is mislukt.";
        }

        public void StartPaymentProcess()
        {
        }
    }
}
