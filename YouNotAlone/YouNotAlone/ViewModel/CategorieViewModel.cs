using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace YouNotAlone.ViewModel
{
    class CategorieViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Model.Categorie categorie;

        public CategorieViewModel()
        {
            categorie = new Model.Categorie();
        }

        public string Name {
            get { return categorie.Name; }
            set {
                if(categorie.Name!=value)
                {
                    categorie.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
