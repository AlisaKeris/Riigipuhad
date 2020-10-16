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
    public partial class September : ContentPage
    {
        Label lbl0, lbl1, lbl2;
        public September()
        {
            lbl0 = new Label()
            {
                Text = "13. september – vanavanemate päev",
                TextColor = Color.FromHex("#612e01")
            }; lbl1 = new Label()
            {
                Text = "22. september – vastupanuvõitluse päev",
                TextColor = Color.FromHex("#612e01")
            }; lbl2 = new Label()
            {
                Text = "1. september – teadmistepäev",
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