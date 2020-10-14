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
            InitializeComponent();
            lbl0 = new Label()
            {
                Text = "1. mai – kevadpüha (reede)",
            };
            lbl1 = new Label()
            {
                Text = "31. mai - nelipühade 1. püha (pühapäev)",
            }; lbl2 = new Label()
            {
                Text = "10. mai - emadepäev",
            }; lbl3 = new Label()
            {
                Text = "9. mai – Euroopa päev",
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl0, lbl1, lbl2, lbl3 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}