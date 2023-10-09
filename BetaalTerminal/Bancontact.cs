using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaalTerminal
{
    internal class Bancontact : IPaymentMethod
    {
        public string GetName()
        {
            return "Bancontact";
        }

        public bool IsPaymentSucceeded()
        {
            return true;
        }

        public string GetPaymentSucceededMessage()
        {
            return "Betaling via Bancontact was geslaagd.";
        }

        public string GetPaymentFailedMessage()
        {
            return "Betaling via Bancontact mislukt.";
        }

        public void StartPaymentProcess()
        {
            Console.WriteLine("Vul je kaartnummer in:");
            string cardNumber = Console.ReadLine();

            Console.WriteLine("Vul je PIN in:");
            string pin = Console.ReadLine();

            if (cardNumber.Contains(pin) != true)
            {
                Console.WriteLine("Betaling is geslaagd!");
            }
            else {
                Console.WriteLine("Betaling is mislukt!");
                    }
        }
    }
}
