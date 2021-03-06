﻿using QuanLyNhanVien.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace QuanLyNhanVien.ViewModel
{
    public class DS_NhanVienViewModel : BaseViewModel
    {
        public ObservableCollection<NhanVien> dsNhanVien = new ObservableCollection<NhanVien>();
        public ICommand LayDanhSachNhanVien;
        public int itemCount;
        public int ItemCount
        {
            get { return itemCount; }
            set { itemCount = value; }
        }

        public ObservableCollection<NhanVien> DSNhanVien
        {
            get { return dsNhanVien; }
            set
            {
                SetProperty(ref dsNhanVien, value);
                OnPropertyChanged();
            }
        }

        public NhanVien nhanVien = new NhanVien();
        public DS_NhanVienViewModel()
        {
            LayDanhSachNhanVien = new Command(() => { DSNhanVien = nhanVien.LayDanhSachNhanVien(); });
            dsNhanVien = nhanVien.LayDanhSachNhanVien();
            itemCount = dsNhanVien.Count;
        }
    }
}
