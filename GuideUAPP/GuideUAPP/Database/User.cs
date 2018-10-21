using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuideUAPP.Database
{
   public class User
    {
        [PrimaryKey, AutoIncrement]
        public int id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        [Unique]
        public string UserName
        {
            get;
            set;
        }

        public string PhoneNum
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public DateTime DOB
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public string Country
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }

    }
}
