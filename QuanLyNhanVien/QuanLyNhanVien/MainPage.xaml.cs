using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanVien.View;
using Xamarin.Forms;

namespace QuanLyNhanVien
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<object, string>(this,"MenuPage", (s, e) =>
            {
                var pagePicked = e;
                switch (pagePicked)
                {
                    case "TrangChinh":
                        Detail = new DS_NhanVienView();
                        IsPresented = !IsPresented;
                        break;
                    case "Them":
                        Detail = new ThemNhanVienView();
                        IsPresented = !IsPresented;
                        break;
                }
            });
        }
    }
}
