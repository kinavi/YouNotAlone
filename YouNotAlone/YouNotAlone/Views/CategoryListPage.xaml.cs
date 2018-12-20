using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouNotAlone.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YouNotAlone.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategoryListPage : ContentPage
	{
		public CategoryListPage ()
		{
			InitializeComponent ();

            BindingContext = new CategoryListViewModel() { Navigation = this.Navigation };
        }
	}
}