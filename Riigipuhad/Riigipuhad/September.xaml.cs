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
            InitializeComponent();
            lbl0 = new Label()
            {
                Text = "13. september – vanavanemate päev",
            }; lbl1 = new Label()
            {
                Text = "22. september – vastupanuvõitluse päev",
            }; lbl2 = new Label()
            {
                Text = "1. september – teadmistepäev",
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl0,lbl1,lbl2 }
            }; stackLayout.Orientation = StackOrientation.Vertical;
        }
    }
}