﻿using DLToolkit.Forms.Controls;
using Xamarin.Forms;

namespace Decathlon_App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            FlowListView.Init();

            MainPage = new AppShell();
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
