using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlRashid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPageMaster : ContentPage
    {
        public ListView ListView;

        public MasterPageMaster()
        {
            InitializeComponent();

            BindingContext = new MasterPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterPageMenuItem> MenuItems { get; set; }
            
            public MasterPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterPageMenuItem>(new[]
                {
                    new MasterPageMenuItem { Id = 0,IconSource="icon_home32.png", Title = "Home", TargetType = typeof(HomePage) },
                    new MasterPageMenuItem { Id = 1,IconSource="icon_contacts32.png",  Title = "Contact US",TargetType = typeof(ContactPage) },
                    new MasterPageMenuItem { Id = 2,IconSource="icon_about24.png",  Title = "About",TargetType = typeof(AboutPage) }
                    
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}