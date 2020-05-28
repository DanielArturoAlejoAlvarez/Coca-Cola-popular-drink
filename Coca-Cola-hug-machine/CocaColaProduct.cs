using System;
namespace Coca_Cola_hug_machine
{
    public class CocaColaProduct
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int QTY { get; set; }
        public double Price { get; set; }
        public double Balance { get; set; }

        public CocaColaProduct()
        {
        }

        public void SumQty(int qty)
        {
            this.QTY += qty;
        }

        public bool ValidateQTY()
        {
            if (this.QTY > 0)
            {
                return true;
            }
            return false;
        }

        public bool ValidatePrice(double payment)
        {
            if (this.Price <= payment)
            {
                this.Balance = payment - this.Price;
                return true;
            }
            return false;
        }

        public void SubstrProduct()
        {
            this.QTY--;
        }
    }
}
