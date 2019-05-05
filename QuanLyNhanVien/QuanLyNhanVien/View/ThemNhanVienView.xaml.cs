using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuanLyNhanVien.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemNhanVienView : ContentPage
    {
        public ThemNhanVienView( )
        {
            this.BindingContext = new ThemNhanVienViewModel(Navigation);
            InitializeComponent();
        }
    }
}