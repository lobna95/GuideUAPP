using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GuideUAPP.Database
{
    class Connection
    {
        public SQLiteConnection db;

        public Connection()
        {
            string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Guide-U.db3");
            db = new SQLiteConnection(dbpath);

            db.CreateTable<User>();
        }

    }
}
