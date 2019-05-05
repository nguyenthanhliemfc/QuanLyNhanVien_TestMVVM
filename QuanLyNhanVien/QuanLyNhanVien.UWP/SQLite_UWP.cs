using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using QuanLyNhanVien.Model;
using QuanLyNhanVien.UWP;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLite_UWP))]
namespace QuanLyNhanVien.UWP
{
    public class SQLite_UWP : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "QLNV.db3";
            string documentsPath = ApplicationData.Current.LocalFolder.Path;
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}
