using MVVM.ViewModels;
using MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XLabs.Forms.Mvvm;

namespace MVVM
{
    public class App : Application
    {
        public static Views.MainMVVMPage GUI;
        public Action ContentChanging_Action;
        public App()
        {

            // The root page of your application
            Setup.Init();
            MainPage = new NavigationPage((Page)ViewFactory.CreatePage<MainViewModel, MainMVVMPage>());


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
