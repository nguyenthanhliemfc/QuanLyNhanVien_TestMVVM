using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuanLyNhanVien.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void ButtonTrangChinh_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<object, string>(this, "MenuPage", "TrangChinh");
        }

        private void ButtonThem_OnClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<object, string>(this, "MenuPage", "Them");
        }
    }
}