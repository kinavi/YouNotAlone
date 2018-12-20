using System;
using System.Collections.Generic;
using System.Text;
using Xamvvm;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace YouNotAlone.Page
{
    public class MainPageModel:BasePageModel
    {
        public MainPageModel()
        {
            WelcomeText = "Welcome to xamvvm!";

        }

        public string WelcomeText
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }

        public ICommand DetailButtonCommand
        {
            get { return GetField<ICommand>(); }
            set { SetField(value); }
        }

        public ICommand DemoListButtonCommand
        {
            get { return GetField<ICommand>(); }
            set { SetField(value); }
        }

        public ICommand MasterDetailButtonCommand
        {
            get { return GetField<ICommand>(); }
            set { SetField(value); }
        }

        public ICommand NavigationViewButtonCommand
        {
            get { return GetField<ICommand>(); }
            set { SetField(value); }
        }
    }
}
