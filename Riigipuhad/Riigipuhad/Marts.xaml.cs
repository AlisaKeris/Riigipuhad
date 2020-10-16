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
    public partial class Marts : ContentPage
    {
        Label lbl0;
        public Marts()
        {
            lbl0 = new Label()
            {
                Text = "14. märts – emakeelepäev",
                TextColor = Color.FromHex("#256028")
            };
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#25a028"),
                Children = { lbl0 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
            Content = stackLayout;
        }
    }
}