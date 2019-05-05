using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.Model;
using QuanLyNhanVien.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuanLyNhanVien.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChiTietNhanVienView : ContentPage
    {
        private NhanVien nhanVien;
        private ChiTietNhanVienViewModel viewModel;
        public ChiTietNhanVienView(NhanVien selectedItem)
        {
            InitializeComponent();
            nhanVien = selectedItem;
            viewModel = new ChiTietNhanVienViewModel(nhanVien, Navigation);
            BindingContext = viewModel;
        }
    }
}