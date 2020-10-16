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
    public partial class April : ContentPage
    {
        Label lbl1, lbl2;
        public April()
        {
            lbl1 = new Label()
            {
                Text = "12. aprill - ülestõusmispühade 1. püha (pühapäev)",
                TextColor = Color.FromHex("#256028")
            };
            lbl2 = new Label()
            {
                Text = "23. aprill - veteranipäev",
                TextColor = Color.FromHex("#256028")
            };
            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#25a028"),
                Children = { lbl1, lbl2 }
            }; stackLayout.Orientation = StackOrientation.Vertical;

        }
    }
}