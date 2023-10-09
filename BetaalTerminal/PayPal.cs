using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaalTerminal
{
    internal class PayPal : IPaymentMethod
    {
        public string GetName()
        {
            return "PayPal";
        }

        public bool IsPaymentSucceeded()
        {
            return true;
        }

        public string GetPaymentSucceededMessage()
        {
            return "Betaling via PayPal was geslaagd.";
        }

        public string GetPaymentFailedMessage()
        {
            return "Betaling via PayPal mislukt.";
        }

        public void StartPaymentProcess()
        {
            Console.WriteLine("vul je PayPal gebruikersnaam in:");
            string username = Console.ReadLine();

            Console.WriteLine("Vul je PayPal passwoord in:");
            string password = Console.ReadLine();

            if (username == "jelle" && password == "jelle") 
            {
                Console.WriteLine("U bent succesvol ingelogd!");
                if (!AnsiConsole.Confirm("Betaling goedkeuren?"))
                {
                    AnsiConsole.MarkupLine("Ok... :(");
                    Console.WriteLine(GetPaymentFailedMessage());
                }

                Console.WriteLine(GetPaymentSucceededMessage());
            }
            else
            {
                Console.WriteLine("Uw login is foutief!");
            }

            // In a real application, you would validate the credentials.
            // Here, we're assuming the payment is always successful for demonstration purposes.
            
        }
    }
}
