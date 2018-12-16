using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using MyTCPLib;

namespace YouNotAlone
{

    public partial class MainPage : ContentPage
    {
        //0.tcp.ngrok.io:15407
        const int port = 15407;
        const string address = "0.tcp.ngrok.io";

        

        private List<Category> categories = new List<Category>();

        public MainPage()
        {
            InitializeComponent();

            categories.Add(new Category { id = 1, Name = "One1" });
            categories.Add(new Category { id = 2, Name = "Two2" });

            ListPanel.ItemsSource = categories;

            //GetConnect();
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
                    categories = (List<Category>)formatter.Deserialize(stream);
                    break;
                }
            }

            ListPanel.ItemsSource = categories;
        }
    }
}
