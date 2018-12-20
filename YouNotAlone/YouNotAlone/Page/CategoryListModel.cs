using System;
using System.Collections.Generic;
using System.Text;
using Xamvvm;
using MyTCPLib;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace YouNotAlone.Page
{
    public class CategoryListModel : BasePageModel
    {
        public int? ColumnCount
        {
            get { return GetField<int?>(); }
            set { SetField(value); }
        }

        public ObservableCollection<Category> Categories
        {
            get { return GetField<ObservableCollection<Category>>(); }
            set { SetField(value); }
        }

        public CategoryListModel()
        {
            Categories = new ObservableCollection<Category>() {
                new Category { id=1, Name="Вова" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name="Никита"},
                new Category { id=3, Name="Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" },
                new Category { id = 1, Name = "Вова" },
                new Category { id = 1, Name = "Никита" },
                new Category { id = 3, Name = "Петя" }
            };
            ColumnCount = 2;
        }

        


    }
}
