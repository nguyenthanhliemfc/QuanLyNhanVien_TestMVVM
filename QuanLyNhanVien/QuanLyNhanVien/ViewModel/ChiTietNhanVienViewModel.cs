using QuanLyNhanVien.Model;
using System.Windows.Input;
using Xamarin.Forms;

namespace QuanLyNhanVien.ViewModel
{
    public class ChiTietNhanVienViewModel
    {
        private NhanVien nhanVien;

        public NhanVien NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }
        public ICommand Xoa { set; get; }
        private INavigation Navigation;
        public ChiTietNhanVienViewModel(NhanVien nhanVien, INavigation navigation)
        {
            NhanVien = nhanVien;
            Navigation = navigation;
            Xoa = new Command(() =>
            {
                nhanVien.XoaNhanVien(nhanVien);
                Navigation.PopModalAsync();
            });
        }
    }
}
