using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Card
    {
        public float Cash { get; private set; }
        public int Number { get; private set; } 
        public string BIO { get; private set; }
        public DateTime Validity { get; private set; }
        private int Pin { get; set; }
        public static float CreditLimit;
        static Card()
        {
            CreditLimit = float.MinValue;
        }
        public Card(float cash, int number, string bio, DateTime validity, int pin)
        {
            Cash = cash;
            Number = number;
            BIO = bio;
            Validity = validity;
            Pin = pin;
        }
        public delegate void Notify(string mess);
        public event Notify OnNotify;
        public void SetPin(int pin)
        {
            Pin = pin;
            OnNotify.Invoke("PIN code has been changed");
        }
        public void TopUp(float cash)
        {
            Cash += cash;
            OnNotify.Invoke($"{cash}$ credited to the account");
        }
        public void TakeOff(float cash)
        {
            Cash -= cash;
            OnNotify.Invoke($"{cash} has been deducted");
        }
    }
}
