﻿namespace MauiAppTaxaBasal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new NavigationPage(new Views.LoginPage()));
            #if WINDOWS
            window.Width = 400;
            window.Height = 800;
            #endif

            return window;
        }
    }
}