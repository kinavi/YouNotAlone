using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using MyTCPLib;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace YouNotAlone.ViewModels
{
    class CategoryListViewModel : INotifyPropertyChanged
    {
        //0.tcp.ngrok.io:17196
        const int port = 17516;
        const string address = "0.tcp.ngrok.io";

        public ObservableCollection<Category> Categories { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation { get; set; }

        public CategoryListViewModel()
        {
            Categories = new ObservableCollection<Category>();

            LoadDataForServer();


        }

        Category selectedCategory;
        public Category SelectedCategory
        {
            get { return selectedCategory; }
            set
            {
                if (selectedCategory != value)
                {
                    Category tempFriend = value;
                    selectedCategory = null;
                    OnPropertyChanged("SelectedFriend");
                    //Navigation.PushAsync(new FriendPage(tempFriend));
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        void LoadDataForServer()
        {
            TcpClient client = null;

            client = new TcpClient(address, port);
            NetworkStream stream = client.GetStream();
            BinaryFormatter formatter = new BinaryFormatter();
            ClinetMessage messenge;

            messenge = new ClinetMessage(TypeMasseng.GetCategories);
            formatter.Serialize(stream, messenge);

            while (true)
            {
                if (stream.DataAvailable)
                {
                    Categories = ConvertListToObservableCollection((List<Category>)formatter.Deserialize(stream));

                    break;
                }
            }
        }

        ObservableCollection<Category> ConvertListToObservableCollection(List<Category> list)
        {
            ObservableCollection<Category> tmp = new ObservableCollection<Category>();

            if (list.Count > 0)
            {
                foreach (Category c in list)
                {
                    tmp.Add(c);
                }
            }

            return tmp;
        }

        async Task GetConnect()
        {
            TcpClient client = null;

            client = new TcpClient(address, port);
            NetworkStream stream = client.GetStream();
            BinaryFormatter formatter = new BinaryFormatter();
            ClinetMessage messenge;

            messenge = new ClinetMessage(TypeMasseng.GetCategories);
            formatter.Serialize(stream, messenge);

            while (true)
            {
                if (stream.DataAvailable)
                {
                    Categories = (ObservableCollection<Category>)formatter.Deserialize(stream);
                    break;
                }
            }

            //ListPanel.ItemsSource = categories;
        }
    }
}
