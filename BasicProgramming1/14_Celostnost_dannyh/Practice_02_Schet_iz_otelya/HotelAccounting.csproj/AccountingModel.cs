using System;

namespace HotelAccounting
{
    public class AccountingModel : ModelBase
    {
        private double price;
        private int nightsCount;
        private double total;
        private double discount;

        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException();

                if (!Equals(price, value))
                {
                    price = value;
                    CalculateTotal();
                    Notify(nameof(Price));
                    Notify(nameof(Total));
                }
            }
        }

        public int NightsCount
        {
            get => nightsCount;
            set
            {
                if (value <= 0)
                    throw new ArgumentException();

                if (!Equals(nightsCount, value))
                {
                    nightsCount = value;
                    CalculateTotal();
                    Notify(nameof(NightsCount));
                    Notify(nameof(Total));
                }
            }
        }

        public double Discount
        {
            get => discount;
            set
            {
                if (!Equals(discount, value))
                {
                    discount = value;
                    CalculateTotal();
                    Notify(nameof(Discount));
                    Notify(nameof(Total));
                }
            }
        }

        public double Total
        {
            get => total;
            set
            {
                if (value < 0)
                    throw new ArgumentException();

                if (!Equals(total, value))
                {
                    total = value;
                    CalculateDiscount();
                    Notify(nameof(Total));
                    Notify(nameof(Discount));
                }
            }
        }

        private void CalculateTotal()
        {
            total = Price * NightsCount * (1 - Discount / 100);

            if (total < 0)
                throw new ArgumentException();
        }

        private void CalculateDiscount()
        {
            discount = (1 - Total / (Price * NightsCount)) * 100;
        }
    }
}