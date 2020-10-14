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
            InitializeComponent();
            lbl1 = new Label()
            {
                Text = "12. aprill - ülestõusmispühade 1. püha (pühapäev)",
            };
            lbl2 = new Label()
            {
                Text = "23. aprill - veteranipäev"
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl1, lbl2 }
            }; stackLayout.Orientation = StackOrientation.Vertical;

        }
    }
}