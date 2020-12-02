using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VrWebAppliucationWeek2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Naviation.PushAsync(new NextPage());
        }
        private void MenuItem2_OnClicked(object sender, EventArgs e)
        {
            Naviation.PushAsync(new NextPage());
        }
    }
}