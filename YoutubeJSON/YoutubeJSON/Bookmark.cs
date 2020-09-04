using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeJSON
{
    class Bookmark
    {
        string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,
        "db.sqlite");
        SQLite.Net.SQLiteConnection conn = new SQLite.Net.SQLiteConnection(new
        SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);

        conn.CreateTable<Mark>(); 

        conn.Insert(new Customer()
        {
            Name = textBox.Text, 
            Age = textBoxl.Text
        }); 

        var query = conn.Table<Customer>();
        string id = ""; string name = "";
        string age = ""; 
        
        foreach (var message in query) { 
            id = id + " " + message.Id; 
            name = name + " " + message.Name; 
            age = age + " " + message.Age;
    }
}
