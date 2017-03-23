using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAllianceApp.Models;

namespace XamarinAllianceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        Character ch;
        public DetailPage(Character ch)
        {
            InitializeComponent();
            BindingContext = this.ch = ch;
        }
    }
}
