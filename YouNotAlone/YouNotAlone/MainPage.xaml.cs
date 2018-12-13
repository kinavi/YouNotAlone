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
        //tcp://0.tcp.ngrok.io:18706
        const int port = 12951;
        const string address = "0.tcp.ngrok.io";

        

        private List<Category> categories = new List<Category>();

        public MainPage()
        {
            InitializeComponent();

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
                    //Console.WriteLine("Сервер говорит!");
                    categories = (List<Category>)formatter.Deserialize(stream);
                    //Console.WriteLine("Категории: ");
                    //foreach (Category c in categories)
                    //{
                    //    Console.WriteLine("{0}. - {1}", c.id, c.Name);
                    //}
                    break;
                }
            }

            ListPanel.ItemsSource = categories;
        }
    }
}
