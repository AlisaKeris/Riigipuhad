using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Riigipuhad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Juuni : ContentPage
    {
        Label lbl0, lbl1, lbl2, lbl3;
        public Juuni()
        {
            
            lbl0 = new Label()
            {
                Text = "4. juuni – Eesti lipu päev",
                TextColor = Color.FromHex("#897d03")
            };
            lbl1 = new Label()
            {
                Text = "23. juuni – võidupüha (teisipäev)",
                TextColor = Color.FromHex("#897d03")
            }; lbl2 = new Label()
            {
                Text = "24. juuni – jaanipäev (kolmapäev)",
                TextColor = Color.FromHex("#897d03")
            }; lbl3 = new Label()
            {
                Text = "14. juuni – leinapäev",
                TextColor = Color.FromHex("#897d03")
            };
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#ebcc03"),
                Children = { lbl0,lbl1,lbl2,lbl3 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
            Content = stackLayout;
        }
    }
}