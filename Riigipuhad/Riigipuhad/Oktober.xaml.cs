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
    public partial class Oktober : ContentPage
    {
        Label lbl0;
        public Oktober()
        {
            lbl0 = new Label()
            {
                Text = "17. oktoober – hõimupäev",
                TextColor = Color.FromHex("#612e01")
            }; 
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#fea201"),
                Children = { lbl0}
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}