using QuanLyNhanVien.Model;
using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace QuanLyNhanVien.ViewModel
{
    public class ThemNhanVienViewModel
    {
        private NhanVien nhanvien = new NhanVien();
        public ICommand Them { set; get; }
        public ICommand Dong { set; get; }
        public INavigation Navigation;

        public string hoVaTen;

        public string HoVaTen
        {
            get { return hoVaTen; }
            set
            {
                if (hoVaTen != value)
                    hoVaTen = value;
            }
        }

        public int tuoi;

        public int Tuoi
        {
            get { return tuoi; }
            set
            {
                if (tuoi != value)
                    tuoi = value;
            }
        }

        public string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set
            {
                if (diaChi != value)
                    diaChi = value;
            }
        }

        public ThemNhanVienViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Them = new Command(() =>
            {
                nhanvien.HoVaTen = hoVaTen;
                nhanvien.Tuoi = tuoi;
                nhanvien.DiaChi = diaChi;
                var result = nhanvien.ThemNhanVien(nhanvien);
                Debug.WriteLine("Them result: " + result);
            });
            Dong = new Command(() => { Navigation.PopModalAsync(); });
        }
        

       
    }
}
