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
    public partial class Jaanuar : ContentPage
    {
        Label lbl1, lbl2;
        public Jaanuar()
        {
            lbl1 = new Label()
            {
                Text = "1. jaanuar – uusaasta (kolmapäev)",
                TextColor = Color.FromHex("#3c4880")
                
            }; lbl2 = new Label()
            {
                Text = "6. jaanuar – kolmekuningapäev",
                TextColor = Color.FromHex("#3c4880")
            }; 
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#72a2ff"),
                Children = { lbl1, lbl2 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}