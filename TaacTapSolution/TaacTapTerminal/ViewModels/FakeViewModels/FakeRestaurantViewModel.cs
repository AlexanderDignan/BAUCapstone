using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaacTapTerminal.Models;
using TaacTapTerminal.SampleData;

namespace TaacTapTerminal.ViewModels
{
   public class FakeRestaurantViewModel : NotificationBase
    {
        FakeRestaurantModel fakeRestaurant;

        public FakeRestaurantViewModel(String name)
        {
            fakeRestaurant = new FakeRestaurantModel(name);
            _SelectedIndex = -1;
            // Load the database
            foreach (var table in fakeRestaurant.Table)
            {
                var np = new FakeTableViewModel(table);
                np.PropertyChanged += Table_OnNotifyPropertyChanged;
                _Table.Add(np);
            }
        }
        ObservableCollection<FakeTableViewModel> _Table
          = new ObservableCollection<FakeTableViewModel>();
        public ObservableCollection<FakeTableViewModel> Table
        {
            get { return _Table; }
            set { SetProperty(ref _Table, value); }
        }
        String _Name;
        public String Name
        {
            get { return fakeRestaurant.Name; }
        }

        int _SelectedIndex;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set
            {
                if (SetProperty(ref _SelectedIndex, value))
                { RaisePropertyChanged(nameof(SelectedTable)); }
            }
            }

             public FakeTableViewModel SelectedTable
        {
            get { return (_SelectedIndex >= 0) ? _Table[_SelectedIndex] : null; }
        }
        public void Add()
        {
            var table = new FakeTableViewModel();
            table.PropertyChanged += Table_OnNotifyPropertyChanged;
            Table.Add(table);
            fakeRestaurant.Add(table);
            SelectedIndex = Table.IndexOf(table);
        }
        public void Delete()
        {
            if (SelectedIndex != -1)
            {
                var table = Table[SelectedIndex];
                Table.RemoveAt(SelectedIndex);
                fakeRestaurant.Delete(table);
            }
        }

        void Table_OnNotifyPropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            fakeRestaurant.Update((FakeTableViewModel)sender);
        }


    }



}

