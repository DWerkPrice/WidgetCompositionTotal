using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetCompositionTotal
{
    public class GoldWidget : Iproduct
    {
        private Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();
        }

        // no quatity because quantity would not describe one type
        public string GetStateName() {
            return Product.GetStateName();
        }

        public string GetModelName() {
            return Product.GetModelName();
        }
        public GoldWidget() {
            Product = new Product {
                Code = "GW" ,
                Name = "Gold Widget" ,
                Model = ModelType.Gold
            };
        }
    }
}