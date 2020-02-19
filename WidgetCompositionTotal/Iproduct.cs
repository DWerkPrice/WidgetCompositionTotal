using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetCompositionTotal// need interface to put products into same collection
{
    public interface Iproduct
    {

        public double GetPrice();
        public string GetStateName();
        public string GetModelName();
    }
}
