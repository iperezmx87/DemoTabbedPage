using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tbpPrincipal : TabbedPage
    {
        public tbpPrincipal()
        {
            InitializeComponent();

            MainPage mp = new MainPage();

            NavigationPage np = new NavigationPage(mp){ Title = "Principal" };

            Children.Add(np);

            Children.Add(new ContentPage { Title = "Otra tab" });
        }
    }
}