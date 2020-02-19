using System;
using System.Collections.Generic;

namespace WidgetCompositionTotal
{
    class Program
    {
        static void Main(string[] args) {


            /* Write a program to calculate the price of :
       * 3 bronze widgets
       * 7 silver widtets
       * 9 gold widgets
       */

            var widgets = new List<Iproduct>();

            for (var idx = 0; idx < 3; idx++) {
                widgets.Add(new BronzeWidget());
            }
            for (var idx2 = 0; idx2 < 7; idx2++) {
                widgets.Add(new SilverWidget());
            }

            for (var idx3 = 0; idx3 < 9; idx3++) {
                widgets.Add(new GoldWidget());
            }
            var total = 0.00;
            foreach (var widget in widgets) {
                Console.WriteLine($"Widget is model {widget.GetModelName()} made in {widget.GetStateName()}");
                total += widget.GetPrice();
            }
            Console.WriteLine($"Total is {total}");




        }
    }
}
