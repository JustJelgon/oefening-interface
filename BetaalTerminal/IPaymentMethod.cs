using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaalTerminal
{
    internal interface IPaymentMethod
    {
        string GetName();
        bool IsPaymentSucceeded();
        string GetPaymentSucceededMessage();
        string GetPaymentFailedMessage();
        void StartPaymentProcess();
    }
}
