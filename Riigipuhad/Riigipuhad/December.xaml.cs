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
    public partial class December : ContentPage
    {
        Label lbl1,lbl2,lbl3;
        public December()
        {
            lbl1 = new Label()
            {
                Text = "24. detsember – jõululaupäev (neljapäev)",
                TextColor = Color.FromHex("#3c4880")
            }; lbl2 = new Label()
            {
                Text = "25. detsember – esimene jõulupüha (reede)",
                TextColor = Color.FromHex("#3c4880")
            }; lbl3 = new Label()
            {
                Text = "26. detsember – teine jõulupüha (laupäev)",
                TextColor = Color.FromHex("#3c4880")
            };
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#72a2ff"),
                Children = { lbl1,lbl2,lbl3 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
            Content = stackLayout;
        }
    }
}