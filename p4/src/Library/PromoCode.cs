using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode : IOfferItem
    {
        public string code {get;set;}
        public int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (value >= 0)
                {
                    throw new ArgumentException("El descuento no puede ser mayor a 0");
                }
                else
                {
                    this.amount = value;
                }
            }
        }

        public PromoCode(string code, int amount)
        {
            this.code = code;
            this.SubTotal = amount;
        }
    }
}