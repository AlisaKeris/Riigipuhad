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
    public partial class Veebruar : ContentPage
    {
        Label lbl0, lbl1;
        public Veebruar()
        {
            lbl0 = new Label()
            {
                Text = "24. veebruar – Eesti iseseisvuspäev",
                TextColor = Color.FromHex("#3c4880")
            }; lbl1 = new Label()
            {
                Text = "2. veebruar – Tartu rahulepingu aastapäev",
                TextColor = Color.FromHex("#3c4880")
            }; 
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#72a2ff"),
                Children = { lbl0, lbl1}
            }; stackLayout.Orientation = StackOrientation.Vertical;
            Content = stackLayout;
        }
    }
}