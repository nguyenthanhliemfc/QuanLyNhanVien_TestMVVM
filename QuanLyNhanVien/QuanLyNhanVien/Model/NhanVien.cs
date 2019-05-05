using SQLite;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace QuanLyNhanVien.Model
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
    public class NhanVien
    {
        [PrimaryKey, AutoIncrement] public int Id { get; set; }
        public string HoVaTen { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }

        private readonly SQLiteConnection _sqLiteConnection;
        public NhanVien()
        {
            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqLiteConnection.CreateTable<NhanVien>();
        }
        ObservableCollection<NhanVien> DSNhanVien = new ObservableCollection<NhanVien>();
        public ObservableCollection<NhanVien> LayDanhSachNhanVien()
        {
            var dsNhanVien = _sqLiteConnection.Table<NhanVien>().ToList();
            foreach (var nhanVien in dsNhanVien)
            {
                DSNhanVien.Add(nhanVien);
            }
            return DSNhanVien;
        }

        public int ThemNhanVien(NhanVien nhanVien)
        {
           var result = _sqLiteConnection.Insert(nhanVien);
           return result;
        }

        public int XoaNhanVien(NhanVien nhanVien)
        {
            var result = _sqLiteConnection.Delete(nhanVien);
            return result;
        }
    }
}
