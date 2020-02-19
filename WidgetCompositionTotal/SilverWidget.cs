using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetCompositionTotal
{
    public class SilverWidget : Iproduct
    {
        private Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();
        }

        // no quatity because quantity would not describe one type

        public string GetModelName() {
            return Product.GetModelName();
        }
        public string GetStateName() {
            return Product.GetStateName();
        }

        public SilverWidget() {
            Product = new Product {
                Code = "SW" ,
                Name = "Silver Widget" ,
                Model = ModelType.Silver
            };
        }
    }
}