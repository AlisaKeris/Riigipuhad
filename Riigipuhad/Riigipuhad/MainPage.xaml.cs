using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Riigipuhad
{
    public partial class MainPage : TabbedPage
    {
        Button btn;
        public MainPage()
        {
            InitializeComponent();
            btn = new Button();
            btn.Clicked += Btn_Clicked1;
        }

        private void Btn_Clicked1(object sender, EventArgs e)
        {
           var answer = DisplayActionSheet("Vali kuu", "Cancel", null, "Kevad", "Suvi", "Talv", "Sügis");
        }
    }
}
