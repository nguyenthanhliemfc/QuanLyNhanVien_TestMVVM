using QuanLyNhanVien.ViewModel;
using System;
using QuanLyNhanVien.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuanLyNhanVien.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DS_NhanVienView : ContentPage
    {
        public DS_NhanVienView()
        {
            InitializeComponent();
            this.BindingContext = new DS_NhanVienViewModel();
        }

        private void ListViewDS_NhanVien_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var selectedItem = ListViewDS_NhanVien.SelectedItem as NhanVien;
                Navigation.PushModalAsync(new NavigationPage(new ChiTietNhanVienView(selectedItem)));
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

        }
    }
}