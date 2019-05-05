using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Foundation;
using QuanLyNhanVien.iOS;
using QuanLyNhanVien.Model;
using SQLite;
using UIKit;

[assembly:Dependency(typeof(SQLite_iOS))]
namespace QuanLyNhanVien.iOS
{
    public class SQLite_iOS:ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "QLNV.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); 
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFilename);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}