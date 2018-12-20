using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YouNotAlone.Views;
using Xamvvm;
using YouNotAlone.Page;
using DLToolkit.Forms.Controls;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace YouNotAlone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FlowListView.Init();


            var factory = new XamvvmFormsFactory(this);
            factory.RegisterNavigationPage<MainNavigationPageModel>(() => this.GetPageFromCache<CategoryListModel>());

            XamvvmCore.SetCurrentFactory(factory);
            MainPage = this.GetPageFromCache<MainNavigationPageModel>() as NavigationPage;

            //MainPage = new NavigationPage(new CategoryListPage());//new MainPage();//
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
