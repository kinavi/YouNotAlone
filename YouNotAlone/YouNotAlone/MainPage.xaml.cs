using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using MyTCPLib;
using DLToolkit.Forms.Controls;

namespace YouNotAlone
{

    public partial class MainPage : ContentPage
    {
        #region oldVer
        //0.tcp.ngrok.io:17196
        const int port = 17196;
        const string address = "0.tcp.ngrok.io";

        private List<Category> categories = new List<Category>();
        #endregion

        #region Пример 2
        //Label stackLabel;

        //bool loaded = false;
        #endregion

        public MainPage()
        {
            InitializeComponent();
            //this.BindingContext = new ViewModel.PhoneViewModel
            //{
            //    Title = "iPhone 7",
            //    Company = "Apple",
            //    Price = 52000
            //};

            #region oldVer
            //FlowListView.Init();
            //InitializeComponent();


            //categories.Add(new Category { id = 1, Name = "One1" });
            //categories.Add(new Category { id = 2, Name = "Two2" });

            //ListPanel.ItemsSource = categories;
            //ListPanel.ItemsSource = categories;

            //GetConnect();
            #endregion

            #region Пример 1
            //Title = "Main Page";
            //Button toCommonPageBtn = new Button
            //{
            //    Text = "На обычную страницу",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.CenterAndExpand
            //};
            //toCommonPageBtn.Clicked += ToCommonPage;

            //Button toModalPageBtn = new Button
            //{
            //    Text = "На модальную страницу",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.CenterAndExpand
            //};
            //toModalPageBtn.Clicked += ToModalPage;

            //Content = new StackLayout { Children = { toCommonPageBtn, toModalPageBtn } };
            #endregion

            #region Пример 2
            //Title = "Main Page";
            //Button forwardButton = new Button { Text = "Вперед" };
            //forwardButton.Clicked += GoToForward;

            //stackLabel = new Label();
            //Content = new StackLayout { Children = { forwardButton, stackLabel } };
            #endregion
        }

        #region Пример 2
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    if (loaded == false)
        //    {
        //        DisplayStack();
        //        loaded = true;
        //    }
        //}

        //protected internal void DisplayStack()
        //{
        //    NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        //    stackLabel.Text = "";
        //    foreach (Xamarin.Forms.Page p in navPage.Navigation.NavigationStack)
        //    {
        //        stackLabel.Text += p.Title + "\n";
        //    }
        //}

        //// Переход вперед на Page2
        //private async void GoToForward(object sender, EventArgs e)
        //{
        //    Page.Page2 page = new Page.Page2();
        //    await Navigation.PushAsync(page);
        //    page.DisplayStack();
        //}
        #endregion

        #region Пример 1
        private async void ToModalPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage());
        }
        private async void ToCommonPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommonPage());
        }
        #endregion

        #region oldVer
        //async Task GetConnect()
        //{
        //    TcpClient client = null;

        //    client = new TcpClient(address, port);
        //    NetworkStream stream = client.GetStream();
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    ClinetMessage messenge;

        //    messenge = new ClinetMessage(TypeMasseng.GetCategories);
        //    formatter.Serialize(stream, messenge);

        //    while (true)
        //    {
        //        if (stream.DataAvailable)
        //        {
        //            categories = (List<Category>)formatter.Deserialize(stream);
        //            break;
        //        }
        //    }

        //    //ListPanel.ItemsSource = categories;
        //}
        #endregion
    }
}
