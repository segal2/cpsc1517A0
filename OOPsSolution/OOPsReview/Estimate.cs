using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Estimate
    {
        public double TotalPrice { get; private set; }

        //LinearLength is  variable of datatype double
        public double LinearLength { get; set; }

        //Panel is a vaiable of datatype FencePanel
        public FencePanel Panel { get; set; }

        public List<Gate> Gates { get; set; }

        public double CalculatePrice()
        {
            //assuming the Pnel and Gate instances exist and are correct 
            // there is no validation inside this example


            double numberOfPanels = Panel.EstimatedNumberOfPanels(LinearLength);

            if ((int)(numberOfPanels * 10.0) > ((int) numberOfPanels *10))
            {
                numberOfPanels = (int)numberOfPanels + 1;
            }
            //summing calculated prices 
            if( Panel.Price == null)
            {
                throw new Exception("Panel price is needed to create extimate");

            }
            else
            {
                TotalPrice += numberOfPanels * (double)Panel.Price;
                foreach (var item in Gates)
                {
                    TotalPrice += item.Price;
                }
            }
            return TotalPrice;
        }
    }
}
