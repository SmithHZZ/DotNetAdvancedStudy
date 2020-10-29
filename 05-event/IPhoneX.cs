using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_event
{
    public class IPhoneX
    {
        public int Id { set; get; }


        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                decimal oldValue = price;
                price = value;
                if (price < oldValue)
                {
                    DisCount?.Invoke(this,new EventArgs());
                }
            }
        }


        public Size Screen { set; get; }


        public event EventHandler DisCount;
    }
}
