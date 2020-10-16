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
    public partial class November : ContentPage
    {
        Label lbl0, lbl1, lbl2;
        public November()
        {
            lbl0 = new Label()
            {
                Text = "2. november – hingedepäev",
                TextColor = Color.FromHex("#612e01")
            }; lbl1 = new Label()
            {
                Text = "8. november – isadepäev",
                TextColor = Color.FromHex("#612e01")
            }; lbl2 = new Label()
            {
                Text = "16. november – taassünnipäev",
                TextColor = Color.FromHex("#612e01")
            };
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#fea201"),
                Children = { lbl0,lbl1,lbl2 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}