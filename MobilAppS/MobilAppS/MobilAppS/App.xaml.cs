﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace MobilAppS
{
    public partial class App : Application
    {

        private static DB db;
        public static DB Db 
        {
            get 
            {
                if (db == null)
                    db = new DB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "db.sqlite1"));
                return db;
            } 
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
