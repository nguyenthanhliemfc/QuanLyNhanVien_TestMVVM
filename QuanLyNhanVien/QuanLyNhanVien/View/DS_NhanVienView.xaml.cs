using QuanLyNhanVien.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuanLyNhanVien.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DS_NhanVienView : ContentPage
    {
        private DS_NhanVienViewModel dsNhanVien;
        public DS_NhanVienView()
        {
            InitializeComponent();
            this.BindingContext = dsNhanVien = new DS_NhanVienViewModel();
        }

        private void ListViewDS_NhanVien_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {

            }
        }

        private void ButtonThem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ThemNhanVienView());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var ds = dsNhanVien.LayDanhSachNhanVien;
        }
    }
}