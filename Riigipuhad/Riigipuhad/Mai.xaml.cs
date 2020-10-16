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
    public partial class Mai : ContentPage
    {
        Label lbl0, lbl1, lbl2, lbl3;
        public Mai()
        {
            lbl0 = new Label()
            {
                Text = "1. mai – kevadpüha (reede)",
                TextColor = Color.FromHex("#256028")
            };
            lbl1 = new Label()
            {
                Text = "31. mai - nelipühade 1. püha (pühapäev)",
                TextColor = Color.FromHex("#256028")
            }; lbl2 = new Label()
            {
                Text = "10. mai - emadepäev",
                TextColor = Color.FromHex("#256028")
            }; lbl3 = new Label()
            {
                Text = "9. mai – Euroopa päev",
                TextColor = Color.FromHex("#256028")
            };
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#25a028"),
                Children = { lbl0, lbl1, lbl2, lbl3 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
            Content = stackLayout;
        }
    }
}