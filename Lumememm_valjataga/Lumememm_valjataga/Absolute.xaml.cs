using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm_valjataga
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Absolute : ContentPage
    {
        public Absolute()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                BackgroundColor=Color.Aqua
            };

            BoxView head = new BoxView { BackgroundColor = Color.White, CornerRadius= 100};
            BoxView keha = new BoxView { BackgroundColor = Color.White, CornerRadius = 100 };
            BoxView jalad = new BoxView { BackgroundColor = Color.White, CornerRadius = 100 };
            BoxView nina = new BoxView { BackgroundColor = Color.Orange, CornerRadius = 100 };
            BoxView silmad = new BoxView { BackgroundColor = Color.Black, CornerRadius = 100 };
            BoxView silmad1 = new BoxView { BackgroundColor = Color.Black, CornerRadius = 100 };



            AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.5, 0.02, 110, 110));
            AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(keha, new Rectangle(0.5, 0.25, 150, 150));
            AbsoluteLayout.SetLayoutFlags(keha, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(jalad, new Rectangle(0.5, 0.55, 140, 140));
            AbsoluteLayout.SetLayoutFlags(jalad, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(nina, new Rectangle(0.5, 0.13, 20, 20));
            AbsoluteLayout.SetLayoutFlags(nina, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(silmad, new Rectangle(0.4, 0.05, 10, 10));
            AbsoluteLayout.SetLayoutFlags(silmad, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(silmad1, new Rectangle(0.6, 0.08, 10, 10));
            AbsoluteLayout.SetLayoutFlags(silmad1, AbsoluteLayoutFlags.PositionProportional);
            

            absoluteLayout.Children.Add(head);
            absoluteLayout.Children.Add(keha);
            absoluteLayout.Children.Add(jalad);
            absoluteLayout.Children.Add(nina);
            absoluteLayout.Children.Add(silmad);
            absoluteLayout.Children.Add(silmad1);

            Content = absoluteLayout;
        }
    }

}