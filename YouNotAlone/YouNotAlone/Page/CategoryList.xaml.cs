using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamvvm;

namespace YouNotAlone.Page
{
	public partial class CategoryList : IBasePage<CategoryListModel>
    {
		public CategoryList ()
		{
			InitializeComponent ();
		}
	}
}